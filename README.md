# SCP-294 The Vending Machine ![GitHub all releases](https://img.shields.io/github/downloads/Ms-crew/scp-294/total)
### SCP: Secret Laboratory plugin made with [EXILED](https://github.com/Exiled-Team/EXILED) and [MER](https://github.com/Michal78900/MapEditorReborn) (latest releases)

This plugin adds SCP-294 to the game. SCP-294 is a vending machine that will give you a drink based on the prompt you give it. This plugin allows you to add your own drinks in the config and provides you with a few default examples that you can use to create your own. **Keep in mind that these examples are also customizable**. You can also use this [template](#template).
Besides the release, we also provide a model **made by Scout Trooper (@scouttrooperrp) from MER discord** and make sure it spawns in the map otherwise the plugin will not work. The plugin also **supports** custom models for the machine, so if you already have your own model just change the 'SchematicName' field in the config to the name of your model.
**Keep in mind that the model has to spawn for the plugin to work.** It essentially waits for a spawned schematic with the name equal to the one in the config. **If this is your first time working with custom models and schematics you should probably read the section below.**

## Setup guide on how to place the schematic in your server and start using the plugin.
1. Make sure you have MapEditorReborn Plugin in your server. If you've just downloaded it and placed it in your plugins folder, run it once so it generates the required configs and files.
2. Download the zip and extract it into .../EXILED/Configs/MapEditorReborn/Schematics. You must now have inside said schematics folder, a folder with a json file inside both with the name scp294.
3. Go in game and spawn the schematic in whichever room you want using the command: mp create scp294
4. Place scp294 wherever you want, you can set the position, rotation and scale of the machine with the commands:
- mp pos set x y z (replace x  y z with the coordinates you want -- keep in mind these are relative to the center of the room)
- mp rot set x y z (replace x y z with the values you want)
- mp scale set x y z (replace x y z with the values you want)
- you can also use the gravity gun (not recommended) mp gg
5. Once you have the machine in a spot you're happy with you can save the map with: mp save {whatever name you'd like for your map} for the sake of this tutorial we saved it as scp294. You can now disconnect and turn off the server.
6. Go into MER config and add the map name to the load_map_on_event - on_generated/on_round_started (it can be either one, choose one).
In this screenshot the name I gave to the map previously was 'scp294'.

![alt text](scp-294/Assets/MERconfig_example.png)

7. Turn your server back on and check if the machine has automatically spawned in the room you placed it before. It should have if you followed the steps.
8. Scp294 is now ready to be used! Have fun!
9. If you're still having issues I heavily encourage you to look at [MER](https://github.com/Michal78900/MapEditorReborn) tutorials. They are quick and quite simple.
   
## In-Game Features and Usage
Every player, can use the in game command '.scp294 list' to view every drink enabled in the server.
To interact with the machine you must be close to it (range is configurable) and use the command '.scp294 {name of the drink}'.
Admins can spawn in enabled drinks only via our own remote admin commands, since we do not register the custom items into Exiled, so customitems give will **NOT** work.
These commands are:
- customdrinks give {drink_id} 
- customdrinks give {drink_id} {player_id/player_name/all}
- customdrinks list

There is also a **random mode**: Random mode does not allow you to choose the drink you want. Players must use the command '.scp294' and they will receive a random drink.
This option is toggleable from the config.
## Adding your own drinks
You create your own drinks and modify existing ones through the drinks config. Assuming default values, this config is located in .../EXILED/Configs/Drinks. *Note: the path and file name is also customizable through the original config*. To create your own drinks simply **add** to the list by copying and pasting an existing one as a base and change its values. Here's a [template](#template) you can copy. You can also find a list of every EffectType, ZoneType, RoomType that you will need to use while creating your drinks in this [section](#resources)
## This is a list with every default prompt and its respective drink. Keep in mind that everything is customizable.
| Id | Prompt   |  Result drink  |
| :--: | :------: | :------------: |
| 1 | drink of air | literally does nothing, it servers as a template for the player to create their own drinks |
| 2 | scp drink | disguises the player as a random scp |
| 3 | drink of scp173 | gives the player a massive movement boost |
| 4 | drink of scp106 | teleports the player to the pocket dimension |
| 6 | drink of chorus fruit | teleports the player to a random room |
| 7 | drink of candy | gives the player a random combination of candy effects |
| 8 | drink of rainbow candy | gives the player a boosted rainbow candy effect |
| 9 | drink of yellow candy | gives the player a boosted yellow candy effect |
| 10 | drink of purple candy | gives the player a boosted purple candy effect |
| 11 | drink of red candy | gives the player a boosted red candy effect |
| 12 | drink of green candy | gives the player a boosted green candy effect | 
| 13 | drink of blue candy | gives the player a boosted blue candy effect |
| 14 | drink of pink candy | weirdly pink green, I wonder what happens when you drink it |
| 15 | drink of blood | removes 30 hp from the player |
| 16 | drink of life | heals the player for 100 hp |
| 17 | antimatter | explodes when dispensed from the machine |
| 18 | shrink potion | shrinks the player |
| 19 | drink of chaos | turns the player into a chaos role |
## Template <a name="template"></a>
<details>
<summary>Drink</summary>

```yml
- name: 'drink of air'
  aliases:
  - 'nothing'
  - 'drink of cup'
  - 'drink of emptiness'
  - 'drink of vacuum'
  - 'HL3'
  - 'Half Life 3'
  id: 1
  # Description of the drink, this is what appears when holding the drink
  description: 'There is nothing to drink in the bottle.'
  # Whether or not the drink is enabled on your server. If this is set to false, drinks won't even register so you won't be able to have it through RA
  is_enabled: true
  type: AntiSCP207
  weight: 1
  remove_anti_cola_effect: true
  # List of effects that will be applied to the player
  effects: []
  teleport_manager:
  # Whether or not the player is teleported
    player_teleport: false
    # Whether or not the player can teleport out of the pocket dimension
    can_player_escape_pocket_dimension: false
    # Message that appears when player is prevented from leaving the pocket dimension
    message_preventing_pocket_teleport: 'A magical force prevents you from teleporting.'
    # Whether or not the player is able to teleport after the nuke has exploded.
    can_player_teleport_after_nuke: false
    # The message that appears when a player is prevented from teleporting after the nuke has exploded..
    message_preventing_teleport_after_nuke: 'The nuke has exploded, you would end up locked up in the facility along with toxic gas.'
    # The zone to which the player will be teleported to. If this is anything but Unspecified it will teleport the player to a random room within that zone
    zone: Unspecified
    # Ignored if zone is anything other than Unspecified. Room that the player will teleport too. Set this to Unknown along with Zone Unspecified to teleport to a random place across the entire facility
    room: Unknown
  appearance_options:
  # Whether or not the player should change appearance
    change_player_appearance: false
    # List of roles the player can turn to. As you can imagine scp-079 is not an option.
    possible_roles: []
    # Amount of time the player's appearance will be changed
    duration: 0
    # Hint displayed once the player changes appearance and counts the time left. Make sure to add '$new_role_name' and '$time_left', these will be replaced by the actual values
    disguise_message: ''
    # Hint displayed once you're no longer in disguise
    no_longer_in_disguise: ''
  extra_effects:
  # Whether or not the player explodes after drinking.
    player_explode: false
    # Whether or not it will generate an explosion once you ask for the drink
    explode_on_dispensing: false
    # Whether or not the player gains Ahp. Set this to 0 if no Ahp.
    ahp_gain: 0
    # Whether or not the player gains/loses stamina. Value between -1 and 1. 0 for no change.
    stamina_change: 0
    # Whether or not tantrum is placed beneath the player.
    place_tantrum: false
    # Whether or not the player receives HP.
    heal_amount: 0
    # How much damage the player will take on consuming the drink
    damage_amount: 0
    # Whether or not the player receives passive regeneration.
    regeneration:
    # Rate of the regeneration.
      rate: 0
      # Duration of the regeneration.
      duration: 0
    # Whether or not the player gets teleported to pocket dimension.
    teleport_to_pocket_dimension: false
  scaling_options:
  # How much the player should be scaled on x-axis
    x: 1
    # How much the player should be scaled on y-axis
    y: 1
    # How much the player should be scaled on z-axis
    z: 1
  role_manager_options:
  # Whether or not the player should change roles.
    player_change_roles: false
    # Roles the player will be able to turn to. It will choose one randomly. If there is only one it will choose that one.
    roles: []
  spawn_properties:
    limit: 0
    dynamic_spawn_points: []
    static_spawn_points: []
    role_spawn_points: []
  scale:
    x: 1
    y: 1
    z: 1
```

</details>
<details>
<summary>Effect</summary>
Effect template to add to the effects list. You can add multiple of these.

```yml
- type: Vitality
    duration: 40
    intensity:
    # If you want a random intensity in a specific range, set this to -1
      fixed_amount: 1
      # This is the lowest amount of the range of intensity possible. If Fixed Amount is 0 or above these will be ignored
      lowest_amount: 0
      # This is the highest amount of the range of intensity possible. If Fixed Amount is 0 or above these will be ignored
      highest_amount: 0
    # The chance of this effect to be applied, in %
    chance: 100
```

</details>

## Resources <a name="resources"></a>
You can also view these at [EXILED repo](https://github.com/Exiled-Team/EXILED) and their [discord server](https://discord.gg/PyUkWTg)
<details>
<summary>EffectTypes</summary>

```
AmnesiaItems
AmnesiaVision
Asphyxiated
Bleeding
Blinded
Burned
Concussed
Corroding
Deafened
Decontaminating
Disabled
Ensnared
Exhausted
Flashed
Hemorrhage
Invigorated
BodyshotReduction
Poisoned
Scp207
Invisible
SinkHole
DamageReduction
MovementBoost
RainbowTaste
SeveredHands
Stained
Vitality
Hypothermia
Scp1853
CardiacArrest
InsufficientLighting
SoundtrackMute
AntiScp207
Scanned
```

</details>
<details>
<summary>ZoneTypes</summary>

```
Unspecified      
LightContainment 
HeavyContainment 
Entrance         
Surface          
Other           
```

</details>
<details>
<summary>RoomTypes</summary>

```
Unknown
LczArmory
LczCurve
LczStraight
Lcz330
Lcz914
LczCrossing
LczTCross
LczCafe
LczPlants
LczToilets
LczAirlock
Lcz173
LczClassDSpawn
LczCheckpointB
LczGlassBox
LczCheckpointA
Hcz079
HczEzCheckpointA
HczEzCheckpointB
HczArmory
Hcz939
HczHid
Hcz049
HczChkpA
HczCrossing
Hcz106
HczNuke
HczTesla
HczServers
HczChkpB
HczTCross
HczCurve
Hcz096
EzVent
EzIntercom
EzGateA
EzDownstairsPcs
EzCurve
EzPcs
EzCrossing
EzCollapsedTunnel
EzConference
EzStraight
EzCafeteria
EzUpstairsPcs
EzGateB
EzShelter
Pocket
Surface
EzCheckpointHallway
HczTestRoom        
```

</details>


