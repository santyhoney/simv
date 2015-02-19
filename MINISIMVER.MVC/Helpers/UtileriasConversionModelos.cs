using MINISIMVER.Modelos;
using MINISIMVER.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MINISIMVER.MVC
{
    public static class UtileriasConversionModelos
    {


        internal static EntidadFederativa ConvertirEntidadVMAEntidadBD(EntidadFederativaModeloCliente entidadVM)
        {

            EntidadFederativa entidad = new EntidadFederativa();
            entidad.Id = entidadVM.Id;
            entidad.Nombre = entidadVM.Nombre;
            entidad.Clave = entidadVM.Clave;

            return entidad;

        }
    }

    

}