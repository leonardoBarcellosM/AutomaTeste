Feature: 13_Validar_Analise_De_Credito

@01_AcessarPagina
Scenario: 01 Acessar o endereco
#Given Acessar o endereco "http://testes.fundacred.org.br/estudante-web/#/"	
Given Acessar o endereco "http://homologacao.fundacred.org.br/estudante-web/#/"	
Then Validar o carregamento

@02_1Etapa
Scenario: 02 Iniciar Fluxo Comece Agora
Given Preencher os dados
When Clicar em Comece agora sem compromisso
Then Validar se o fluxo e iniciado

@02_1Etapa
Scenario: 03 Iniciar Solicitacao
Given Acessar a opcao solicitacao
When Clicar em quero solicitar o credito
Then Validar o direcionamento com sucesso

@02_1Etapa
Scenario: 04 Selecionar Instituicao
Given Selecionar instituicao "CENTRO UNIVERSITARIO IESB (GRADUACAO)"
When Selecionar curso "CIENCIA DA COMPUTACAO-MATUTINO-EDSON MACHADO (SUL)"
And Clicar no botao aceito os termos
Then Validar solicitacao enviada

#Dados editáveis
@02_2Etapa
Scenario: 05 Preencher Dados Do Estudante
#Given Inserir o numero de integrantes da familia " 2 "
#When Inserir a renda bruta mensal " 4.000,00 "
Given Clicar no botao enviar
Then Validar direcionamento para etapa 3

@02_1Etapa
Scenario: 06 Validar DB
Then Validar status de solicitacao no db "Estudante"

#Dados editáveis
@03_3Etapa
Scenario: 07 Preencher Dados Do Fiador
Given Inserir nome e cpf " Leonardo Barcellos Teste "
When Inserir data de nasc e renda "1.400,00-06/08/2000"
And Clicar no botao enviar etapa 3
Then Validar direcionamento para etapa 4

@04_ConsultarInstanciaCamunda
Scenario: 08 Consultar instancia no Camunda e iniciar renovação
Given Consulto a etapa no camunda
#When Inicio o processo de renovacao do cpf "37793090845"
#Then Instancia deve ser inicializada com sucesso