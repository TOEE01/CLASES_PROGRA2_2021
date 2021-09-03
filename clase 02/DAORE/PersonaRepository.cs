using clase_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace clase_02.DAORE
{
    public class PersonaRepository
    {

        public List<ClsPersona> ObtenerPersona()
        {
            return new List<ClsPersona>()
            {
                new ClsPersona()
                {
                    Id =1,
                    Nombre="Roberto"
                   
                },
                new ClsPersona()
                {
                    Id=2,
                    Nombre = "Fanny"
                },
                new ClsPersona()
                {
                    Id=3,
                    Nombre = "Sol"
                }
            };
        }

    }
}