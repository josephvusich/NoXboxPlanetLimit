# No Xbox Planet Limit
Space Engineers dedicated server plugin to disable the 3-planet limit, and enable the full Star System world on Xbox servers.

By default, Xbox servers only allow 3 (unique) planets per world, though it is possible to spawn multiple copies of the same planet. This plugin raises the limit to 99 unique planets, which seems to be the default on PC.

***Warning:** Older Xbox consoles may be unable to join, or crash when joining, due to planets' high RAM requirements. This plugin has only been tested on the Xbox Series X, using the Star System [PC] world.*

# Building
If you do not have Visual Studio, you can download the pre-built plugin with dependencies from the releases page and skip to [Installation and usage](#installation-and-usage).
1. Clone this repository.
2. Open `NoXboxPlanetLimit.sln` in Visual Studio.
3. If your Steam or Space Engineers install paths are not in the default `C:\Program Files (x86)\Steam`, update the missing library references to the correct game install path.
4. Ensure the solution Platform is set to `x64`, and not `AnyCPU`, to avoid mismatch warnings.
5. Click Build > Build Solution.
6. Copy `NoXboxPlanetLimit.dll` from the build output and continue to the next section.

# Installation and usage
1. Download and install [SEDedicatedPluginLoader](https://github.com/josephvusich/SEDedicatedPluginLoader) on the dedicated server.
2. **If using pre-built plugin:** Download the latest version of this plugin from the releases page and unzip locally. Copy the contents of `Plugins` to the SEDedicatedPluginLoader directories of the same name, set up in the previous step.
3. **If building manually:** Follow the Building instructions above, then copy `NoXboxPlanetLimit.dll` to the `Plugins` folder.
4. Unblock the DLL. To unblock, right-click `NoXboxPlanetLimit.dll`, click Properties, select Unblock, and then click OK.
  * If Unblock does not appear in the Properties window, the file is already unblocked.
5. Restart the server.

# Migrating PC server worlds to Xbox
If the Dedicated Server Manager does not show PC worlds when Console Compatibility is enabled, do the following:
1. Open the world folder in the Saves directory.
2. Delete the `.scf` file, e.g., for `Star System [PC]`, the file is named `StarSystem.scf`.
3. In the Server Settings, Click Saved Worlds > Refresh, and the world should now be selectable.

# Uninstallation
1. Remove `Plugins/NoXboxPlanetLimit.dll` from the [SEDedicatedPluginLoader](https://github.com/josephvusich/SEDedicatedPluginLoader) installation folder.
