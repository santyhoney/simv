using MINISIMVER.Datos;
using MINISIMVER.Modelos;
using MINISIMVER.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MINISIMVER.MVC.Controllers
{
    public class EntidadesController : ApiController
    {
        MINISIMVERContexto contexto = new MINISIMVERContexto();

        public IEnumerable<EntidadFederativaModeloCliente> GetObtieneEstados()
        {
            var estados = contexto.Estados.Select(e => new EntidadFederativaModeloCliente
            {
                Id=e.Id,
                Nombre=e.Nombre,
                Clave=e.Clave
            }).ToList();
            return estados;
        }

        public EntidadFederativaModeloCliente GetEntidadFederativa(int id)
        {
            EntidadFederativa entidad = contexto.Estados.Find(id);
            EntidadFederativaModeloCliente entidadVM = null;
            if (entidad != null)
            {
                entidadVM = new EntidadFederativaModeloCliente();
                entidadVM.Id = entidad.Id;
                entidadVM.Nombre = entidad.Nombre;
                entidadVM.Clave = entidad.Clave;
            }
            return entidadVM;
        }

        public void PostGuardarEntidad(EntidadFederativaModeloCliente entidadVM)
        {
            EntidadFederativa entidad = UtileriasConversionModelos.ConvertirEntidadVMAEntidadBD(entidadVM);
            contexto.Estados.Add(entidad);
            contexto.SaveChanges();
        }

        public void PutActualizarEntidad(EntidadFederativaModeloCliente entidadVM)
        {
            EntidadFederativa entidad = UtileriasConversionModelos.ConvertirEntidadVMAEntidadBD(entidadVM);
            //Determinamos el estado de una entidad determinada
            contexto.Entry(entidad).State = EntityState.Modified;            
            contexto.SaveChanges();
        }

        [HttpDelete]        
        public void EliminarEntidad(int Id)
        {
            EntidadFederativa entidad = contexto.Estados.Find(Id);            
            contexto.Estados.Remove(entidad);
            contexto.SaveChanges();
        }






    }
}
