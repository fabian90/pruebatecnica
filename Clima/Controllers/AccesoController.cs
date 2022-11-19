using System.Web.Mvc;
using Dto.Clima;
using System.Configuration;
using System.Web.Security;
using Business.Implementation;
using Common.Helper;

namespace Clima.Controllers
{
    public class AccesoController : Controller
    {
        static string cadena = ConfigurationManager.ConnectionStrings["ClimaEntities2"].ConnectionString;
        UsuarioBusiness usuarioBusiness = new UsuarioBusiness();
        // GET: Acceso
        public ActionResult Login()
        {
            return View();
        }


        public ActionResult Registrar()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Registrar(UsuarioDto usuario)
        {

            if (usuario.Clave == usuario.ConfirmarClave && usuario!=null)
            {

                usuario.Clave = Validaciones.ConvertirSha256(usuario.Clave);
            }
            else
            {
                ViewData["Mensaje"] = "Las contraseñas no coinciden";
                return View();
            }

            bool existeEmail = usuarioBusiness.ConsultarUsuarioPorEmail(usuario.Correo).Result;

            if (existeEmail)
            {
                ViewData["Mensaje"] = "Correo ya exise";
            }
            bool suecces = usuarioBusiness.Guardar(usuario).IsSuccess;
            if (suecces)
            {
                return RedirectToAction("Login", "Acceso");
            }
            else
            {

                return View();
            }

        }

        [HttpPost]
        public ActionResult Login(UsuarioDto usuario)
        {
            if (usuario == null)
            {
                ViewData["Mensaje"] = "Los campos son obligatorio";
                return View();
            }
            usuario.Clave = Validaciones.ConvertirSha256(usuario.Clave);
            bool Validar= usuarioBusiness.ValidaLogin(usuario).Result;
       

            if (Validar)
            {
               
                FormsAuthentication.SetAuthCookie(usuario.Correo,false);
                Session["usuario"] = usuario;
                return RedirectToAction("Index", "Pronostico");
            }
            else
            {
                ViewData["Mensaje"] = "usuario no encontrado";
                return View();
            }


        }
       
        public ActionResult CerrarSesion()
        {
            FormsAuthentication.SignOut();
            Session["usuario"] = null;
            return RedirectToAction("Login", "Acceso");
        }

    }
}