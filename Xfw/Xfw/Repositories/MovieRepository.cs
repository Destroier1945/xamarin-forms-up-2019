﻿using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xfw.Api;
using Xfw.Models;

namespace Xfw.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public readonly IMovieApi movieApi;

        public MovieRepository()
        {
            movieApi = RestService.For<IMovieApi>(AppConstants.API_ENDPOINT);
        }

        public async Task<(string error, List<Movie>)> GetUpcoming()
        {
            try
            {
                var response = await movieApi.GetUpcoming(AppConstants.API_KEY);

                if (response == null)
                    return ("Falha na requisicao, tente novamente", null);

                if (response.Movies?.Count == 0)
                    return ("Nenhum filme encontrado!", null);

                return (null, response.Movies);
            }
            catch (ApiException ex)
            {
                return (ex.Message, null);
            }
        }

        System.Threading.Tasks.Task<(string error, List<Movie>)> IMovieRepository.GetUpcoming()
        {
            throw new NotImplementedException();
        }
    }

}