const string RESPOSTA_SIM = "SIM";

string EstaSeMovendo = "";
string Deveria = "";

Console.WriteLine("Está se movendo?");
EstaSeMovendo = Console.ReadLine()!.ToUpper();

Console.WriteLine("Deveria?");
Deveria = Console.ReadLine()!.ToUpper();
if (EstaSeMovendo == RESPOSTA_SIM){
    if (Deveria == RESPOSTA_SIM){
        Console.WriteLine("ÓTIMO");
    }else{
        Console.WriteLine("USE SILVER TAPE");
    }
}else{
    if (Deveria == RESPOSTA_SIM){
        Console.WriteLine("USE WD-40");
    }else{
        Console.WriteLine("ÓTIMO");
    }
}