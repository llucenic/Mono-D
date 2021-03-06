﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonoDevelop.D.Projects.Dub
{
	public class DubBuildSettings : Dictionary<string, List<DubBuildSetting>>
	{
		public const string SourcePathsProperty = "sourcePaths";
		public const string ImportPathsProperty = "importPaths";

		//public Dictionary<string, string> subConfigurations;

		public static HashSet<string> OsVersions = new HashSet<string> { 
			"windows","win32","win64","linux","osx",
			"freebsd","openbsd","netbsd","dragonflybsd","bsd",
			"solaris","posix","aix","haiku","skyos","sysv3","sysv4","hurd",
			"android"
		};

		public static HashSet<string> Architectures = new HashSet<string> { 
			"Alpha_HardFloat","Alpha_SoftFloat","Alpha","SH64","SH","HPPA64","HPPA","S390X","","S390",
			"SPARC64","SPARC_HardFloat","SPARC_SoftFloat","SPARC_V8Plus","SPARC",
			"MIPS_HardFloat","MIPS_SoftFloat","MIPS_EABI","MIPS_N64","MIPS_O64","MIPS_N32","MIPS_O32","MIPS64","MIPS32",
			"ia64",
			"PPC64","PPC_HardFloat","PPC_SoftFloat","PPC","AArch64",
			"ARM_HardFloat","ARM_SoftFP","ARM_SoftFloat","ARM_Thumb","arm",
			"x86_64","x86"
		};

		static HashSet<string> WantedProps = new HashSet<string> {
			"sourceFiles",SourcePathsProperty,"excludedSourceFiles","versions",ImportPathsProperty,"stringImportPaths"
		};

		public bool TryDeserializeBuildSetting(JsonReader j)
		{
			if (!(j.Value is string))
				return false;
			var propName = (j.Value as string).Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
			if (propName.Length < 1)
				return false;

			// For now, only extract information that affect code completion
			if (!WantedProps.Contains(propName[0]))
			{
				j.Skip();
				return false;
			}

			j.Read();
			var flags = (new JsonSerializer()).Deserialize<string[]>(j);
			DubBuildSetting sett;

			if (propName.Length == 4)
			{
				sett = new DubBuildSetting
				{
					Name = propName[0],
					OperatingSystem = propName[1],
					Architecture = propName[2],
					Compiler = propName[3],
					Flags = flags
				};
			}
			else if (propName.Length == 1)
				sett = new DubBuildSetting { Name = propName[0], Flags = flags };
			else
			{
				string Os = null;
				string Arch = null;
				string Compiler = null;

				for (int i = 1; i < propName.Length; i++)
				{
					var pn = propName[i].ToLowerInvariant();
					if (Os == null && OsVersions.Contains(pn))
						Os = pn;
					else if (Arch == null && Architectures.Contains(pn))
						Arch = pn;
					else
						Compiler = pn;
				}

				sett = new DubBuildSetting { Name = propName[0], OperatingSystem = Os, Architecture = Arch, Compiler = Compiler, Flags = flags };
			}

			List<DubBuildSetting> setts;
			if (!TryGetValue(propName[0], out setts))
				Add(propName[0], setts = new List<DubBuildSetting>());

			setts.Add(sett);

			//{
			//	case "sourceFiles":

			//		break;
			//	case "sourcePaths":
			//		break;
			//	case "excludedSourceFiles":
			//		break;
			//	case "versions":
			//		break;
			//	case "importPaths":
			//		break;
			//	case "stringImportPaths":
			//		break;
			//	default:
			//		return false;
			//}

			return true;
		}
	}

	public class DubBuildSetting
	{
		public string Name;
		public string OperatingSystem;
		public string Architecture;
		public string Compiler;
		public string[] Flags;
	}



	public struct DubProjectDependency
	{
		public string Name;
		public string Version;
		public string Path;
	}
}
