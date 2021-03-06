﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AutomacaoFuncional.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("13_Validar_Analise_De_Credito")]
    public partial class _13_Validar_Analise_De_CreditoFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "13_Validar_Analise_De_Credito.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "13_Validar_Analise_De_Credito", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("01 Acessar o endereco")]
        [NUnit.Framework.CategoryAttribute("01_AcessarPagina")]
        public virtual void _01AcessarOEndereco()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("01 Acessar o endereco", null, new string[] {
                        "01_AcessarPagina"});
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
testRunner.Given("Acessar o endereco \"http://homologacao.fundacred.org.br/estudante-web/#/\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
testRunner.Then("Validar o carregamento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("02 Iniciar Fluxo Comece Agora")]
        [NUnit.Framework.CategoryAttribute("02_1Etapa")]
        public virtual void _02IniciarFluxoComeceAgora()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("02 Iniciar Fluxo Comece Agora", null, new string[] {
                        "02_1Etapa"});
#line 10
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 11
testRunner.Given("Preencher os dados", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 12
testRunner.When("Clicar em Comece agora sem compromisso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
testRunner.Then("Validar se o fluxo e iniciado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("03 Iniciar Solicitacao")]
        [NUnit.Framework.CategoryAttribute("02_1Etapa")]
        public virtual void _03IniciarSolicitacao()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("03 Iniciar Solicitacao", null, new string[] {
                        "02_1Etapa"});
#line 16
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 17
testRunner.Given("Acessar a opcao solicitacao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 18
testRunner.When("Clicar em quero solicitar o credito", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
testRunner.Then("Validar o direcionamento com sucesso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("04 Selecionar Instituicao")]
        [NUnit.Framework.CategoryAttribute("02_1Etapa")]
        public virtual void _04SelecionarInstituicao()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("04 Selecionar Instituicao", null, new string[] {
                        "02_1Etapa"});
#line 22
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 23
testRunner.Given("Selecionar instituicao \"CENTRO UNIVERSITARIO IESB (GRADUACAO)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 24
testRunner.When("Selecionar curso \"CIENCIA DA COMPUTACAO-MATUTINO-EDSON MACHADO (SUL)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
testRunner.And("Clicar no botao aceito os termos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
testRunner.Then("Validar solicitacao enviada", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("05 Preencher Dados Do Estudante")]
        [NUnit.Framework.CategoryAttribute("02_2Etapa")]
        public virtual void _05PreencherDadosDoEstudante()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("05 Preencher Dados Do Estudante", null, new string[] {
                        "02_2Etapa"});
#line 30
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 33
testRunner.Given("Clicar no botao enviar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 34
testRunner.Then("Validar direcionamento para etapa 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("06 Validar DB")]
        [NUnit.Framework.CategoryAttribute("02_1Etapa")]
        public virtual void _06ValidarDB()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("06 Validar DB", null, new string[] {
                        "02_1Etapa"});
#line 37
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 38
testRunner.Then("Validar status de solicitacao no db \"Estudante\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("07 Preencher Dados Do Fiador")]
        [NUnit.Framework.CategoryAttribute("03_3Etapa")]
        public virtual void _07PreencherDadosDoFiador()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("07 Preencher Dados Do Fiador", null, new string[] {
                        "03_3Etapa"});
#line 42
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 43
testRunner.Given("Inserir nome e cpf \" Leonardo Barcellos Teste \"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 44
testRunner.When("Inserir data de nasc e renda \"1.400,00-06/08/2000\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
testRunner.And("Clicar no botao enviar etapa 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
testRunner.Then("Validar direcionamento para etapa 4", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("08 Consultar instancia no Camunda e iniciar renovação")]
        [NUnit.Framework.CategoryAttribute("04_ConsultarInstanciaCamunda")]
        public virtual void _08ConsultarInstanciaNoCamundaEIniciarRenovacao()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("08 Consultar instancia no Camunda e iniciar renovação", null, new string[] {
                        "04_ConsultarInstanciaCamunda"});
#line 49
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 50
testRunner.Given("Consulto a etapa no camunda", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
