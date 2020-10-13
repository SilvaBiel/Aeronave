using System;


class Aeronave{
  string NomeAeronave, NomePiloto, AeroportoAtual;
  int CapacidadeTanqueCombustivel, NivelCombustivelAtual, QtdPassageiros, AutonomiaAeronave, VelocidadeAeronave;
  double HorasDeVoo, Acesso;
  Acesso = 123

  public int AbastecerAeronave(){
    double QtdAbastecido;
    if (NivelCombustivelAtual < CapacidadeTanqueCombustivel){
      QtdAbastecido = CapacidadeTanqueCombustivel-NivelCombustivelAtual
      NivelCombustivelAtual = NivelCombustivelAtual + QtdAbastecido;
    }
    return QtdAbastecido;
  }
  private int Voar(int distancia){
    if (distancia <= AutonomiaAeronave){
      HorasDeVoo = HorasDeVoo + (distancia/VelocidadeAeronave);
    }
  return HorasDeVoo;
  }
  //SET
  public void SetNomePiloto(string n, double senha){
     //RN RESTRITIVA - ACESSO
    if (senha == Acesso) {
       NomePiloto = n;
    }  
    else{
      Console.WriteLine("Acesso Negado");
    }
  }

   public void SetNomeAeroporto(string m, double senha){
     //RN RESTRITIVA - ACESSO
    if (senha == Acesso) {
       AeroportoAtual = m;
    }  
    else{
      Console.WriteLine("Acesso Negado");
    }
  }

  //GET
  public string GetNomePiloto(){
       return NomePiloto;
  }
  public string GetAeroportoAtual(){
       return AeroportoAtual;
  }
  }