const string RESPOSTA_SIM = "SIM";
const string RESPOSTA_NAO = "NÃO";

string EstaSeMovendo = "";
string Deveria = "";

Console.WriteLine("Está se movendo?");
EstaSeMovendo = Console.ReadLine()!.ToUpper();

Console.WriteLine("Deveria?");
Deveria = Console.ReadLine()!.ToUpper();

bool ehWD = EstaSeMovendo == RESPOSTA_NAO && Deveria == RESPOSTA_SIM;
bool ehSilverTape = EstaSeMovendo == RESPOSTA_SIM && Deveria == RESPOSTA_NAO;

if (ehWD){
    Console.WriteLine("USE WD-40");
}else if(ehSilverTape){
    Console.WriteLine("USE SILVER TAPE");
}else{
    Console.WriteLine("ÓTIMO");
}