using EtecVeiculos.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace EtecVeiculos.Api.Data;
public class AppDbSeed
{
    public AppDbSeed()
    {
    }

    public AppDbSeed(ModelBuilder modelBuilder)
    {
        #region TipoVeiculo
        List<TipoVeiculo> tipoVeiculos = [
            new(){
                Id = 1,
                Name = "Moto"
            },
            new(){
                Id = 1,
                Name = "Moto"
            },
            new(){
                Id = 1,
                Name = "Moto"
            }
        ];
        modelBuilder.Entity<TipoVeiculo>().HasData(tipoVeiculos);
        #endregion
    }
}