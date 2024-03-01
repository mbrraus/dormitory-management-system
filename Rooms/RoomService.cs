using DormitoryManagement.Data;
using DormitoryManagement.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DormitoryManagement.Rooms;

public class RoomService(IDbContextFactory<DormitoryContext> contextFactory)
{
    public async Task<List<Building>> GetAllBuildings()
    {
        await using var context = await contextFactory.CreateDbContextAsync();

        return await context.Buildings
            .Include(x => x.Floors)
            .ThenInclude(x => x.Rooms)
            .ThenInclude(x => x.RoomAssignments)
            .ToListAsync();
    }

    public async Task<Room> GetRoomById(Guid roomId)
    {
        await using var context = await contextFactory.CreateDbContextAsync();
        var room = await context.Rooms
            .Include(x => x.Floor)
            .ThenInclude(x => x.Building)
            .Include(x => x.RoomInventories)
            .ThenInclude(x => x.InventoryItem)
            .Include(x => x.RoomAssignments)
            .ThenInclude(x => x.Student)
            .SingleAsync(x => x.Id == roomId);
        return room;
    }

    public async Task<bool> AssignStudentToRoom(AddStudentToRoomRequest request)
    {
        await using var context = await contextFactory.CreateDbContextAsync();

        var student = await context.Students
            .Include(s => s.RoomAssignment)
            .SingleAsync(s => s.Id == request.StudentId);

        if (student.RoomAssignment != null)
        {
            throw new Exception("Assignment must be null!");
        }

        var roomAssignment = new RoomAssignment
        {
            StudentId = student.Id,
            RoomId = request.RoomId,
            StartDate = request.StartDate.ToUniversalTime(),
            EndDate = request.EndDate.ToUniversalTime()
        };
        student.RoomAssignment = roomAssignment;

        await context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> UnassignStudentFromRoom(Guid studentId)
    {
        await using var context = await contextFactory.CreateDbContextAsync();
        var student = await context.Students
            .Include(s => s.RoomAssignment)
            .ThenInclude(ra => ra.Room).ThenInclude(room => room.RoomAssignments)
            .SingleAsync(s => s.Id == studentId);

        if (student.RoomAssignment == null)
        {
            throw new Exception("Assignment shouldn't be null!");
        }
        else
        {
            // Retrieve the RoomAssignment entity
            var roomAssignment = student.RoomAssignment;

            // Retrieve the associated room
            var room = roomAssignment.Room;

            // Check if the room contains this assignment and remove it
            if (room.RoomAssignments.Contains(roomAssignment))
            {
                room.RoomAssignments.Remove(roomAssignment);
            }

            // Nullify the RoomAssignment reference in the student entity
            student.RoomAssignment = null;

            // Save changes to the database
            await context.SaveChangesAsync();
        }

        return true;
    }
}