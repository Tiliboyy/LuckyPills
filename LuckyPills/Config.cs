// -----------------------------------------------------------------------
// <copyright file="Config.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills
{
    using System.IO;
    using Exiled.API.Features;
    using Exiled.API.Interfaces;
    using Exiled.Loader;
    using LuckyPills.Configs;

    /// <inheritdoc />
    public class Config : IConfig
    {
        /// <summary>
        /// The configured effect config settings.
        /// </summary>
        public EffectsConfig Effects;

        /// <inheritdoc/>
        public bool IsEnabled { get; set; } = true;

        /// <summary>
        /// Gets or sets the directory path where the configuration file should reside.
        /// </summary>
        public string FolderPath { get; set; } = Path.Combine(Paths.Configs, "LuckyPills");

        /// <summary>
        /// Gets or sets the name of the file to store the configs in.
        /// </summary>
        public string FileName { get; set; } = "global.yml";

        /// <summary>
        /// Loads the effect configs.
        /// </summary>
        public void Reload()
        {
            if (!Directory.Exists(FolderPath))
                Directory.CreateDirectory(FolderPath);

            string path = Path.Combine(FolderPath, FileName);
            Effects = File.Exists(path)
                ? Loader.Deserializer.Deserialize<Configs.EffectsConfig>(File.ReadAllText(path))
                : new EffectsConfig();

            File.WriteAllText(path, Loader.Serializer.Serialize(Effects));
        }
    }
}