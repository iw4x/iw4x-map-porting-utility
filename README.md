# ![iw4-mpu](Resources/cardicon_porterjustice.png) IW4x Map Porting Utility
IW4x MPU is a middleware to simplify porting maps from Call Of Duty 4 (referred to as IW3) to Call Of Duty: Modern Warfare 2 (referred to as IW4) and unify the export from [iw3xport](https://github.com/iw4x/iw3x-port) to [zonebuilder](https://github.com/iw4x/iw4x-client).

![image](https://user-images.githubusercontent.com/33836535/208086098-54f5a29b-8aeb-4b63-8186-a869abd0ff6c.png)

It should be simple to use and allow the average user to port maps from IW3 to IW4 with no hassle 🎉

## Requirements
- Call Of Duty 4 (1.7) in any language
- [Latest version of IW3x.dll + IW3xport.exe](https://github.com/iw4x/iw3x-port/releases/latest) dropped in the Call Of Duty 4 game folder
- Call Of Duty: Modern Warfare 2 (Any version compatible with IW4x)
- Latest version of IW4x as obtained through the [XLabs Launcher](https://github.com/iw4x/launcher)

## Usage
While providing a lot of room for customization with a ton of checkboxes and a dropdown menu, it is important to note that **the default options should work best for most users**.
On the first start, you might be greeted with this screen prompting you to specify your game(s) location:

![image](https://user-images.githubusercontent.com/33836535/208087357-012e8087-f841-48a3-8f38-eba7d1cb8647.png)

Indicate the location of your Call Of Duty 4 installation and the location of your Modern Warfare 2 installation to continue.

### Step 1
- Select one or more maps to convert

![image](https://user-images.githubusercontent.com/33836535/208087045-4fe6faff-e31c-4fa5-a252-f2e9e199921b.png)

- Press **Export and prepare** to dump the map to the correct folder. Wait for the process to finish.

### Step 2
- Select one or more maps to build

![image](https://user-images.githubusercontent.com/33836535/208087990-e8ec34c8-76cb-4904-982f-adb834381546.png)

- Press **Build zone** to build the map. Wait for the process to finish. The converted map will end up in `<Your MW2 game location>/usermaps`

### Step 3

Your map is now ready to be played! You can press **Run map** to test it.
If you wish to share it, you will need to **Generate IWD** first and then distribute a zip containing your map files, arena file and IWD.

# FAQ & Common issues
- **I have a script / GSC error upon loading the map**

You might need to fix the GSC files in `<Your MW2 installation>/mods/maps/mp` manually if your map contained complex scripts in IW3. The automatic upgrade of GSC by iw3xport works for most maps but not all.

- **The models blink, flicker and disappear when I move around in my map**

Your map contains static models that blow out the limitations of IW4's engine. This problem would normally either crash or tank your map, but iw3xport automatically fixes it. The default fix moves models around in the GfxWorld component of the map, which can cause visibility issues on some maps. An alternative way to fix it is also available and can be selected in the following menu:

![image](https://user-images.githubusercontent.com/33836535/208089247-532d6a61-74ef-4634-9a8e-6c622bd984d0.png)

Re-export then rebuild your map with this "Swap + Move to entities" selected to fix your problem.

- **Some trees are dark/black**

This is a known material error that has no automatic fix for the moment, but can be addressed by editing the materials manually in `<Your MW2 installation>/mods/materials` to fix the trees manually. You can see which material your tree is using in game by using `cg_drawmaterial` or by using `r_drawModelNames 3` and then inspecting the model files related to your tree to find which material(s) it may be using.

- **My map crashes or doesn't start** / Other problems

On some maps that have been officially ported (like CODO Bloc or MW2 Overgrown), IW4x may contain files already that pertain to the "officially ported" version and that are incompatible with your own port, such as entity files. If that is the case, you can copy the file in `<Your MW2 installation>/mods/<your map name>/ents` to `<Your MW2 installation>/mods/maps/mp` and rename it `<your map name>.d3dbsp.ents` to force the game to use your entities file instead of the "official" one.
Any other crashing map should be reported **to our discord**. 

![image](https://user-images.githubusercontent.com/33836535/208088574-e6558cfe-3710-4670-a42f-cd0b71cc9a54.png)



