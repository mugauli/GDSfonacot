using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDSfonacotDatos.Utilities
{
    public class Util
    {
        /// <summary>
        /// MethodResponse type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class MethodResponse<T>
        {
            /// <summary>
            /// Code 0: Happy path
            /// Code -100: Error en capa de datos.
            /// </summary>
            public int Code { get; set; }

            /// <summary>
            /// Contiene la descripcion del error obtenido en la exeption
            /// </summary>
            public string Message { get; set; }

            /// <summary>
            /// Contiene la información devuelta por el metodo, este es un tipo de dato dinamico
            /// </summary>
            public T Result { get; set; }
        }
    }
}
