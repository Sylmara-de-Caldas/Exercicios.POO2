### Resolução dos exercícios do curso de Programação Orientadada à Objetos II - Ministrado pela ADA

Ex 1 - 
        Escreva um programa orientado a objetos com as seguintes características:

        Uma classe Pessoa, com atributos nome e idade, e métodos Cumprimentar e DizerIdade; Uma classe Aluno derivada da classe Pessoa, 
        com um método IrParaEscola; Uma classe Professor derivada da classe Pessoa, com um método Explicar que recebe como parâmetro um assunto;
        
        Na classe principal:
        1. Crie uma Pessoa e faça ela Cumprimentar e DizerIdade;
        2. Crie um Aluno de 21 anos, e faça ele IrParaEscola, Cumprimentar e DizerIdade;
        3. Crie um Professor de 30 anos, e faça ele Cumprimentar, DizerIdade e Explicar sobre um determinado assunto.
        
 Ex 2 - 
        Realize a implementação utilizando classe abstrata.

        Vide Diagrama no repositório do módulo
        
        Repositório.
        
Ex 3 - 
        Dadas as classes base no diagrama abaixo, criar as classes para os seguintes animais: leão, chacal, morcego, cisne, arara, dragão de comodo, lontra, pinguim,             coruja, elefante e jacaré. Deve estar adequado também o cadastro de um ornitorrinco.

        Lembre-se de verificar as características de cada animal, por exemplo, um réptil que seja aquático E terrestre, etc.

        Diagrama Animais.

Ex 4 - 
        Crie uma aplicação Console que contenha uma cópia da classe abaixo.

        Classe Student.
        
        1. Em seguida, na classe Program, crie um método chamado DisplayPublicProperties que, usando Reflection, exiba todas as Propriedades Públicas da classe Student. No método Main da classe Program, coloque uma chamada para o método DisplayPublicProperties.
        2. Agora, adicione na classe Program um outro método chamado CreateInstance que
        Use Reflection para criar uma instância (objeto) da classe Student e, em seguida;
        Use Reflection para preencher as propriedades públicas do objeto. Não é necessário se preocupar com a adição de novas propriedades, isto é, sempre serão preenchidos apenas o Name, University e RollNumber.
        3. Use Reflection para chamar o método DisplayInfo do objeto criado no item 2.1.
