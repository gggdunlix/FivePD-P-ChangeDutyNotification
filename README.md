# FivePD-P-ChangeDutyNotification

Allows you to change the duty notification:

![image](https://github.com/gggdunlix/FivePD-P-ChangeDutyNotification/assets/33298379/6b6496d7-a9f0-442c-be2e-0f792a339a60)


## Installation

**1. Download the latest file from** [releases](/releases) **and put it in the** `plugins` **folder**
2. Go to the fivepd `config.json` and set the `"dutyNotification":` to `false` 

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

**5. In the base** `fivepd`  **folder, create a folder named** `stream` **. Upload [This File]() to that.
```

```



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
Beware some errors might occur if a player isn't in a department or has no rank/callsign.

FivePD Will also NOT START if any JSON files are incorrectly formatted!

### Configuring the 911 image:

