Feature: 12_Validar_Fluxo_Renovacao

#Fluxo de renovação 

@01_ConsultarInstanciaCamunda
Scenario: 01 Consultar instancia no Camunda e iniciar renovação
Given Consulto se há intancia do cpf "37793090845" no camunda
#When Inicio o processo de renovacao do cpf "37793090845"
#Then Instancia deve ser inicializada com sucesso
