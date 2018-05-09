﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineRules  {

	public MachineRules(){


	}

	public Dictionary<string, string> getSum(){
		return new Dictionary<string, string>{
			{"01","1R0"},
			{"0+","1R1"},
			{"11","1R1"},
			{"1β","βL2"},
			{"21","βN3"}
		};
	}

	public Dictionary<string, string> getSub(){
		return new Dictionary<string, string>{
			{"01","βR1"},
			{"0-","-R10"},
			{"0β","βN3"},
			{"11","1R1"},
			{"1-","-L2"},
			{"2β","βR13"},
			{"21","1R4"},
			{"4-","-R5"},
			{"5β","βL6"},
			{"51","1R7"},
			{"6-","βN3"},
			{"71","1R7"},
			{"7β","βL8"},
			{"81","βL9"},
			{"91","1L11"},
			{"9-","-L12"},
			{"10β","βL6"},
			{"101","1N3"},
			{"111","1L11"},
			{"11-","-L11"},
			{"11β","βR0"},
			{"121","1R6"},
			{"12β","βR6"},
			{"13-","-R13"},
			{"131","1R14"},
			{"14β","βL15"},
			{"141","1R16"},
			{"151","βL6"},
			{"161","1R16"},
			{"16β","βL17"},
			{"171","βN3"}
		};
	}

	public Dictionary<string, string> getMult(){
		return new Dictionary<string, string>{
			{"01","1R0"},
			{"0*","*R0"},
			{"0β","=L1"},
			{"11","1L1"},
			{"1*","*L1"},
			{"1β","βR2"},//
			{"21","βR3"},
			{"31","1R3"},
			{"3*","*R4"},
			{"4-","-R4"},
			{"41","-R5"},
			{"51","1R5"},
			{"5=","=R5"},
			{"5β","1L6"},
			{"6=","=L6"},
			{"61","1L6"},
			{"6-","-R7"},
			{"71","1L4"},
			{"7=","=L8"},
			{"8-","1L8"},
			{"8*","*L9"},
			{"9β","βR10"},
			{"91","1L12"},
			{"10*","βR10"},
			{"101","βR10"},
			{"10=","βN11"},
			{"121","1L12"},
			{"12β","βR2"}
		};
	}

	public Dictionary<string, string> getCopy(){
		return new Dictionary<string, string>{
			{"0a","aR2"},
			{"0b","bR2"},
			{"0c","cR2"},
			{"0β","βN1"},
			{"2a","aR2"},
			{"2b","bR2"},
			{"2c","cR2"},
			{"2β","|L3"},
			{"3a","aL3"},
			{"3b","bL3"},
			{"3c","cL3"},
			{"3β","βR4"},
			{"4a","-L5"},
			{"4b","-L6"},
			{"4c","-L7"},
			{"5-","aR8"},
			{"5β","aR8"},
			{"6-","bR9"},
			{"6β","bR9"},
			{"7-","cR10"},
			{"7β","cR10"},
			{"8a","aR8"},
			{"8b","bR8"},
			{"8c","cR8"},
			{"8|","|R8"},
			{"8-","-R8"},
			{"8β","aL11"},
			{"9a","aR9"},
			{"9b","bR9"},
			{"9c","cR9"},
			{"9|","|R9"},
			{"9-","-R9"},
			{"9β","bL11"},
			{"10a","aR10"},
			{"10b","bR10"},
			{"10c","cR10"},
			{"10|","|R10"},
			{"10-","-R10"},
			{"10β","cL11"},
			{"11a","aL11"},
			{"11b","bL11"},
			{"11c","cL11"},
			{"11|","|L11"},
			{"11-","-R12"},
			{"12a","aL13"},
			{"12b","bL13"},
			{"12c","cL13"},
			{"12|","|R14"},
			{"13-","-R4"},
			{"14a","aR14"},
			{"14b","bR14"},
			{"14c","cR14"},
			{"14β","TL15"},
			{"15a","aL15"},
			{"15b","bL15"},
			{"15c","cL15"},
			{"15|","βL15"},
			{"15-","-R16"},
			{"16β","βR16"},
			{"16a","βL17"},
			{"16b","βL18"},
			{"16c","βL19"},
			{"17β","βL17"},
			{"17-","aR20"},
			{"18β","βL18"},
			{"18-","bR20"},
			{"19β","βL19"},
			{"19-","cR20"},
			{"20β","-R21"},
			{"21β","βR21"},
			{"21T","βL23"},
			{"21a","aL22"},
			{"21b","bL22"},
			{"21c","cL22"},
			{"22β","βR16"},
			{"23β","βL23"},
			{"23-","βN1"}
		};
	}

	public Dictionary<string, string> getPal(){
		return new Dictionary<string, string>{
			{"0a","βR1"},
			{"0b","βR2"},
			{"0c","βR3"},
			{"0β","βN11"},
			{"1a","aR4"},
			{"1b","bR4"},
			{"1c","cR4"},
			{"1β","βN11"},
			{"4a","aR4"},
			{"4b","bR4"},
			{"4c","cR4"},
			{"4β","βL5"},
			{"5a","βL6"},
			{"6a","aL6"},
			{"6b","bL6"},
			{"6c","cL6"},
			{"6β","βR0"},
			{"2a","aR7"},
			{"2b","bR7"},
			{"2c","cR7"},
			{"2β","βN11"},
			{"7a","aR7"},
			{"7b","bR7"},
			{"7c","cR7"},
			{"7β","βL8"},
			{"8b","βL6"},
			{"3a","aR9"},
			{"3b","bR9"},
			{"3c","cR9"},
			{"3β","βN11"},
			{"9a","aR9"},
			{"9b","bR9"},
			{"9c","cR9"},
			{"9β","βL10"},
			{"10c","βL6"}
		};
	}


}