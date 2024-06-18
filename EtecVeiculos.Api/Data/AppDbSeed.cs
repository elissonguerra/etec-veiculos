using EtecVeiculos.Api.Models;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace EtecVeiculos.Api.Data;
public class AppDbSeed
{
    public AppDbSeed(ModelBuilder modelBuilder)
    {
        #region TipoVeiculo
        List<TipoVeiculo> tipoVeiculos = [
            new(){
                Id = 1,
                Name = "Moto"
            },
            new(){
                Id = 2,
                Name = "Carro"
            },
            new(){
                Id = 3,
                Name = "Caminhão"
            }
        ];
        modelBuilder.Entity<TipoVeiculo>().HasData(tipoVeiculos);
        #endregion

        #region Marcas
        List<Marca> marca = [
            new(){
                Id = 1,
                Nome = "Fiat"
            },
            new(){
                Id = 2,
                Nome = "Chevrolet"
            },
            new(){
                Id = 3,
                Nome = "Ford"
            }
        ];
        #endregion

        #region Modelo
        List<Modelo> modelos = new() {
            new() {
                Id = 1,
                Nome = "Uno",
                MarcaId = 1 
            },
            new() {
                Id = 2,
                Nome = "Pálio",
                MarcaId = 1 
            },
            new() {
                Id = 3,
                Nome = "Celta",
                MarcaId = 2 
            },
            new() {
                Id = 4,
                Nome = "Strada",
                MarcaId = 2 
            },
            new() {
                Id = 5,
                Nome = "Fiesta",
                MarcaId = 3 
            },
            new() {
                Id = 6,
                Nome = "Ká",
                MarcaId = 3 
            }
        };
        modelBuilder.Entity<Modelo>().HasData(modelos);
        #endregion
    }
}