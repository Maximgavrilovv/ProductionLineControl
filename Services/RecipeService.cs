using ProductionLineControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProductionLineControl.Services
{
    public class RecipeService
    {
        private static readonly JsonSerializerOptions _options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        public void Save(string path, SpeedRecipe recipe)
        {
            // Гарантируем расширение .json
            path = Path.ChangeExtension(path, ".json");

            var json = JsonSerializer.Serialize(recipe, _options);

            // Явная перезапись — файл всегда создаётся заново
            File.WriteAllText(path, json, Encoding.UTF8);
        }

        public SpeedRecipe Load(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл рецепта не найден.", path);

            var json = File.ReadAllText(path, Encoding.UTF8)
                           .Trim(); // убираем BOM / пробелы по краям

            return JsonSerializer.Deserialize<SpeedRecipe>(json, _options)
                   ?? throw new InvalidDataException("Файл пуст или не является рецептом.");
        }
    }
}
