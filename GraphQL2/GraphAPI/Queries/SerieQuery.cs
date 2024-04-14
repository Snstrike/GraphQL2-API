using GraphAPI.Models;

namespace GraphAPI.Queries
{
    public class SerieQuery()
    {
        public Serie GetSerie()
        {
            return new Serie
            {
                Name = "One Piece",
                ReleaseDate = DateTime.UtcNow.AddDays(-10),

                Platforms = new List<Platform>
                {
                    new(){
                        Name = "Crunchy Roll",
                        Followers = 1000
                    },
                    new(){
                        Name = "Netflix",
                        Followers = 2000
                    }
                }
            };
        }

        public List<Serie> GetSeries()
        {
            return new List<Serie>()
            {
                new Serie
            {
                Name = "Modern Family",
                ReleaseDate = DateTime.UtcNow.AddDays(-10),

                Platforms = new List<Platform>
                {
                    new(){
                        Name = "Amazon Prime Video",
                        Followers = 1200
                    },
                    new(){
                        Name = "Netflix",
                        Followers = 2000
                    }
                }
            },
             new Serie
            {
                Name = "The Office",
                ReleaseDate = DateTime.UtcNow.AddDays(-10),

                Platforms = new List<Platform>
                {
                    new(){
                        Name = "Amazon Prime Video",
                        Followers = 1200
                    },
                    new(){
                        Name = "Netflix",
                        Followers = 2000
                    }
                }
            }
            };
        }
        public Serie GetSerieById(int id)
        {
            var series = new List<Serie>()
            {
                new Serie
            {
                Name = "One Piece",
                ReleaseDate = DateTime.UtcNow.AddDays(-10),

                Platforms = new List<Platform>
                {
                    new(){
                        Name = "Crunchy Roll",
                        Followers = 1000
                    },
                    new(){
                        Name = "Netflix",
                        Followers = 2000
                    }
                }
            },
                new Serie
            {
                Name = "Modern Family",
                ReleaseDate = DateTime.UtcNow.AddDays(-10),

                Platforms = new List<Platform>
                {
                    new(){
                        Name = "Amazon Prime Video",
                        Followers = 1200
                    },
                    new(){
                        Name = "Netflix",
                        Followers = 2000
                    }
                }
            },
             new Serie
            {
                Name = "The Office",
                ReleaseDate = DateTime.UtcNow.AddDays(-10),

                Platforms = new List<Platform>
                {
                    new(){
                        Name = "Amazon Prime Video",
                        Followers = 1200
                    },
                    new(){
                        Name = "Netflix",
                        Followers = 2000
                    }
                }
            }
            };
            return series[id];
        }
    }
}