
//usar carpeta de models.
using apiSuperMkD.Models;

namespace apiSuperMkD.Clases
{
    public class clsOpeMdo
    {
        modSuperMkD objModMdo = new modSuperMkD();
        #region Metodos Privados
        private bool Validar()
        {
            if (objModMdo.tipoClasif != 1 && objModMdo.tipoClasif != 5 && objModMdo.tipoClasif != 10)
            {
                objModMdo.Error = "Tipo de clasificación no valida.";
                return false;
            }
            if (objModMdo.subTotal <= 0)
            {
                objModMdo.Error = "Tipo de valor no valido.";
                return false;
            }
            return true;
        }
        private void hallerDscto()
        {
            switch (objModMdo.tipoClasif)
            {
                case 1:
                    if (objModMdo.subTotal < 1000000)
                    {
                        objModMdo.porcDscto = 8f;
                    }
                    else
                    {
                        objModMdo.porcDscto = 15f;
                    }
                    break;
                case 5:
                    if (objModMdo.subTotal < 1000000)
                    {
                        objModMdo.porcDscto = 5f;
                    }
                    else
                    {
                        objModMdo.porcDscto = 10f;
                    }
                    break;
                default:
                    if (objModMdo.subTotal < 1000000)
                    {
                        objModMdo.porcDscto = 0f;
                    }
                    else
                    {
                        objModMdo.porcDscto = 4f;
                    }
                    break;
            }
            objModMdo.vrDscto = objModMdo.subTotal * objModMdo.porcDscto / 100;
        }
        private void hallarDatos()
        {
            if (Validar())
            {
                hallerDscto();
                objModMdo.vrAPagar = objModMdo.vrAPagar - objModMdo.porcDscto;
            }

        }
        #endregion
    }
}