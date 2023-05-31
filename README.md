# FivePD-P-ChangeDutyNotification

Allows you to change the duty notification:

![image](https://github.com/gggdunlix/FivePD-P-ChangeDutyNotification/assets/33298379/6b6496d7-a9f0-442c-be2e-0f792a339a60) ![image](https://github.com/gggdunlix/FivePD-P-ChangeDutyNotification/assets/33298379/c3d7df89-e70e-4ba5-983d-a5c460e8af4e)



## Installation

**1. Download the latest file from** [releases](/releases) **and put it in the** `plugins` **folder**

**2. Go to the fivepd** `config.json` **and set the** `"dutyNotification":` **to** `false` 

![image](https://github.com/gggdunlix/FivePD-P-ChangeDutyNotification/assets/33298379/cdd42a96-9903-48ec-87f7-108d2c10c129)

**3. add this block of code after the first** `{` **in the** `callouts.json` **file:**

```
"DutyNotification": {
		"onDuty": {
			"title": "Dispatch",
			"tooltip": "~f~Status",
			"text": "{name} [{callsign}] is ~g~on~s~ duty."
		},
		"offDuty": {
			"title": "Dispatch",
			"tooltip": "~f~Status",
			"text": "{name} [{callsign}] is ~r~off~s~ duty."
		}
	},
```
It should look like: ![image](https://github.com/gggdunlix/FivePD-P-ChangeDutyNotification/assets/33298379/ca147f60-6a57-4e38-b73f-e0a88dcd6a74)


## Configuration
```
"DutyNotification": {
		"onDuty": {
			"title": "Dispatch",
			"tooltip": "~f~Status",
			"text": "{name} [{callsign}] is ~g~on~s~ duty."
		},
		"offDuty": {
			"title": "Dispatch",
			"tooltip": "~f~Status",
			"text": "{name} [{callsign}] is ~r~off~s~ duty."
		}
	},
```
In this block of code, the text can be edited. Adding some variables inside { curly braces } will replace them with the FivePD names...
* `{name}` replaces the Display Name
* `{callsign}` replaces the Callsign
* `{department}` replaces the Short Department Name
* `{rank}` replaces the Rank
* You may also use [Fivem Text Formatting](https://docs.fivem.net/docs/game-references/text-formatting/) to use colors and other text formats.

some errors might occur if a player isn't in a department or has no rank/callsign.

FivePD Will also NOT START if any JSON files are incorrectly formatted!
[JSON Validater](https://jsonlint.com/)

### Configuring the 911 image:
1. Download [OpenIV](https://openiv.org/)
2. In the base `fivepd`  folder, create a folder named** `stream` . Upload [This File](https://github.com/gggdunlix/FivePD-P-ChangeDutyNotification/releases/download/ytd/CHAR_CALL911.ytd) to that.
3. Open OpenIV and click File > Open Folder -> and open your fivepd folder. Double click on `stream`

![image](https://github.com/gggdunlix/FivePD-P-ChangeDutyNotification/assets/33298379/e4478f2a-ccdc-4a20-b99f-1c83173801fb)


4. Turn ON Edit Mode.

![image](https://github.com/gggdunlix/FivePD-P-ChangeDutyNotification/assets/33298379/56a3c9d9-5416-4d53-ac64-e5dea27bd135)


5. open the `CHAR_CALL911.ytd` file from your `stream` folder.
6. Delete the current `CHAR_CALL911` image. Import another image of your choice using the Import button. Be sure to rename the new image to `CHAR_CALL911` or else it will not load in FiveM.

![image](https://github.com/gggdunlix/FivePD-P-ChangeDutyNotification/assets/33298379/ebea76d3-aab7-4d4b-93be-37be2c35c5d5)

![image](https://github.com/gggdunlix/FivePD-P-ChangeDutyNotification/assets/33298379/06703e3f-ab7c-40f3-aac8-20e79276f8c2)

CLICK SAVE!

![image](https://github.com/gggdunlix/FivePD-P-ChangeDutyNotification/assets/33298379/189aeff7-5f1a-420a-b06d-7b39d5b4bf40)

You should restart your FiveM Server when changing the 911 image. However, when only changing the text with the callouts.json, you can simply `ensure fivepd`.


## Now with the plugin, you can do things like this!
![image](https://github.com/gggdunlix/FivePD-P-ChangeDutyNotification/assets/33298379/1dfb9bae-4432-4572-a66e-c2ed2142c9cc)

