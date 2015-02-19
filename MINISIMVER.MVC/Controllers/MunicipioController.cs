using MINISIMVER.Datos;
using MINISIMVER.Modelos;
using MINISIMVER.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MINISIMVER.MVC.Controllers
{
    public class MunicipioController : ApiController
    {

        MINISIMVERContexto contexto = new MINISIMVERContexto();
        public IEnumerable<MunicipioModeloCliente> GetMunicipios()
        {
            return contexto.Municipios.Select(u => new MunicipioModeloCliente
            {
                Id = u.Id,
                Nombre = u.Nombre,
                ClaveInegi = u.ClaveINEGI,
                ClaveOrfis = u.ClaveORFIS,
                EntidadFederativaId = u.EntidadFederativaId
            }).ToList();
        }

        public MunicipioModeloCliente GetMunicipio(int id)
        {
            var municipio = contexto.Municipios
                .Where(u=>u.Id==id)
                .Select(u=>new MunicipioModeloCliente{
                          Id=u.Id,
                          ClaveInegi=u.ClaveINEGI,
                          ClaveOrfis=u.ClaveORFIS,
                          EntidadFederativaId=u.EntidadFederativaId,
                          Nombre=u.Nombre
                        }).FirstOrDefault();
            return municipio;            
            
        }
        
        
        public void PostMunicipio(Municipio municipio)
        {
            contexto.Municipios.Add(municipio);
            contexto.SaveChanges();
        }



    }
}

