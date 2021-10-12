using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorCondominios.DAL
{
    public class RepositorioGenerico<TEntity> : IRepositorioGenerico<TEntity> where TEntity : class
    {
        private readonly Contexto contexto;

        public RepositorioGenerico(Contexto contexto)
        {
            this.contexto = contexto;
        }

        public async Task Atualizar(TEntity entity)
        {
            try
            {
                this.contexto.Set<TEntity>().Update(entity);
                await this.contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<TEntity> ConsultarPorId(int id)
        {
            try
            {
                return await this.contexto.Set<TEntity>().FindAsync(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public  async Task<TEntity> ConsultarPorId(string id)
        {
            try
            {
                return await this.contexto.Set<TEntity>().FindAsync(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Excluir(TEntity entity)
        {
            try
            {
                this.contexto.Set<TEntity>().Remove(entity);
                await this.contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Excluir(int id)
        {
            try
            {
                var entity = await ConsultarPorId(id);
                this.contexto.Set<TEntity>().Remove(entity);
                await this.contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Excluir(string id)
        {
            try
            {
                var entity = await ConsultarPorId(id);
                this.contexto.Set<TEntity>().Remove(entity);
                await this.contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Inserir(TEntity entity)
        {
            try
            {
                await this.contexto.AddAsync(entity);
                await this.contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<TEntity>> Listar()
        {
            try
            {
                return await this.contexto.Set<TEntity>().ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
