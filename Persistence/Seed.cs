using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedCamp(DataContext context)
        {
            if (context.Camps.Any()) return;
            var camps = new List<Camp>
            {
                new Camp
                {
                    Name="好人",
                    Description="Civilian",
                },
                new Camp
                {
                    Name="狼人",
                    Description="Werewolf",
                },
                new Camp
                {
                    Name="第三方",
                    Description="Third Party",
                }
            };
            await context.Camps.AddRangeAsync(camps);

            await context.SaveChangesAsync();
        }

        public static async Task SeedPlayer(DataContext context)
        {
            if (context.Players.Any()) return;
            var players = new List<Player>
            {
                new Player
                {
                    Name="JY戴士",
                    DisplayName="JY",
                },
                new Player
                {
                    Name="王宝宝",
                    DisplayName="王宝宝",
                },
                new Player
                {
                    Name="Ksssssss",
                    DisplayName="KS",
                },
                new Player
                {
                    Name="荣耀Forry",
                    DisplayName="荣耀",
                },
                new Player
                {
                    Name="反水sama",
                    DisplayName="反水",
                },
                new Player
                {
                    Name="耿许儿",
                    DisplayName="耿许儿",
                },
                new Player
                {
                    Name="圈圈",
                    DisplayName="圈圈",
                },
                new Player
                {
                    Name="小黑",
                    DisplayName="小黑",
                },
                new Player
                {
                    Name="书亚信",
                    DisplayName="书亚信",
                },
                new Player
                {
                    Name="牛肉干干",
                    DisplayName="牛肉干",
                },
                new Player
                {
                    Name="诅咒",
                    DisplayName="诅咒",
                },
                new Player
                {
                    Name="长南之南",
                    DisplayName="长南",
                },
                new Player
                {
                    Name="郭小炜",
                    DisplayName="郭小炜",
                },
                new Player
                {
                    Name="徐言语",
                    DisplayName="徐言语",
                },
                new Player
                {
                    Name="陈明峻",
                    DisplayName="陈明峻",
                },
                new Player
                {
                    Name="陈俊洁",
                    DisplayName="陈俊洁",
                },
                new Player
                {
                    Name="嘴大",
                    DisplayName="嘴大",
                },
                new Player
                {
                    Name="寰寰",
                    DisplayName="寰寰",
                },
                new Player
                {
                    Name="果冻",
                    DisplayName="果冻",
                },
                new Player
                {
                    Name="秦子墨",
                    DisplayName="秦子墨",
                },
                new Player
                {
                    Name="水瓶座",
                    DisplayName="水瓶座",
                },
                new Player
                {
                    Name="5400",
                    DisplayName="5400",
                },
                new Player
                {
                    Name="起小点",
                    DisplayName="起小点",
                },
            };
            await context.Players.AddRangeAsync(players);

            await context.SaveChangesAsync();
        }
    }
}