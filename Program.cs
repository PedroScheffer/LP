// Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor.

int idade = 35;
Console.WriteLine($"A idade é {idade} anos.");

// Crie uma variável chamada nome e atribua o valor "Maria" e exiba o seu valor.

string nome = "Maria";
Console.WriteLine($"Meu nome é {nome}.");

// Crie uma variável chamada altura e atribua a ela o valor 3.45.

double altura = 3.45;
Console.WriteLine($"A altura é de: {altura} metros.");

// Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor

int ano = 12;
Console.WriteLine($"Ela tem {ano} anos.");

// Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o valor 7.80 e exiba o seu valor

double? nota = 7.80;
Console.WriteLine($"Sua nota é {nota}.");

// Quais as diferenças entre os tipos por valor e os tipos por referência ?

// As variáveis de tipos por valor contêm diretamente seus dados, enquanto as variáveis de tipos por referência armazenam referências aos seus dados.

// O que é um nullable type e qual a sua utilidade?

// Um tipo nullable em C# representa todos os valores do tipo de valor subjacente e um valor null adicional. Isso é útil quando você precisa representar o valor 
// indefinido de um tipo de valor subjacente.

//O que é Camel Case ? Dê um exemplo de sua aplicação.

// Camel Case é uma convenção de nomenclatura em que a primeira letra de cada palavra em uma frase começa com uma letra maiúscula, exceto a primeira palavra. 
// ex: meuExemplo

// Pascal Case é uma convenção de nomenclatura em que a primeira letra de cada palavra em uma frase começa com uma letra maiúscula. ex: MeuExemplo

//Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e aseguir imprima o valor da soma de x com y. 
// (Use o operador aritmético + para realizar a operação de soma)

int x = 77;
int y = 66;
int soma = x + y;
Console.WriteLine($"A Soma de x + y é {soma}.");

//Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e string.

// bool: false
// char: \0
// int: 0
// double: 0.0D
// float: 0.0F
// decimal: 0.0M
// string: null