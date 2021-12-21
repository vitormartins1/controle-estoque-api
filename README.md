# Sistema de Gerenciamento de Estoque, Fornecedores e Revendedores

## Estoque

O estoque é dividido em lotes que tem uma data de inicio quando são criados referente a chegada dos produtos na loja. O lote também armazena a quantidade de cada produto que chegou.

Organizar em lotes ajuda a ter um controle da duração dos produtos e controle de entrada e saida.

## Entradas no estoque
  - Compras => De Fornecedores ou da fabrica
  - Vendas => Que Retornaram (Devoluções, CEP Inexistene, Destinatário não Encontrado)

## Saidas do estoque
  - Vendas => Para Clientes do Site
  - Vendas => Para Clientes do WP
  - Vendas => Para Clientes Avulsos
  - Vendas => Para Revendedores
  - Consignado => Para Revendedores (Status: Pendente, Pago, Quantidade Pendente e Quantidade Paga em quantidade de produtos.
  - Danificados => Produtos danificados no estoque ou durante o transporte ou que passaram da validade
 
## Usuarios
  - Administrador (Acesso de criação de compras)
  - Funcionario

## Modelos
  - Venda
  - ItemVenda
  - Produto
  - Cliente
  - Revendedor
  - Consignado
  - ItemConsignado
  - Danificado
  - ItemDanificado
  - Compra
  - ItemCompra
  - Fornecedor
  - Estoque
  - Lote
  
- Cadastro de produto
- Cadastro de fornecedores
- Cadastro de Clientes
- Cadastro de Distribuidor
- Controle de pagamento ao entregador
- Controle de Estoque
- Aviso de Estoque baixo
- Baixa automatica de estoque
- Estoque Mínimo
- Acesso ao estoque via WEB
- Acesso ao estoque via MOBILE (PWA)
- Acesso a nivel de usuario
- Sistema de saida de produto e forma de pagamento
- Controle de contas Pagar/Receber
- Aviso de vencimento de Contas
- Relatórios diversos
- O sistema podera cadastrar e gerenciar multiplas empresas
