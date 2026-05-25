using System.Net.Http.Headers;

Conta conta1 = new Conta();

conta1.titular = "James Bond";
conta1.idConta = 007;
conta1.saldo = 15000.00;
conta1.senha = 123456;

conta1.ExibirFichaTecnica();
