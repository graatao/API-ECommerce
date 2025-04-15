#🛒 API de E-commerce

##Esta API foi desenvolvida com Node.js e Express para simular um sistema de e-commerce semelhante ao Mercado Livre. Ela permite a criação e autenticação de usuários, gerenciamento de anúncios de produtos e processamento de solicitações de compra.

#🚀 Funcionalidades

##1. Criação e Autenticação de Usuário

###POST /users: Cria um novo usuário fornecendo nome, e-mail e senha. A senha é criptografada antes de ser armazenada.

###POST /sessions: Autentica um usuário existente com e-mail e senha, retornando um token JWT para sessões subsequentes.

##2. Gerenciamento de Anúncios de Produtos

###GET /ads: Lista todos os anúncios de produtos cadastrados.

###GET /ads/:id: Exibe os detalhes de um anúncio específico pelo ID.

###POST /ads: Cria um novo anúncio fornecendo título, descrição e preço do produto.

####PUT /ads/:id: Atualiza os dados de um anúncio existente pelo ID.

###DELETE /ads/:id: Remove um anúncio específico pelo ID.​

##3. Solicitação de Compra
###POST /purchases: Envia uma solicitação de compra informando o ID do anúncio e o conteúdo do corpo do e-mail que será enviado ao criador do anúncio.
