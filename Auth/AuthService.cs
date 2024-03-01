using System.Security.Claims;
using DormitoryManagement.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DormitoryManagement.Auth;

public class AuthService(IDbContextFactory<DormitoryContext> contextFactory, IHttpContextAccessor httpContextAccessor)
{
    
    
}