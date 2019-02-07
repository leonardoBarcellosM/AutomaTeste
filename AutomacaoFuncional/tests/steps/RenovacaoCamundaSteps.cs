using AutomacaoFuncional.tests.pages;
using AutomacaoFuncional.tests.utils;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomacaoFuncional.tests.steps
{
    [Binding]
    public class RenovacaoCamundaSteps
    {
        CamundaApiActions pageAction = new CamundaApiActions();

        [Given(@"Consulto se há intancia do cpf ""(.*)"" no camunda")]
        public void GivenConsultoInstanciaNoCamunda(string Cpf)
        {
            bool result = pageAction.ConsultarInstancia(Cpf);

            Assert.That(result, Is.True, "Erro ao consultar ou cancelar instancia no Camunda!");
        }

        [When(@"Preencho contato e endereco")]
        public void WhenPreenchoContatoEEndereco()
        {
            //bool result = pageAction.PreencherContatoEndereco();

            //Assert.That(result, Is.True, "Erro ao preencher os dados!");
        }


        [Then(@"Validar direcionamento Dados Curso")]
        public void ThenDirecionamentoDadosCurso()
        {
            //var result = pageAction.ValidarDirecionamentoDadosCurso();

            //Assert.That(result, Is.True, "Erro durante o direcionamento para a tela de Dados do Curso/ Erro preenchimento de dados do fiador!");
        }
    }
}
