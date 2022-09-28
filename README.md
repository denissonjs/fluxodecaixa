# Descriçaõ do Projeto
Nada de surpresa financeiras desagradáveis por aqui. Fluxo de caixa concluído! Com o objetivo de gerenciar a movimentação financeira de uma empresa, temos nesse projeto quatro tabelinhas intuitivas para o acompanhamento de despesas e receitas assim como saldos bancários e detalhes da despesa/receita que for clicada pelo usuário. Além de trazer uma visão completa desses dados, na parte inferior esquerda teremos um completíssimo resumo do estado financeiro atual da corporação. E por que ver o estado financeiro da empresa em um dia específico quando se pode ver do dia em questão e dos quatro dias posteriores? Como podem ver, nosso projeto também proporciona isso.

Apesar de fácil entendimento, não foi fácil a construção! Esse projeto foi desenvolvido com ajuda do Windows Forms do Visual Studio, com a linguagem C#. De início, foram necessários dois datagridviews que fazem consulta direta ao banco de dados, que nesse projeto foi o MySQL, trazendo as receitas e despesas obtidas pela empresa nos dias filtrados pelo usuário, dando a possibilidades de dados clicáveis para trazer detalhes, que mais à frente irei explicar a dinâmica. Já nos “Saldos Bancários”, além de um datagridview trazendo a consulta de saldos inseridos anteriormente, temos um botão de gravação, que irá gravar na tabela de saldos, no banco de dados, os saldos inseridos pelo usuário, dando a possibilidade de verificar divergências entre saldos que realmente estão nas contas com os dados do fluxo. Por fim o datagridview com mais funções atribuídas a ele (11 para ser bem exato), pois nele temos consultas de banco de dados mais completas, além de permitir filtrar dados e exportar para Excel os dados que o usuário selecionar (opções do contextMenuStrip). Quando o usuário clicar, por exemplo, na linha de clientes, dia 28 do datagridview de entrada ele irá filtrar quais foram as entradas por cliente do dia selecionado. Quando o usuário clicar no botão/link 'contas a receber vencidos', o datagridview assumirá a consulta detalhada da origem dessas contas a receber vencidas, assim, o departamento de cobranças poderá entrar em ação para negociar o pagamento com os clientes, antes que o saldo da empresa venha a ficar negativo. Já quando o usuário clica em 'filtrar caixas' no resumo de tesourarias, o datagridview abre uma nova consulta ao banco de dados trazendo as tesourarias e seus saldos junto a um combo-box em cada linha, onde ao ser marcado, um filtro será assumido e o usuário poderá visualizar somente totais dos das tesourarias marcadas, deixando de fora saldo que por qualquer motivo que seja, não precisariam ser contabilizados naquele momento. 

# Tabelas no Banco de Dados
- Tabela de Receitas com as colunas: Origem da Receita, Valor da Receita, Data da Receita.
- Tabela de Despesas com as colunas: Origem da Despesa, Valor da Despesa, Data da Despesa.
- Tabela de Saldos com as colunas: Banco, Saldo do banco.

## DatagridView de detalhes
- Tabela de clientes: Nome cliente, valor pago, data de pagamento.
- Tabela de Receitas com Fornecedores: Fornecedor, valor pago, data de pagamento.
- Tabela de Despesas com Fornecedores: Fornecedor, valor pago, data de pagamento.
- Tabela de Investimentos: Investimento, Valor, data do resgate.
- Tabela Despesa Imobiliária (Agua, Luz, Aluguel): Origem, Valor, Data
- Tabela Despesa com Veiculos (IPVA, Multas, MAnutenção): Origem, Valor, Data
- Tabela Folha de Pagamento: Funcionário, Valor, Data
- Tabela de percas: Origem, Valor, Data

# Notas
- As tabelas descritas acima foram criadas somente para aplicação de teste para esse projeto. Tal projeto quando implementado à uma empresa real, que certamente haverá uma base de dados maior, terá o grau de complexidade no manuseio desses dados aumentado, visto que mais tabelas são utilizada, a exemplo, o ERP Winthor, que utiliza a tabela de contas contábeis, grupo de contas e de lançamento de recebimento por tipo. Sendo asim para ter o resultado que temos no projeto atual, seria necessário relacionar tabelas como: "PCCONTA" , "PCGRUPO", "PCFORNEC", "PCLANC" dentre algumas outras. Ou ainda as tabelas: "PCPREST", "PCCOB", "PCCLIENT", "PCUSUARI", "PCSUPERV", "PCPRACA" para se obter o resultado do clique em "Detalhes de contas vencidas".
- Esse aplicativo foi desenvolvido originalmente com banco de Dados Oracle.
- Esse aplicativo foi implementado ao ERP winthor, acessivél junto as demais aplicações pelo gerenciador de rotinas.
