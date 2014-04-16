#language pt-br

Funcionalidade:
	Como um
	Eu quero
	Para que

Cenário: Login válido
	Quando eu utilizar um login e senha válidos
	Então o sistema irá exibir a mensagem de saudação na página inicial

Cenário: Login em branco
	Quando eu não digitar nada
	Então o sistema não irá permitir meu login