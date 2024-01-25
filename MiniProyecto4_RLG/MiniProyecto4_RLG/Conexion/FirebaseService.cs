using Firebase.Database;
using Firebase.Database.Query;
using MiniProyecto4_RLG.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProyecto4_RLG.Conexion
{
    public class FirebaseService
    {
        private FirebaseClient _firebase;

        public FirebaseService(string apiKey, string databaseUrl)
        {
            _firebase = new FirebaseClient(databaseUrl, new FirebaseOptions { AuthTokenAsyncFactory = () => Task.FromResult(apiKey) });
        }

        public async Task<List<Mgastos>> ObtenerGastosAsync()
        {
            var gastos = await _firebase.Child("gastos").OnceAsync<Mgastos>();
            return gastos.Select(item => new Mgastos
            {
                Id = item.Key,
                Descripcion = item.Object.Descripcion,
                Monto = item.Object.Monto,
                Fecha = item.Object.Fecha
            }).ToList();
        }

        public async Task AgregarGastoAsync(Mgastos gasto)
        {
            await _firebase.Child("gastos").PostAsync(gasto);
        }
    }
}
