using GCook.Data;
using GCook.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace GCook.Services;

public class UsuarioService : IUsuarioService
{
    private readonly AppDbContext _context;
    private readonly SignInManager<IdentityUser> _signManager;
    private readonly UserManager<IdentityUser> _usermanager;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public UsuarioService(AppDbContext context,
        SignInManager<IdentityUser> signInManager,
        UserManager<IdentityUser> userManager,
        IHttpContextAccessor httpContextAccessor
    )
    {
        _context = context;
        _signManager = signInManager;
        _usermanager = userManager;
        _httpContextAccessor = httpContextAccessor;
    }

    public Task<UsuarioVM> GetUsuarioLogado()
    {
        throw new NotImplementedException();
    }
}
