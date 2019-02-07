using AutomacaoFuncional.tests.utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System.Windows.Forms;

namespace AutomacaoFuncional.tests.pages
{
    class CamundaApiActions
    {
        public bool ConsultarInstancia(string Cpf)
        {
            bool _result = false;
            string Instancia = "";
            string Validar = "";

            try
            {
               Instancia =  CamundaApi.GetInstance(Cpf);
                if (string.IsNullOrEmpty(Cpf))
                {
                    _result = true;
                }
                else
                {
                  Validar = CamundaApi.DeleteInstance(Instancia);
                    //if (string.IsNullOrEmpty(Validar))
                    //{
                    //    _result = true;
                    //}
                    _result = true;
                } 
            }
            catch
            {

            }

            return _result;
        }

    }
}
