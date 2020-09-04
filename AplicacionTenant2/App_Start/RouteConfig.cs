using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using AplicacionTenant2.Models;
using AplicacionTenant2.Models.App_data;
using AplicacionTenant2.Models.Contantes;

namespace AplicacionTenant2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");



            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                constraints :new {TenantConstraint = new TenantConstraint()}
               
            ) ;  

        }

    }
        public class TenantConstraint : IRouteConstraint
        {
            public bool Match( HttpContextBase httpContext,Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirecti)
            {
            
          var GetAndress = httpContext.Request.Headers["Host"].Split('.');
            string cadena = GetAndress[0];
       
                using (Context Contexto = new Context())
                {

                    var innerjoi = (from te in Contexto.tenant
                                    join In in Contexto.databaseInstancia on te.id equals In.tenantId
                                    select new
                                    {

                                        SubDomain = te.subdomain,
                                        Domain = te.domain,
                                        DataBaseName = In.databaseName,
                                        TipoBaseDatos = In.databaseType,
                                        User = In.databaseUser,
                                        Password = In.databasePassword
                                    }).Where(e => e.SubDomain == cadena).ToList();


                    foreach (var item in innerjoi)
                    {
                        if (item.TipoBaseDatos == 1)
                        {
                            Constant.database = item.DataBaseName;
                            Constant.password = item.Password;
                            Constant.user = item.User;
                        }
                        else if (item.TipoBaseDatos == 2)
                        {
                            Constant.databaseSecondary = item.DataBaseName;

                        }
                        else if (item.TipoBaseDatos == 3)
                        {
                            Constant.databaseAuxiliar = item.DataBaseName;

                        }

                     }



                }



                
           


            return true;
            }


        }
    }


