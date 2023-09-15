﻿namespace apiSuperMkD.Models
{
    public class modSuperMkD
    {
        #region Constructor
        public modSuperMkD()
        {
            tipoClasif = 0;
            subTotal = 0;
            porcDscto = 0;
            vrDscto = 0;
            vrAPagar = 0;
            Error = string.Empty;
        }
        #endregion
        #region Atributos/Propiedades
        public int tipoClasif { get; set; }
        public float subTotal { get; set; }
        public float porcDscto { get; set; }
        public float vrDscto { get; set; }
        public float vrAPagar { get; set; }
        public string Error { get; set; }
        #endregion
    }
}