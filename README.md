# CP1 — Modelo Entidade-Relacionamento (MER) e Projeto WebAPI

## Integrantes
- Nome Vinicius Lira Ruggeri - RM: 560593

## Domínio
**Fórmula 1**

## Entidades Modeladas
1. **Equipe**  
   - `EquipeId` (PK, int)  
   - `Nome` (varchar, obrigatório)  
   - `Pais` (varchar, obrigatório)  
   - `AnoFundacao` (int, opcional)  

2. **Piloto**  
   - `PilotoId` (PK, int)  
   - `Nome` (varchar, obrigatório)  
   - `Nacionalidade` (varchar, obrigatório)  
   - `DataNascimento` (date, opcional)  
   - `EquipeId` (FK, obrigatório)  

3. **Corrida**  
   - `CorridaId` (PK, int)  
   - `Nome` (varchar, obrigatório)  
   - `Local` (varchar, obrigatório)  
   - `Data` (date, obrigatório)  

4. **Resultado**  
   - `ResultadoId` (PK, int)  
   - `PilotoId` (FK, obrigatório)  
   - `CorridaId` (FK, obrigatório)  
   - `Posicao` (int, obrigatório)  
   - `Pontos` (int, obrigatório)  

## Resumo dos Relacionamentos
- **Equipe 1:N Piloto** → uma equipe possui vários pilotos; cada piloto pertence a uma equipe (obrigatório).  
- **Piloto N:N Corrida** (via **Resultado**) → um piloto participa de várias corridas; cada corrida tem vários pilotos.  
- **Resultado** → guarda a posição e pontos do piloto em uma corrida específica.  

## Estrutura do Projeto
```

/docs/mer.png
/src/f1.api
/Entities
Corrida.cs
Equipe.cs
Piloto.cs
Resultado.cs
Program.cs
f1.api.csproj
f1.api.sln
README.md
.gitignore

```
