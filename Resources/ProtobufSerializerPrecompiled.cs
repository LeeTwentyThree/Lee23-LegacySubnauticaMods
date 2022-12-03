using System;
using System.Collections.Generic;
using ProtoBuf;
using ProtoBuf.Meta;
using Story;
using UnityEngine;

public sealed class ProtobufSerializerPrecompiled : TypeModel
{
	public static bool IsEmptyContract(Type key)
	{
		return ProtobufSerializerPrecompiled.emptyContracts.Contains(key);
	}

	protected override int GetKeyImpl(Type key)
	{
		int result;
		if (ProtobufSerializerPrecompiled.knownTypes.TryGetValue(key, out result))
		{
			return result;
		}
		return -1;
	}

	protected override void Serialize(int num, object obj, ProtoWriter writer)
	{
		if (num <= 1056558719)
		{
			if (num <= 503490010)
			{
				if (num <= 252526906)
				{
					if (num <= 122249312)
					{
						if (num <= 42492657)
						{
							if (num <= 10881664)
							{
								if (num <= 3219972)
								{
									if (num == 1640880)
									{
										this.Serialize356643005((SeaMonkeyBaby)obj, 1640880, writer);
										return;
									}
									if (num != 3219972)
									{
										return;
									}
									this.Serialize356643005((SymbioteFish)obj, 3219972, writer);
									return;
								}
								else
								{
									if (num == 7443242)
									{
										this.Serialize7443242((AnalyticsController)obj, 7443242, writer);
										return;
									}
									if (num == 10406022)
									{
										this.Serialize10406022((PlayerSoundTrigger)obj, 10406022, writer);
										return;
									}
									if (num != 10881664)
									{
										return;
									}
									this.Serialize10881664((DiveReel)obj, 10881664, writer);
									return;
								}
							}
							else if (num <= 35332337)
							{
								if (num == 11492366)
								{
									this.Serialize11492366((Respawn)obj, 11492366, writer);
									return;
								}
								if (num == 26260290)
								{
									this.Serialize26260290((DayNightLight)obj, 26260290, writer);
									return;
								}
								if (num != 35332337)
								{
									return;
								}
								this.Serialize356643005((GhostLeviathan)obj, 35332337, writer);
								return;
							}
							else
							{
								if (num == 40841636)
								{
									this.Serialize356643005((BirdBehaviour)obj, 40841636, writer);
									return;
								}
								if (num == 41335609)
								{
									this.Serialize41335609((FruitPlant)obj, 41335609, writer);
									return;
								}
								if (num != 42492657)
								{
									return;
								}
								this.Serialize356643005((BruteShark)obj, 42492657, writer);
								return;
							}
						}
						else if (num <= 81014147)
						{
							if (num <= 59821228)
							{
								if (num == 49368518)
								{
									this.Serialize356643005((CrabSquid)obj, 49368518, writer);
									return;
								}
								if (num == 51037994)
								{
									this.Serialize51037994((Inventory)obj, 51037994, writer);
									return;
								}
								if (num != 59821228)
								{
									return;
								}
								this.Serialize59821228((CreatureEgg)obj, 59821228, writer);
								return;
							}
							else
							{
								if (num == 69304398)
								{
									this.Serialize69304398((ProtobufSerializer.LoopHeader)obj, 69304398, writer);
									return;
								}
								if (num == 72619689)
								{
									this.Serialize72619689((Collider)obj, 72619689, writer);
									return;
								}
								if (num != 81014147)
								{
									return;
								}
								this.Serialize356643005((SandShark)obj, 81014147, writer);
								return;
							}
						}
						else if (num <= 113236186)
						{
							if (num == 82819465)
							{
								this.Serialize82819465((Roost)obj, 82819465, writer);
								return;
							}
							if (num == 108625815)
							{
								this.Serialize108625815((FogSettings)obj, 108625815, writer);
								return;
							}
							if (num != 113236186)
							{
								return;
							}
							this.Serialize2066256250((GrownPlant)obj, 113236186, writer);
							return;
						}
						else
						{
							if (num == 118512508)
							{
								this.Serialize118512508((AnimationCurve)obj, 118512508, writer);
								return;
							}
							if (num == 121008834)
							{
								this.Serialize121008834((KeyValuePair<string, PDAEncyclopedia.Entry>)obj, 121008834, writer);
								return;
							}
							if (num != 122249312)
							{
								return;
							}
							this.Serialize122249312((LargeWorldEntityCell)obj, 122249312, writer);
							return;
						}
					}
					else if (num <= 205226061)
					{
						if (num <= 160169329)
						{
							if (num <= 135876261)
							{
								if (num == 123477383)
								{
									this.Serialize356643005((Mesmer)obj, 123477383, writer);
									return;
								}
								if (num != 135876261)
								{
									return;
								}
								this.Serialize2066256250((Crafter)obj, 135876261, writer);
								return;
							}
							else
							{
								if (num == 149935601)
								{
									this.Serialize149935601((Transform)obj, 149935601, writer);
									return;
								}
								if (num == 153467737)
								{
									this.Serialize153467737((CellManager.CellsFileHeader)obj, 153467737, writer);
									return;
								}
								if (num != 160169329)
								{
									return;
								}
								this.Serialize160169329((WeatherManager)obj, 160169329, writer);
								return;
							}
						}
						else if (num <= 185046565)
						{
							if (num == 161874211)
							{
								this.Serialize161874211((ResourceTrackerDatabase.ResourceInfo)obj, 161874211, writer);
								return;
							}
							if (num == 175529349)
							{
								this.Serialize175529349((Gradient)obj, 175529349, writer);
								return;
							}
							if (num != 185046565)
							{
								return;
							}
							this.Serialize185046565((PrecursorElevator)obj, 185046565, writer);
							return;
						}
						else
						{
							if (num == 190681690)
							{
								this.Serialize190681690((Oxygen)obj, 190681690, writer);
								return;
							}
							if (num == 200911463)
							{
								this.Serialize200911463((LEDLight)obj, 200911463, writer);
								return;
							}
							if (num != 205226061)
							{
								return;
							}
							this.Serialize205226061((Dockable)obj, 205226061, writer);
							return;
						}
					}
					else if (num <= 236473635)
					{
						if (num <= 217879716)
						{
							if (num == 205484837)
							{
								this.Serialize205484837((PingInstance)obj, 205484837, writer);
								return;
							}
							if (num == 212928398)
							{
								this.Serialize212928398((TechFragment)obj, 212928398, writer);
								return;
							}
							if (num != 217879716)
							{
								return;
							}
							this.Serialize217879716((ProtobufSerializer.StreamHeader)obj, 217879716, writer);
							return;
						}
						else
						{
							if (num == 224877162)
							{
								this.Serialize224877162((KeyValuePair<string, int>)obj, 224877162, writer);
								return;
							}
							if (num == 225324449)
							{
								this.Serialize225324449((SwimRandom)obj, 225324449, writer);
								return;
							}
							if (num != 236473635)
							{
								return;
							}
							this.Serialize356643005((DiscusFish)obj, 236473635, writer);
							return;
						}
					}
					else if (num <= 242125589)
					{
						if (num == 237257528)
						{
							this.Serialize237257528((CoffeeMachineLegacy)obj, 237257528, writer);
							return;
						}
						if (num == 239375628)
						{
							this.Serialize239375628((AtmosphereVolume)obj, 239375628, writer);
							return;
						}
						if (num != 242125589)
						{
							return;
						}
						this.Serialize242125589((Stillsuit)obj, 242125589, writer);
						return;
					}
					else
					{
						if (num == 242904679)
						{
							this.Serialize356643005((BoneShark)obj, 242904679, writer);
							return;
						}
						if (num == 248259089)
						{
							this.Serialize248259089((PDAScanner.Entry)obj, 248259089, writer);
							return;
						}
						if (num != 252526906)
						{
							return;
						}
						this.Serialize356643005((VoidLeviathan)obj, 252526906, writer);
						return;
					}
				}
				else if (num <= 356984973)
				{
					if (num <= 315488296)
					{
						if (num <= 289177516)
						{
							if (num <= 257036954)
							{
								if (num == 253947874)
								{
									this.Serialize253947874((RestoreAnimatorState)obj, 253947874, writer);
									return;
								}
								if (num != 257036954)
								{
									return;
								}
								this.Serialize2066256250((ConstructorInput)obj, 257036954, writer);
								return;
							}
							else
							{
								if (num == 273953122)
								{
									this.Serialize273953122((RestoreDayNightCycle)obj, 273953122, writer);
									return;
								}
								if (num == 285680569)
								{
									this.Serialize285680569((PrecursorGunStoryEvents)obj, 285680569, writer);
									return;
								}
								if (num != 289177516)
								{
									return;
								}
								this.Serialize289177516((Int3Class)obj, 289177516, writer);
								return;
							}
						}
						else if (num <= 309711119)
						{
							if (num == 294226815)
							{
								this.Serialize294226815((SeaTruckMotor)obj, 294226815, writer);
								return;
							}
							if (num == 304513582)
							{
								this.Serialize304513582((global::Flare)obj, 304513582, writer);
								return;
							}
							if (num != 309711119)
							{
								return;
							}
							this.Serialize2066256250((PrecursorPartFabricator)obj, 309711119, writer);
							return;
						}
						else
						{
							if (num == 311542795)
							{
								this.Serialize1180542256((BaseRoot)obj, 311542795, writer);
								return;
							}
							if (num == 313352173)
							{
								this.Serialize313352173((ProtobufSerializer.ComponentHeader)obj, 313352173, writer);
								return;
							}
							if (num != 315488296)
							{
								return;
							}
							this.Serialize315488296((DayNightCycle)obj, 315488296, writer);
							return;
						}
					}
					else if (num <= 331658349)
					{
						if (num <= 328142573)
						{
							if (num == 325421431)
							{
								this.Serialize325421431((FireExtinguisher)obj, 325421431, writer);
								return;
							}
							if (num == 326697518)
							{
								this.Serialize326697518((Constructor)obj, 326697518, writer);
								return;
							}
							if (num != 328142573)
							{
								return;
							}
							this.Serialize328142573((ProtobufSerializerCornerCases)obj, 328142573, writer);
							return;
						}
						else
						{
							if (num == 328683587)
							{
								this.Serialize356643005((Warper)obj, 328683587, writer);
								return;
							}
							if (num == 328727906)
							{
								this.Serialize356643005((Hoopfish)obj, 328727906, writer);
								return;
							}
							if (num != 331658349)
							{
								return;
							}
							this.Serialize331658349((FixedBase)obj, 331658349, writer);
							return;
						}
					}
					else if (num <= 351821017)
					{
						if (num == 348559960)
						{
							this.Serialize348559960((NotificationManager.SerializedData)obj, 348559960, writer);
							return;
						}
						if (num == 350666384)
						{
							this.Serialize350666384((SoundQueue)obj, 350666384, writer);
							return;
						}
						if (num != 351821017)
						{
							return;
						}
						this.Serialize356643005((Eyeye)obj, 351821017, writer);
						return;
					}
					else
					{
						if (num == 353579366)
						{
							this.Serialize356643005((LavaLarva)obj, 353579366, writer);
							return;
						}
						if (num == 356643005)
						{
							this.Serialize356643005((Creature)obj, 356643005, writer);
							return;
						}
						if (num != 356984973)
						{
							return;
						}
						this.Serialize356984973((PrecursorAquariumPlatformTrigger)obj, 356984973, writer);
						return;
					}
				}
				else if (num <= 424968344)
				{
					if (num <= 391689956)
					{
						if (num <= 371084514)
						{
							if (num == 366077262)
							{
								this.Serialize2066256250((StorageContainer)obj, 366077262, writer);
								return;
							}
							if (num != 371084514)
							{
								return;
							}
							this.Serialize371084514((BaseExplicitFace)obj, 371084514, writer);
							return;
						}
						else
						{
							if (num == 383673295)
							{
								this.Serialize1585678550((BaseAddCellGhost)obj, 383673295, writer);
								return;
							}
							if (num == 387767963)
							{
								this.Serialize387767963((ExchangerRocketConstructor)obj, 387767963, writer);
								return;
							}
							if (num != 391689956)
							{
								return;
							}
							this.Serialize391689956((Bounds)obj, 391689956, writer);
							return;
						}
					}
					else if (num <= 406373562)
					{
						if (num == 394322812)
						{
							this.Serialize394322812((Component)obj, 394322812, writer);
							return;
						}
						if (num == 396637907)
						{
							this.Serialize2066256250((Constructable)obj, 396637907, writer);
							return;
						}
						if (num != 406373562)
						{
							return;
						}
						this.Serialize406373562((CreatureBehaviour)obj, 406373562, writer);
						return;
					}
					else
					{
						if (num == 407275749)
						{
							this.Serialize407275749((PlayerTimeCapsule)obj, 407275749, writer);
							return;
						}
						if (num == 414351131)
						{
							this.Serialize356643005((Pinnacarid)obj, 414351131, writer);
							return;
						}
						if (num != 424968344)
						{
							return;
						}
						this.Serialize424968344((PlayerLilyPaddlerHypnosis)obj, 424968344, writer);
						return;
					}
				}
				else if (num <= 478713964)
				{
					if (num <= 469144263)
					{
						if (num == 438265826)
						{
							this.Serialize438265826((UnstuckPlayer)obj, 438265826, writer);
							return;
						}
						if (num == 459225532)
						{
							this.Serialize459225532((GenericConsole)obj, 459225532, writer);
							return;
						}
						if (num != 469144263)
						{
							return;
						}
						this.Serialize356643005((Skyray)obj, 469144263, writer);
						return;
					}
					else
					{
						if (num == 474388930)
						{
							this.Serialize474388930((ItemExchanger)obj, 474388930, writer);
							return;
						}
						if (num == 476284185)
						{
							this.Serialize356643005((GasoPod)obj, 476284185, writer);
							return;
						}
						if (num != 478713964)
						{
							return;
						}
						this.Serialize478713964((FrozenResource)obj, 478713964, writer);
						return;
					}
				}
				else if (num <= 496960061)
				{
					if (num == 483523761)
					{
						this.Serialize483523761((ColorNameControl)obj, 483523761, writer);
						return;
					}
					if (num == 490474621)
					{
						this.Serialize1585678550((BaseAddPartitionGhost)obj, 490474621, writer);
						return;
					}
					if (num != 496960061)
					{
						return;
					}
					this.Serialize496960061((PrecursorPrisonVent)obj, 496960061, writer);
					return;
				}
				else
				{
					if (num == 497398254)
					{
						this.Serialize497398254((Base.Face)obj, 497398254, writer);
						return;
					}
					if (num == 502247445)
					{
						this.Serialize502247445((StoryGoalCustomEventHandler)obj, 502247445, writer);
						return;
					}
					if (num != 503490010)
					{
						return;
					}
					this.Serialize503490010((MapRoomFunctionality)obj, 503490010, writer);
					return;
				}
			}
			else if (num <= 788408569)
			{
				if (num <= 646820922)
				{
					if (num <= 542223321)
					{
						if (num <= 524780017)
						{
							if (num <= 514291595)
							{
								if (num == 509097267)
								{
									this.Serialize509097267((VentGardenLarge)obj, 509097267, writer);
									return;
								}
								if (num != 514291595)
								{
									return;
								}
								this.Serialize514291595((SeaTruckUpgrades)obj, 514291595, writer);
								return;
							}
							else
							{
								if (num == 515927774)
								{
									this.Serialize2066256250((ColoredLabel)obj, 515927774, writer);
									return;
								}
								if (num == 522953267)
								{
									this.Serialize522953267((WaterPark)obj, 522953267, writer);
									return;
								}
								if (num != 524780017)
								{
									return;
								}
								this.Serialize524780017((KeyValuePair<string, string>)obj, 524780017, writer);
								return;
							}
						}
						else if (num <= 530216075)
						{
							if (num == 524984727)
							{
								this.Serialize524984727((SolarPanel)obj, 524984727, writer);
								return;
							}
							if (num == 526214298)
							{
								this.Serialize356643005((Penguin)obj, 526214298, writer);
								return;
							}
							if (num != 530216075)
							{
								return;
							}
							this.Serialize2066256250((GhostPickupable)obj, 530216075, writer);
							return;
						}
						else
						{
							if (num == 532876397)
							{
								this.Serialize1054395028((WalkingWaterParkCreature)obj, 532876397, writer);
								return;
							}
							if (num == 535540024)
							{
								this.Serialize535540024((BodyTemperature)obj, 535540024, writer);
								return;
							}
							if (num != 542223321)
							{
								return;
							}
							this.Serialize542223321((Plantable)obj, 542223321, writer);
							return;
						}
					}
					else if (num <= 615648120)
					{
						if (num <= 577496260)
						{
							if (num == 569028242)
							{
								this.Serialize569028242((OxygenPipe)obj, 569028242, writer);
								return;
							}
							if (num == 574222852)
							{
								this.Serialize356643005((SeaTreader)obj, 574222852, writer);
								return;
							}
							if (num != 577496260)
							{
								return;
							}
							this.Serialize577496260((LargeWorldEntity)obj, 577496260, writer);
							return;
						}
						else
						{
							if (num == 605020259)
							{
								this.Serialize605020259((Quaternion)obj, 605020259, writer);
								return;
							}
							if (num == 606619525)
							{
								this.Serialize2066256250((Fabricator)obj, 606619525, writer);
								return;
							}
							if (num != 615648120)
							{
								return;
							}
							this.Serialize356643005((SeaMonkey)obj, 615648120, writer);
							return;
						}
					}
					else if (num <= 633495696)
					{
						if (num == 624729416)
						{
							this.Serialize624729416((AnteChamber)obj, 624729416, writer);
							return;
						}
						if (num == 630473610)
						{
							this.Serialize2066256250((GhostCrafter)obj, 630473610, writer);
							return;
						}
						if (num != 633495696)
						{
							return;
						}
						this.Serialize1585678550((BaseAddConnectorGhost)obj, 633495696, writer);
						return;
					}
					else
					{
						if (num == 642877324)
						{
							this.Serialize642877324((Charger)obj, 642877324, writer);
							return;
						}
						if (num == 645269343)
						{
							this.Serialize645269343((Terraformer)obj, 645269343, writer);
							return;
						}
						if (num != 646820922)
						{
							return;
						}
						this.Serialize356643005((Holefish)obj, 646820922, writer);
						return;
					}
				}
				else if (num <= 714689774)
				{
					if (num <= 660968298)
					{
						if (num <= 649861234)
						{
							if (num == 647827065)
							{
								this.Serialize356643005((Spadefish)obj, 647827065, writer);
								return;
							}
							if (num != 649861234)
							{
								return;
							}
							this.Serialize356643005((Biter)obj, 649861234, writer);
							return;
						}
						else
						{
							if (num == 656832482)
							{
								this.Serialize656832482((LeakingRadiation)obj, 656832482, writer);
								return;
							}
							if (num == 658541966)
							{
								this.Serialize658541966((DeployableDrill)obj, 658541966, writer);
								return;
							}
							if (num != 660968298)
							{
								return;
							}
							this.Serialize660968298((CrashHome)obj, 660968298, writer);
							return;
						}
					}
					else if (num <= 682374214)
					{
						if (num == 662718200)
						{
							this.Serialize662718200((DropEnzymes)obj, 662718200, writer);
							return;
						}
						if (num == 670501331)
						{
							this.Serialize2066256250((MedicalCabinet)obj, 670501331, writer);
							return;
						}
						if (num != 682374214)
						{
							return;
						}
						this.Serialize682374214((SoundQueue.Entry)obj, 682374214, writer);
						return;
					}
					else
					{
						if (num == 697741374)
						{
							this.Serialize356643005((Grower)obj, 697741374, writer);
							return;
						}
						if (num == 704466011)
						{
							this.Serialize704466011((ScheduledGoal)obj, 704466011, writer);
							return;
						}
						if (num != 714689774)
						{
							return;
						}
						this.Serialize714689774((KeyValuePair<string, float>)obj, 714689774, writer);
						return;
					}
				}
				else if (num <= 746584541)
				{
					if (num <= 729882159)
					{
						if (num == 723629918)
						{
							this.Serialize2066256250((Pickupable)obj, 723629918, writer);
							return;
						}
						if (num == 728043624)
						{
							this.Serialize728043624((SeaTruckTeleporter)obj, 728043624, writer);
							return;
						}
						if (num != 729882159)
						{
							return;
						}
						this.Serialize729882159((LiveMixin)obj, 729882159, writer);
						return;
					}
					else
					{
						if (num == 730995178)
						{
							this.Serialize2066256250((CreepvineSeed)obj, 730995178, writer);
							return;
						}
						if (num == 737691900)
						{
							this.Serialize2066256250((StarshipDoor)obj, 737691900, writer);
							return;
						}
						if (num != 746584541)
						{
							return;
						}
						this.Serialize746584541((TileInstance)obj, 746584541, writer);
						return;
					}
				}
				else if (num <= 773384208)
				{
					if (num == 769725772)
					{
						this.Serialize769725772((LaserCutObject)obj, 769725772, writer);
						return;
					}
					if (num == 771173439)
					{
						this.Serialize356643005((ArrowRay)obj, 771173439, writer);
						return;
					}
					if (num != 773384208)
					{
						return;
					}
					this.Serialize773384208((AttackLargeTarget)obj, 773384208, writer);
					return;
				}
				else
				{
					if (num == 776720259)
					{
						this.Serialize776720259((FairRandomizer)obj, 776720259, writer);
						return;
					}
					if (num == 787786344)
					{
						this.Serialize2066256250((SupplyDrop)obj, 787786344, writer);
						return;
					}
					if (num != 788408569)
					{
						return;
					}
					this.Serialize642877324((BatteryCharger)obj, 788408569, writer);
					return;
				}
			}
			else if (num <= 882866214)
			{
				if (num <= 829906308)
				{
					if (num <= 802059837)
					{
						if (num <= 792963384)
						{
							if (num == 790665541)
							{
								this.Serialize790665541((Durable)obj, 790665541, writer);
								return;
							}
							if (num != 792963384)
							{
								return;
							}
							this.Serialize2066256250((GrowingPlant)obj, 792963384, writer);
							return;
						}
						else
						{
							if (num == 797173896)
							{
								this.Serialize797173896((PowerGenerator)obj, 797173896, writer);
								return;
							}
							if (num == 801838245)
							{
								this.Serialize801838245((CreatureDeath)obj, 801838245, writer);
								return;
							}
							if (num != 802059837)
							{
								return;
							}
							this.Serialize802059837((Hoverbike)obj, 802059837, writer);
							return;
						}
					}
					else if (num <= 805312304)
					{
						if (num == 802993602)
						{
							this.Serialize2066256250((NuclearReactor)obj, 802993602, writer);
							return;
						}
						if (num == 803494206)
						{
							this.Serialize803494206((ReefbackCreature)obj, 803494206, writer);
							return;
						}
						if (num != 805312304)
						{
							return;
						}
						this.Serialize805312304((LandCreatureGravity)obj, 805312304, writer);
						return;
					}
					else
					{
						if (num == 812739867)
						{
							this.Serialize812739867((CollectShiny)obj, 812739867, writer);
							return;
						}
						if (num == 817046334)
						{
							this.Serialize2066256250((ConstructableBase)obj, 817046334, writer);
							return;
						}
						if (num != 829906308)
						{
							return;
						}
						this.Serialize356643005((BloomCreature)obj, 829906308, writer);
						return;
					}
				}
				else if (num <= 851981872)
				{
					if (num <= 840818195)
					{
						if (num == 836898529)
						{
							this.Serialize356643005((Chelicerate)obj, 836898529, writer);
							return;
						}
						if (num == 837446894)
						{
							this.Serialize837446894((Pipe)obj, 837446894, writer);
							return;
						}
						if (num != 840818195)
						{
							return;
						}
						this.Serialize2066256250((WeldableWallPanelGeneric)obj, 840818195, writer);
						return;
					}
					else
					{
						if (num == 842397654)
						{
							this.Serialize356643005((RockPuncher)obj, 842397654, writer);
							return;
						}
						if (num == 846562516)
						{
							this.Serialize846562516((SaveLoadManager.OptionsCache)obj, 846562516, writer);
							return;
						}
						if (num != 851981872)
						{
							return;
						}
						this.Serialize851981872((PrisonManager)obj, 851981872, writer);
						return;
					}
				}
				else if (num <= 861708591)
				{
					if (num == 859052613)
					{
						this.Serialize859052613((ResourceTrackerDatabase)obj, 859052613, writer);
						return;
					}
					if (num == 860890656)
					{
						this.Serialize860890656((CurrentGenerator)obj, 860890656, writer);
						return;
					}
					if (num != 861708591)
					{
						return;
					}
					this.Serialize356643005((SquidShark)obj, 861708591, writer);
					return;
				}
				else
				{
					if (num == 862251519)
					{
						this.Serialize1585678550((BaseAddModuleGhost)obj, 862251519, writer);
						return;
					}
					if (num == 880630407)
					{
						this.Serialize880630407((AnimatorParameterValue)obj, 880630407, writer);
						return;
					}
					if (num != 882866214)
					{
						return;
					}
					this.Serialize2066256250((BasePipeConnector)obj, 882866214, writer);
					return;
				}
			}
			else if (num <= 955443574)
			{
				if (num <= 916327342)
				{
					if (num <= 890247896)
					{
						if (num == 888605288)
						{
							this.Serialize888605288((Survival)obj, 888605288, writer);
							return;
						}
						if (num != 890247896)
						{
							return;
						}
						this.Serialize890247896((KeyValuePair<string, SceneObjectData>)obj, 890247896, writer);
						return;
					}
					else
					{
						if (num == 892833698)
						{
							this.Serialize892833698((BoxCollider)obj, 892833698, writer);
							return;
						}
						if (num == 898747676)
						{
							this.Serialize898747676((DisableBeforeExplosion)obj, 898747676, writer);
							return;
						}
						if (num != 916327342)
						{
							return;
						}
						this.Serialize916327342((RocketPreflightCheckManager)obj, 916327342, writer);
						return;
					}
				}
				else if (num <= 944362993)
				{
					if (num == 924544622)
					{
						this.Serialize356643005((Reginald)obj, 924544622, writer);
						return;
					}
					if (num == 929691462)
					{
						this.Serialize1427962681((BatterySource)obj, 929691462, writer);
						return;
					}
					if (num != 944362993)
					{
						return;
					}
					this.Serialize944362993((SeaTruckLights)obj, 944362993, writer);
					return;
				}
				else
				{
					if (num == 949139443)
					{
						this.Serialize949139443((CellManager.CellHeaderEx)obj, 949139443, writer);
						return;
					}
					if (num == 953017598)
					{
						this.Serialize356643005((Bladderfish)obj, 953017598, writer);
						return;
					}
					if (num != 955443574)
					{
						return;
					}
					this.Serialize955443574((PipeSurfaceFloater)obj, 955443574, writer);
					return;
				}
			}
			else if (num <= 1012963343)
			{
				if (num <= 1004993247)
				{
					if (num == 997267884)
					{
						this.Serialize997267884((Grid3Shape)obj, 997267884, writer);
						return;
					}
					if (num == 999481743)
					{
						this.Serialize999481743((PrecursorIonCrystal)obj, 999481743, writer);
						return;
					}
					if (num != 1004993247)
					{
						return;
					}
					this.Serialize1004993247((FiltrationMachine)obj, 1004993247, writer);
					return;
				}
				else
				{
					if (num == 1008105993)
					{
						this.Serialize356643005((SnowStalker)obj, 1008105993, writer);
						return;
					}
					if (num == 1011566978)
					{
						this.Serialize2066256250((Bioreactor)obj, 1011566978, writer);
						return;
					}
					if (num != 1012963343)
					{
						return;
					}
					this.Serialize1012963343((BlueprintHandTarget)obj, 1012963343, writer);
					return;
				}
			}
			else if (num <= 1041366111)
			{
				if (num == 1024693509)
				{
					this.Serialize1024693509((Incubator)obj, 1024693509, writer);
					return;
				}
				if (num == 1032585975)
				{
					this.Serialize1032585975((KeypadDoorConsole)obj, 1032585975, writer);
					return;
				}
				if (num != 1041366111)
				{
					return;
				}
				this.Serialize356643005((Bleeder)obj, 1041366111, writer);
				return;
			}
			else
			{
				if (num == 1045809045)
				{
					this.Serialize2066256250((BaseSpotLight)obj, 1045809045, writer);
					return;
				}
				if (num == 1054395028)
				{
					this.Serialize1054395028((WaterParkCreature)obj, 1054395028, writer);
					return;
				}
				if (num != 1056558719)
				{
					return;
				}
				this.Serialize1056558719((OxygenPlant)obj, 1056558719, writer);
				return;
			}
		}
		else if (num <= 1590521044)
		{
			if (num <= 1304741297)
			{
				if (num <= 1159039820)
				{
					if (num <= 1103056798)
					{
						if (num <= 1077102969)
						{
							if (num <= 1059166753)
							{
								if (num == 1058623975)
								{
									this.Serialize356643005((SpineEel)obj, 1058623975, writer);
									return;
								}
								if (num != 1059166753)
								{
									return;
								}
								this.Serialize1059166753((KeypadDoorConsoleUnlock)obj, 1059166753, writer);
								return;
							}
							else
							{
								if (num == 1062675616)
								{
									this.Serialize1062675616((KeyValuePair<string, PDALog.Entry>)obj, 1062675616, writer);
									return;
								}
								if (num == 1070978565)
								{
									this.Serialize356643005((RockGrub)obj, 1070978565, writer);
									return;
								}
								if (num != 1077102969)
								{
									return;
								}
								this.Serialize1077102969((ReefbackLife)obj, 1077102969, writer);
								return;
							}
						}
						else if (num <= 1084867387)
						{
							if (num == 1080881920)
							{
								this.Serialize1080881920((Eatable)obj, 1080881920, writer);
								return;
							}
							if (num == 1082285174)
							{
								this.Serialize356643005((RabbitRay)obj, 1082285174, writer);
								return;
							}
							if (num != 1084867387)
							{
								return;
							}
							this.Serialize2066256250((Sign)obj, 1084867387, writer);
							return;
						}
						else
						{
							if (num == 1086395194)
							{
								this.Serialize1086395194((Sealed)obj, 1086395194, writer);
								return;
							}
							if (num == 1090472122)
							{
								this.Serialize1585678550((BaseAddFaceGhost)obj, 1090472122, writer);
								return;
							}
							if (num != 1103056798)
							{
								return;
							}
							this.Serialize1103056798((CraftingAnalytics.EntryData)obj, 1103056798, writer);
							return;
						}
					}
					else if (num <= 1124891617)
					{
						if (num <= 1116754719)
						{
							if (num == 1111417537)
							{
								this.Serialize1111417537((TimeCapsuleContent)obj, 1111417537, writer);
								return;
							}
							if (num == 1113570486)
							{
								this.Serialize2066256250((Vehicle)obj, 1113570486, writer);
								return;
							}
							if (num != 1116754719)
							{
								return;
							}
							this.Serialize1116754719((KeyValuePair<int, SceneObjectData>)obj, 1116754719, writer);
							return;
						}
						else
						{
							if (num == 1117396675)
							{
								this.Serialize1117396675((AttractedByLargeTarget)obj, 1117396675, writer);
								return;
							}
							if (num == 1124647116)
							{
								this.Serialize356643005((NootFish)obj, 1124647116, writer);
								return;
							}
							if (num != 1124891617)
							{
								return;
							}
							this.Serialize356643005((Peeper)obj, 1124891617, writer);
							return;
						}
					}
					else if (num <= 1151491255)
					{
						if (num == 1127946067)
						{
							this.Serialize1585678550((BaseAddWaterPark)obj, 1127946067, writer);
							return;
						}
						if (num == 1147135728)
						{
							this.Serialize1147135728((BaseName)obj, 1147135728, writer);
							return;
						}
						if (num != 1151491255)
						{
							return;
						}
						this.Serialize356643005((Trivalve)obj, 1151491255, writer);
						return;
					}
					else
					{
						if (num == 1157251956)
						{
							this.Serialize1157251956((SwimToMeat)obj, 1157251956, writer);
							return;
						}
						if (num == 1158933531)
						{
							this.Serialize1158933531((KeyValuePair<TechType, CraftingAnalytics.EntryData>)obj, 1158933531, writer);
							return;
						}
						if (num != 1159039820)
						{
							return;
						}
						this.Serialize1159039820((ProtobufSerializer.GameObjectData)obj, 1159039820, writer);
						return;
					}
				}
				else if (num <= 1191484888)
				{
					if (num <= 1174302959)
					{
						if (num <= 1164389947)
						{
							if (num == 1160243952)
							{
								this.Serialize1160243952((IntroDropshipExplode)obj, 1160243952, writer);
								return;
							}
							if (num != 1164389947)
							{
								return;
							}
							this.Serialize1164389947((Int3.Bounds)obj, 1164389947, writer);
							return;
						}
						else
						{
							if (num == 1169611549)
							{
								this.Serialize1169611549((PrecursorSurfaceVent)obj, 1169611549, writer);
								return;
							}
							if (num == 1170326782)
							{
								this.Serialize2066256250((RocketConstructorInput)obj, 1170326782, writer);
								return;
							}
							if (num != 1174302959)
							{
								return;
							}
							this.Serialize2066256250((Exosuit)obj, 1174302959, writer);
							return;
						}
					}
					else if (num <= 1181346080)
					{
						if (num == 1176920975)
						{
							this.Serialize356643005((CaveCrawler)obj, 1176920975, writer);
							return;
						}
						if (num == 1180542256)
						{
							this.Serialize1180542256((SubRoot)obj, 1180542256, writer);
							return;
						}
						switch (num)
						{
						case 1181346078:
							this.Serialize1181346078((Vector4)obj, 1181346078, writer);
							return;
						case 1181346079:
							this.Serialize1181346079((Vector3)obj, 1181346079, writer);
							return;
						case 1181346080:
							this.Serialize1181346080((Vector2)obj, 1181346080, writer);
							return;
						default:
							return;
						}
					}
					else
					{
						if (num == 1182280616)
						{
							this.Serialize1182280616((Grid3<float>)obj, 1182280616, writer);
							return;
						}
						if (num == 1186708671)
						{
							this.Serialize1186708671((QuantumLocker)obj, 1186708671, writer);
							return;
						}
						if (num != 1191484888)
						{
							return;
						}
						this.Serialize356643005((ShadowLeviathan)obj, 1191484888, writer);
						return;
					}
				}
				else if (num <= 1271521784)
				{
					if (num <= 1244614203)
					{
						if (num == 1234455261)
						{
							this.Serialize356643005((Crash)obj, 1234455261, writer);
							return;
						}
						if (num == 1238042655)
						{
							this.Serialize356643005((ArcticPeeper)obj, 1238042655, writer);
							return;
						}
						if (num != 1244614203)
						{
							return;
						}
						this.Serialize1244614203((PDAEncyclopedia.Entry)obj, 1244614203, writer);
						return;
					}
					else
					{
						if (num == 1249808124)
						{
							this.Serialize1249808124((KeyValuePair<string, TimeCapsuleContent>)obj, 1249808124, writer);
							return;
						}
						if (num == 1252700319)
						{
							this.Serialize356643005((Jumper)obj, 1252700319, writer);
							return;
						}
						if (num != 1271521784)
						{
							return;
						}
						this.Serialize356643005((LilyPaddler)obj, 1271521784, writer);
						return;
					}
				}
				else if (num <= 1287561620)
				{
					if (num == 1273669126)
					{
						this.Serialize1273669126((Rocket)obj, 1273669126, writer);
						return;
					}
					if (num == 1277798743)
					{
						this.Serialize1277798743((SeaMonkeySpawnRandomItem)obj, 1277798743, writer);
						return;
					}
					if (num != 1287561620)
					{
						return;
					}
					this.Serialize356643005((Cryptosuchus)obj, 1287561620, writer);
					return;
				}
				else
				{
					if (num == 1289092887)
					{
						this.Serialize2066256250((PickPrefab)obj, 1289092887, writer);
						return;
					}
					if (num == 1297003913)
					{
						this.Serialize2066256250((UpgradeConsole)obj, 1297003913, writer);
						return;
					}
					if (num != 1304741297)
					{
						return;
					}
					this.Serialize1304741297((MapRoomCameraDocking)obj, 1304741297, writer);
					return;
				}
			}
			else if (num <= 1427962681)
			{
				if (num <= 1364639273)
				{
					if (num <= 1332964068)
					{
						if (num <= 1319564559)
						{
							if (num == 1305740789)
							{
								this.Serialize1305740789((SpyPenguinName)obj, 1305740789, writer);
								return;
							}
							if (num != 1319564559)
							{
								return;
							}
							this.Serialize1319564559((SeamothStorageContainer)obj, 1319564559, writer);
							return;
						}
						else
						{
							if (num == 1327055215)
							{
								this.Serialize356643005((SeaEmperorBaby)obj, 1327055215, writer);
								return;
							}
							if (num == 1329426611)
							{
								this.Serialize1329426611((PDALog.Entry)obj, 1329426611, writer);
								return;
							}
							if (num != 1332964068)
							{
								return;
							}
							this.Serialize356643005((Leviathan)obj, 1332964068, writer);
							return;
						}
					}
					else if (num <= 1340645883)
					{
						if (num == 1333430695)
						{
							this.Serialize2066256250((Workbench)obj, 1333430695, writer);
							return;
						}
						if (num == 1338410882)
						{
							this.Serialize356643005((Jellyray)obj, 1338410882, writer);
							return;
						}
						if (num != 1340645883)
						{
							return;
						}
						this.Serialize1340645883((PrecursorTeleporter)obj, 1340645883, writer);
						return;
					}
					else
					{
						if (num == 1343493277)
						{
							this.Serialize2066256250((MapRoomScreen)obj, 1343493277, writer);
							return;
						}
						if (num == 1355655442)
						{
							this.Serialize356643005((Slime)obj, 1355655442, writer);
							return;
						}
						if (num != 1364639273)
						{
							return;
						}
						this.Serialize1364639273((Light)obj, 1364639273, writer);
						return;
					}
				}
				else if (num <= 1389926401)
				{
					if (num <= 1386031502)
					{
						if (num == 1372467290)
						{
							this.Serialize1372467290((LifepodDrop)obj, 1372467290, writer);
							return;
						}
						if (num == 1384707171)
						{
							this.Serialize1384707171((BaseNuclearReactor)obj, 1384707171, writer);
							return;
						}
						if (num != 1386031502)
						{
							return;
						}
						this.Serialize1386031502((TimeCapsule)obj, 1386031502, writer);
						return;
					}
					else
					{
						if (num == 1386215039)
						{
							this.Serialize356643005((Triops)obj, 1386215039, writer);
							return;
						}
						if (num == 1386435207)
						{
							this.Serialize642877324((PowerCellCharger)obj, 1386435207, writer);
							return;
						}
						if (num != 1389926401)
						{
							return;
						}
						this.Serialize356643005((GhostRay)obj, 1389926401, writer);
						return;
					}
				}
				else if (num <= 1404661584)
				{
					if (num == 1396620629)
					{
						this.Serialize1396620629((GlacialBasinBridgeController)obj, 1396620629, writer);
						return;
					}
					if (num == 1404549125)
					{
						this.Serialize1404549125((EntitySlotData)obj, 1404549125, writer);
						return;
					}
					if (num != 1404661584)
					{
						return;
					}
					this.Serialize1404661584((Color)obj, 1404661584, writer);
					return;
				}
				else
				{
					if (num == 1406047219)
					{
						this.Serialize1585678550((BaseAddPartitionDoorGhost)obj, 1406047219, writer);
						return;
					}
					if (num == 1422648694)
					{
						this.Serialize1585678550((BaseAddMapRoomGhost)obj, 1422648694, writer);
						return;
					}
					if (num != 1427962681)
					{
						return;
					}
					this.Serialize1427962681((EnergyMixin)obj, 1427962681, writer);
					return;
				}
			}
			else if (num <= 1506278612)
			{
				if (num <= 1457388542)
				{
					if (num <= 1433797848)
					{
						if (num == 1430634702)
						{
							this.Serialize1430634702((JointHelper)obj, 1430634702, writer);
							return;
						}
						if (num != 1433797848)
						{
							return;
						}
						this.Serialize1433797848((ExecutionOrderTest)obj, 1433797848, writer);
						return;
					}
					else
					{
						if (num == 1440414490)
						{
							this.Serialize356643005((Stalker)obj, 1440414490, writer);
							return;
						}
						if (num == 1457139245)
						{
							this.Serialize2066256250((PrecursorDisableGunTerminal)obj, 1457139245, writer);
							return;
						}
						if (num != 1457388542)
						{
							return;
						}
						this.Serialize356643005((PenguinBaby)obj, 1457388542, writer);
						return;
					}
				}
				else if (num <= 1489031418)
				{
					if (num == 1469570205)
					{
						this.Serialize1469570205((BaseDeconstructable)obj, 1469570205, writer);
						return;
					}
					if (num == 1488630837)
					{
						this.Serialize1488630837((PDASounds)obj, 1488630837, writer);
						return;
					}
					if (num != 1489031418)
					{
						return;
					}
					this.Serialize1489031418((KeyValuePair<string, bool>)obj, 1489031418, writer);
					return;
				}
				else
				{
					if (num == 1489909791)
					{
						this.Serialize1489909791((CyclopsDecoyLoadingTube)obj, 1489909791, writer);
						return;
					}
					if (num == 1505210158)
					{
						this.Serialize2066256250((PrecursorDoorKeyColumn)obj, 1505210158, writer);
						return;
					}
					if (num != 1506278612)
					{
						return;
					}
					this.Serialize1506278612((StoryGoalScheduler)obj, 1506278612, writer);
					return;
				}
			}
			else if (num <= 1537030892)
			{
				if (num <= 1522229446)
				{
					if (num == 1506893401)
					{
						this.Serialize1585678550((BaseAddCorridorGhost)obj, 1506893401, writer);
						return;
					}
					if (num == 1518696882)
					{
						this.Serialize1518696882((GradientAlphaKey)obj, 1518696882, writer);
						return;
					}
					if (num != 1522229446)
					{
						return;
					}
					this.Serialize1522229446((PowerSource)obj, 1522229446, writer);
					return;
				}
				else
				{
					if (num == 1527139359)
					{
						this.Serialize1527139359((PictureFrame)obj, 1527139359, writer);
						return;
					}
					if (num == 1535225367)
					{
						this.Serialize356643005((Shocker)obj, 1535225367, writer);
						return;
					}
					if (num != 1537030892)
					{
						return;
					}
					this.Serialize1537030892((SubFire)obj, 1537030892, writer);
					return;
				}
			}
			else if (num <= 1555952712)
			{
				if (num == 1537880658)
				{
					this.Serialize1537880658((BaseUpgradeConsole)obj, 1537880658, writer);
					return;
				}
				if (num == 1541346828)
				{
					this.Serialize1541346828((PrecursorComputerTerminal)obj, 1541346828, writer);
					return;
				}
				if (num != 1555952712)
				{
					return;
				}
				this.Serialize2066256250((SupplyCrate)obj, 1555952712, writer);
				return;
			}
			else
			{
				if (num == 1584912799)
				{
					this.Serialize1584912799((BaseBioReactor)obj, 1584912799, writer);
					return;
				}
				if (num == 1585678550)
				{
					this.Serialize1585678550((BaseGhost)obj, 1585678550, writer);
					return;
				}
				if (num != 1590521044)
				{
					return;
				}
				this.Serialize1590521044((CapsuleCollider)obj, 1590521044, writer);
				return;
			}
		}
		else if (num <= 1875862075)
		{
			if (num <= 1725266300)
			{
				if (num <= 1677184373)
				{
					if (num <= 1630308817)
					{
						if (num <= 1606650114)
						{
							if (num == 1603999327)
							{
								this.Serialize1603999327((SunlightSettings)obj, 1603999327, writer);
								return;
							}
							if (num != 1606650114)
							{
								return;
							}
							this.Serialize356643005((SeaDragon)obj, 1606650114, writer);
							return;
						}
						else
						{
							if (num == 1618351061)
							{
								this.Serialize1618351061((FireExtinguisherHolder)obj, 1618351061, writer);
								return;
							}
							if (num == 1624342325)
							{
								this.Serialize1624342325((SeaTruckDockingBay)obj, 1624342325, writer);
								return;
							}
							if (num != 1630308817)
							{
								return;
							}
							this.Serialize356643005((SnowStalkerBaby)obj, 1630308817, writer);
							return;
						}
					}
					else if (num <= 1662769415)
					{
						if (num == 1651949009)
						{
							this.Serialize356643005((Reefback)obj, 1651949009, writer);
							return;
						}
						if (num == 1659399257)
						{
							this.Serialize1659399257((Battery)obj, 1659399257, writer);
							return;
						}
						if (num != 1662769415)
						{
							return;
						}
						this.Serialize1662769415((JukeboxInstance)obj, 1662769415, writer);
						return;
					}
					else
					{
						if (num == 1671198874)
						{
							this.Serialize1671198874((TechLight)obj, 1671198874, writer);
							return;
						}
						if (num == 1675048343)
						{
							this.Serialize1675048343((PlayerWorldArrows)obj, 1675048343, writer);
							return;
						}
						if (num != 1677184373)
						{
							return;
						}
						this.Serialize1677184373((PropulseCannonAmmoHandler)obj, 1677184373, writer);
						return;
					}
				}
				else if (num <= 1711042137)
				{
					if (num <= 1702762571)
					{
						if (num == 1691070576)
						{
							this.Serialize1691070576((Int3)obj, 1691070576, writer);
							return;
						}
						if (num == 1702754208)
						{
							this.Serialize356643005((GlowWhale)obj, 1702754208, writer);
							return;
						}
						if (num != 1702762571)
						{
							return;
						}
						this.Serialize356643005((ReaperLeviathan)obj, 1702762571, writer);
						return;
					}
					else
					{
						if (num == 1703248490)
						{
							this.Serialize1703248490((LavaShell)obj, 1703248490, writer);
							return;
						}
						if (num == 1703576080)
						{
							this.Serialize1703576080((CraftingAnalytics)obj, 1703576080, writer);
							return;
						}
						if (num != 1711042137)
						{
							return;
						}
						this.Serialize356643005((SpinnerFish)obj, 1711042137, writer);
						return;
					}
				}
				else if (num <= 1713660373)
				{
					if (num == 1711377162)
					{
						this.Serialize1711377162((Beacon)obj, 1711377162, writer);
						return;
					}
					if (num == 1711422107)
					{
						this.Serialize1711422107((CrashedShipExploder)obj, 1711422107, writer);
						return;
					}
					if (num != 1713660373)
					{
						return;
					}
					this.Serialize2066256250((PrecursorTeleporterActivationTerminal)obj, 1713660373, writer);
					return;
				}
				else
				{
					if (num == 1716108768)
					{
						this.Serialize1716108768((SeaTruckConnection)obj, 1716108768, writer);
						return;
					}
					if (num == 1716510642)
					{
						this.Serialize356643005((Boomerang)obj, 1716510642, writer);
						return;
					}
					if (num != 1725266300)
					{
						return;
					}
					this.Serialize1725266300((BaseFloodSim)obj, 1725266300, writer);
					return;
				}
			}
			else if (num <= 1800229096)
			{
				if (num <= 1761765682)
				{
					if (num <= 1732754958)
					{
						if (num == 1731663660)
						{
							this.Serialize1731663660((NotificationManager.NotificationId)obj, 1731663660, writer);
							return;
						}
						if (num != 1732754958)
						{
							return;
						}
						this.Serialize1732754958((SignalPing)obj, 1732754958, writer);
						return;
					}
					else
					{
						if (num == 1747546845)
						{
							this.Serialize1747546845((GradientColorKey)obj, 1747546845, writer);
							return;
						}
						if (num == 1761034218)
						{
							this.Serialize1761034218((NitrogenLevel)obj, 1761034218, writer);
							return;
						}
						if (num != 1761765682)
						{
							return;
						}
						this.Serialize1585678550((BaseAddFaceModuleGhost)obj, 1761765682, writer);
						return;
					}
				}
				else if (num <= 1772819529)
				{
					if (num == 1762542304)
					{
						this.Serialize1762542304((SphereCollider)obj, 1762542304, writer);
						return;
					}
					if (num == 1765532648)
					{
						this.Serialize1765532648((Grid3<Vector3>)obj, 1765532648, writer);
						return;
					}
					if (num != 1772819529)
					{
						return;
					}
					this.Serialize1772819529((Breach)obj, 1772819529, writer);
					return;
				}
				else
				{
					if (num == 1793440205)
					{
						this.Serialize522953267((LargeRoomWaterPark)obj, 1793440205, writer);
						return;
					}
					if (num == 1794521971)
					{
						this.Serialize356643005((FeatherFish)obj, 1794521971, writer);
						return;
					}
					if (num != 1800229096)
					{
						return;
					}
					this.Serialize2066256250((PowerCrafter)obj, 1800229096, writer);
					return;
				}
			}
			else if (num <= 1852174394)
			{
				if (num <= 1817260405)
				{
					if (num == 1804294731)
					{
						this.Serialize1804294731((AmbientLightSettings)obj, 1804294731, writer);
						return;
					}
					if (num == 1816388137)
					{
						this.Serialize356643005((Garryfish)obj, 1816388137, writer);
						return;
					}
					if (num != 1817260405)
					{
						return;
					}
					this.Serialize356643005((GhostLeviatanVoid)obj, 1817260405, writer);
					return;
				}
				else
				{
					if (num == 1825589276)
					{
						this.Serialize1825589276((Behaviour)obj, 1825589276, writer);
						return;
					}
					if (num == 1829844631)
					{
						this.Serialize356643005((OculusFish)obj, 1829844631, writer);
						return;
					}
					if (num != 1852174394)
					{
						return;
					}
					this.Serialize1852174394((KeyValuePair<NotificationManager.NotificationId, NotificationManager.NotificationData>)obj, 1852174394, writer);
					return;
				}
			}
			else if (num <= 1859566378)
			{
				if (num == 1855998104)
				{
					this.Serialize1855998104((MapRoomCamera)obj, 1855998104, writer);
					return;
				}
				if (num == 1857674086)
				{
					this.Serialize1585678550((BaseAddWallFoundationGhost)obj, 1857674086, writer);
					return;
				}
				if (num != 1859566378)
				{
					return;
				}
				this.Serialize356643005((Hoverfish)obj, 1859566378, writer);
				return;
			}
			else
			{
				if (num == 1872669462)
				{
					this.Serialize356643005((ArcticRay)obj, 1872669462, writer);
					return;
				}
				if (num == 1874975849)
				{
					this.Serialize1874975849((NotificationManager.NotificationData)obj, 1874975849, writer);
					return;
				}
				if (num != 1875862075)
				{
					return;
				}
				this.Serialize1875862075((Player)obj, 1875862075, writer);
				return;
			}
		}
		else if (num <= 2001815917)
		{
			if (num <= 1941291928)
			{
				if (num <= 1882829928)
				{
					if (num <= 1878920823)
					{
						if (num == 1877364825)
						{
							this.Serialize1877364825((ToggleLights)obj, 1877364825, writer);
							return;
						}
						if (num != 1878920823)
						{
							return;
						}
						this.Serialize1878920823((LargeWorldBatchRoot)obj, 1878920823, writer);
						return;
					}
					else
					{
						if (num == 1880729675)
						{
							this.Serialize356643005((CuteFish)obj, 1880729675, writer);
							return;
						}
						if (num == 1881457915)
						{
							this.Serialize1881457915((SceneObjectData)obj, 1881457915, writer);
							return;
						}
						if (num != 1882829928)
						{
							return;
						}
						this.Serialize356643005((LavaLizard)obj, 1882829928, writer);
						return;
					}
				}
				else if (num <= 1896640149)
				{
					if (num == 1888807148)
					{
						this.Serialize356643005((TitanHolefish)obj, 1888807148, writer);
						return;
					}
					if (num == 1891515754)
					{
						this.Serialize1891515754((UnityEngine.Object)obj, 1891515754, writer);
						return;
					}
					if (num != 1896640149)
					{
						return;
					}
					this.Serialize1585678550((BaseAddBulkheadGhost)obj, 1896640149, writer);
					return;
				}
				else
				{
					if (num == 1921909083)
					{
						this.Serialize356643005((SeaEmperorJuvenile)obj, 1921909083, writer);
						return;
					}
					if (num == 1922274571)
					{
						this.Serialize1922274571((EntitySlot)obj, 1922274571, writer);
						return;
					}
					if (num != 1941291928)
					{
						return;
					}
					this.Serialize356643005((Jellyfish)obj, 1941291928, writer);
					return;
				}
			}
			else if (num <= 1975582319)
			{
				if (num <= 1956492848)
				{
					if (num == 1948869956)
					{
						this.Serialize1948869956((ReefbackPlant)obj, 1948869956, writer);
						return;
					}
					if (num == 1954617231)
					{
						this.Serialize2066256250((DiveReelAnchor)obj, 1954617231, writer);
						return;
					}
					if (num != 1956492848)
					{
						return;
					}
					this.Serialize1956492848((CellManager.CellHeader)obj, 1956492848, writer);
					return;
				}
				else
				{
					if (num == 1966747463)
					{
						this.Serialize1966747463((Base)obj, 1966747463, writer);
						return;
					}
					if (num == 1971823303)
					{
						this.Serialize1971823303((EntitySlotsPlaceholder)obj, 1971823303, writer);
						return;
					}
					if (num != 1975582319)
					{
						return;
					}
					this.Serialize1975582319((Keyframe)obj, 1975582319, writer);
					return;
				}
			}
			else if (num <= 1993981848)
			{
				if (num == 1982063882)
				{
					this.Serialize1982063882((StoryGoalManager)obj, 1982063882, writer);
					return;
				}
				if (num == 1983352738)
				{
					this.Serialize2066256250((ThermalPlant)obj, 1983352738, writer);
					return;
				}
				if (num != 1993981848)
				{
					return;
				}
				this.Serialize1993981848((SpawnStoredLoot)obj, 1993981848, writer);
				return;
			}
			else
			{
				if (num == 1998792992)
				{
					this.Serialize356643005((CrabSnake)obj, 1998792992, writer);
					return;
				}
				if (num == 2000594119)
				{
					this.Serialize2000594119((AmbientSettings)obj, 2000594119, writer);
					return;
				}
				if (num != 2001815917)
				{
					return;
				}
				this.Serialize2001815917((CreatureFriend)obj, 2001815917, writer);
				return;
			}
		}
		else if (num <= 2066256250)
		{
			if (num <= 2039446747)
			{
				if (num <= 2024062491)
				{
					if (num == 2004070125)
					{
						this.Serialize2004070125((InfectedMixin)obj, 2004070125, writer);
						return;
					}
					if (num == 2013353155)
					{
						this.Serialize2013353155((SceneObjectDataSet)obj, 2013353155, writer);
						return;
					}
					if (num != 2024062491)
					{
						return;
					}
					this.Serialize2024062491((RestoreInventoryStorage)obj, 2024062491, writer);
					return;
				}
				else
				{
					if (num == 2028243609)
					{
						this.Serialize2028243609((MonoBehaviour)obj, 2028243609, writer);
						return;
					}
					if (num == 2033371878)
					{
						this.Serialize356643005((Grabcrab)obj, 2033371878, writer);
						return;
					}
					if (num != 2039446747)
					{
						return;
					}
					this.Serialize2039446747((BaseControlRoomModule)obj, 2039446747, writer);
					return;
				}
			}
			else if (num <= 2054867230)
			{
				if (num == 2044575597)
				{
					this.Serialize2044575597((TimeCapsuleItem)obj, 2044575597, writer);
					return;
				}
				if (num == 2051895012)
				{
					this.Serialize2066256250((PrecursorKeyTerminal)obj, 2051895012, writer);
					return;
				}
				if (num != 2054867230)
				{
					return;
				}
				this.Serialize2054867230((ResearchBase)obj, 2054867230, writer);
				return;
			}
			else
			{
				if (num == 2060501761)
				{
					this.Serialize1585678550((BaseAddLadderGhost)obj, 2060501761, writer);
					return;
				}
				if (num == 2062152363)
				{
					this.Serialize2062152363((CyclopsMotorMode)obj, 2062152363, writer);
					return;
				}
				if (num != 2066256250)
				{
					return;
				}
				this.Serialize2066256250((HandTarget)obj, 2066256250, writer);
				return;
			}
		}
		else if (num <= 2100518191)
		{
			if (num <= 2092842303)
			{
				if (num == 2078931521)
				{
					this.Serialize2078931521((MobileExtractorMachine)obj, 2078931521, writer);
					return;
				}
				if (num == 2083308735)
				{
					this.Serialize2083308735((CyclopsLightingPanel)obj, 2083308735, writer);
					return;
				}
				if (num != 2092842303)
				{
					return;
				}
				this.Serialize2092842303((Thumper)obj, 2092842303, writer);
				return;
			}
			else
			{
				if (num == 2093360837)
				{
					this.Serialize356643005((Brinewing)obj, 2093360837, writer);
					return;
				}
				if (num == 2100222829)
				{
					this.Serialize2100222829((CrafterLogic)obj, 2100222829, writer);
					return;
				}
				if (num != 2100518191)
				{
					return;
				}
				this.Serialize2100518191((Drillable)obj, 2100518191, writer);
				return;
			}
		}
		else if (num <= 2111234577)
		{
			if (num == 2104816441)
			{
				this.Serialize2104816441((TeleporterManager)obj, 2104816441, writer);
				return;
			}
			if (num == 2106147891)
			{
				this.Serialize2066256250((SeaMoth)obj, 2106147891, writer);
				return;
			}
			if (num != 2111234577)
			{
				return;
			}
			this.Serialize2111234577((PrefabPlaceholdersGroup)obj, 2111234577, writer);
			return;
		}
		else
		{
			if (num == 2124310223)
			{
				this.Serialize2124310223((VFXConstructing)obj, 2124310223, writer);
				return;
			}
			if (num == 2137760429)
			{
				this.Serialize2137760429((PDAScanner.Data)obj, 2137760429, writer);
				return;
			}
			if (num != 2146397475)
			{
				return;
			}
			this.Serialize2146397475((BaseCell)obj, 2146397475, writer);
			return;
		}
	}

	protected override object Deserialize(int num, object obj, ProtoReader reader)
	{
		if (num <= 1056558719)
		{
			if (num <= 503490010)
			{
				if (num <= 252526906)
				{
					if (num <= 122249312)
					{
						if (num <= 42492657)
						{
							if (num <= 10881664)
							{
								if (num <= 3219972)
								{
									if (num == 1640880)
									{
										return this.Deserialize356643005((SeaMonkeyBaby)obj, reader);
									}
									if (num == 3219972)
									{
										return this.Deserialize356643005((SymbioteFish)obj, reader);
									}
								}
								else
								{
									if (num == 7443242)
									{
										return this.Deserialize7443242((AnalyticsController)obj, reader);
									}
									if (num == 10406022)
									{
										return this.Deserialize10406022((PlayerSoundTrigger)obj, reader);
									}
									if (num == 10881664)
									{
										return this.Deserialize10881664((DiveReel)obj, reader);
									}
								}
							}
							else if (num <= 35332337)
							{
								if (num == 11492366)
								{
									return this.Deserialize11492366((Respawn)obj, reader);
								}
								if (num == 26260290)
								{
									return this.Deserialize26260290((DayNightLight)obj, reader);
								}
								if (num == 35332337)
								{
									return this.Deserialize356643005((GhostLeviathan)obj, reader);
								}
							}
							else
							{
								if (num == 40841636)
								{
									return this.Deserialize356643005((BirdBehaviour)obj, reader);
								}
								if (num == 41335609)
								{
									return this.Deserialize41335609((FruitPlant)obj, reader);
								}
								if (num == 42492657)
								{
									return this.Deserialize356643005((BruteShark)obj, reader);
								}
							}
						}
						else if (num <= 81014147)
						{
							if (num <= 59821228)
							{
								if (num == 49368518)
								{
									return this.Deserialize356643005((CrabSquid)obj, reader);
								}
								if (num == 51037994)
								{
									return this.Deserialize51037994((Inventory)obj, reader);
								}
								if (num == 59821228)
								{
									return this.Deserialize59821228((CreatureEgg)obj, reader);
								}
							}
							else
							{
								if (num == 69304398)
								{
									return this.Deserialize69304398((ProtobufSerializer.LoopHeader)obj, reader);
								}
								if (num == 72619689)
								{
									return this.Deserialize72619689((Collider)obj, reader);
								}
								if (num == 81014147)
								{
									return this.Deserialize356643005((SandShark)obj, reader);
								}
							}
						}
						else if (num <= 113236186)
						{
							if (num == 82819465)
							{
								return this.Deserialize82819465((Roost)obj, reader);
							}
							if (num == 108625815)
							{
								return this.Deserialize108625815((FogSettings)obj, reader);
							}
							if (num == 113236186)
							{
								return this.Deserialize2066256250((GrownPlant)obj, reader);
							}
						}
						else
						{
							if (num == 118512508)
							{
								return this.Deserialize118512508((AnimationCurve)obj, reader);
							}
							if (num == 121008834)
							{
								return this.Deserialize121008834((KeyValuePair<string, PDAEncyclopedia.Entry>)obj, reader);
							}
							if (num == 122249312)
							{
								return this.Deserialize122249312((LargeWorldEntityCell)obj, reader);
							}
						}
					}
					else if (num <= 205226061)
					{
						if (num <= 160169329)
						{
							if (num <= 135876261)
							{
								if (num == 123477383)
								{
									return this.Deserialize356643005((Mesmer)obj, reader);
								}
								if (num == 135876261)
								{
									return this.Deserialize2066256250((Crafter)obj, reader);
								}
							}
							else
							{
								if (num == 149935601)
								{
									return this.Deserialize149935601((Transform)obj, reader);
								}
								if (num == 153467737)
								{
									return this.Deserialize153467737((CellManager.CellsFileHeader)obj, reader);
								}
								if (num == 160169329)
								{
									return this.Deserialize160169329((WeatherManager)obj, reader);
								}
							}
						}
						else if (num <= 185046565)
						{
							if (num == 161874211)
							{
								return this.Deserialize161874211((ResourceTrackerDatabase.ResourceInfo)obj, reader);
							}
							if (num == 175529349)
							{
								return this.Deserialize175529349((Gradient)obj, reader);
							}
							if (num == 185046565)
							{
								return this.Deserialize185046565((PrecursorElevator)obj, reader);
							}
						}
						else
						{
							if (num == 190681690)
							{
								return this.Deserialize190681690((Oxygen)obj, reader);
							}
							if (num == 200911463)
							{
								return this.Deserialize200911463((LEDLight)obj, reader);
							}
							if (num == 205226061)
							{
								return this.Deserialize205226061((Dockable)obj, reader);
							}
						}
					}
					else if (num <= 236473635)
					{
						if (num <= 217879716)
						{
							if (num == 205484837)
							{
								return this.Deserialize205484837((PingInstance)obj, reader);
							}
							if (num == 212928398)
							{
								return this.Deserialize212928398((TechFragment)obj, reader);
							}
							if (num == 217879716)
							{
								return this.Deserialize217879716((ProtobufSerializer.StreamHeader)obj, reader);
							}
						}
						else
						{
							if (num == 224877162)
							{
								return this.Deserialize224877162((KeyValuePair<string, int>)obj, reader);
							}
							if (num == 225324449)
							{
								return this.Deserialize225324449((SwimRandom)obj, reader);
							}
							if (num == 236473635)
							{
								return this.Deserialize356643005((DiscusFish)obj, reader);
							}
						}
					}
					else if (num <= 242125589)
					{
						if (num == 237257528)
						{
							return this.Deserialize237257528((CoffeeMachineLegacy)obj, reader);
						}
						if (num == 239375628)
						{
							return this.Deserialize239375628((AtmosphereVolume)obj, reader);
						}
						if (num == 242125589)
						{
							return this.Deserialize242125589((Stillsuit)obj, reader);
						}
					}
					else
					{
						if (num == 242904679)
						{
							return this.Deserialize356643005((BoneShark)obj, reader);
						}
						if (num == 248259089)
						{
							return this.Deserialize248259089((PDAScanner.Entry)obj, reader);
						}
						if (num == 252526906)
						{
							return this.Deserialize356643005((VoidLeviathan)obj, reader);
						}
					}
				}
				else if (num <= 356984973)
				{
					if (num <= 315488296)
					{
						if (num <= 289177516)
						{
							if (num <= 257036954)
							{
								if (num == 253947874)
								{
									return this.Deserialize253947874((RestoreAnimatorState)obj, reader);
								}
								if (num == 257036954)
								{
									return this.Deserialize2066256250((ConstructorInput)obj, reader);
								}
							}
							else
							{
								if (num == 273953122)
								{
									return this.Deserialize273953122((RestoreDayNightCycle)obj, reader);
								}
								if (num == 285680569)
								{
									return this.Deserialize285680569((PrecursorGunStoryEvents)obj, reader);
								}
								if (num == 289177516)
								{
									return this.Deserialize289177516((Int3Class)obj, reader);
								}
							}
						}
						else if (num <= 309711119)
						{
							if (num == 294226815)
							{
								return this.Deserialize294226815((SeaTruckMotor)obj, reader);
							}
							if (num == 304513582)
							{
								return this.Deserialize304513582((global::Flare)obj, reader);
							}
							if (num == 309711119)
							{
								return this.Deserialize2066256250((PrecursorPartFabricator)obj, reader);
							}
						}
						else
						{
							if (num == 311542795)
							{
								return this.Deserialize1180542256((BaseRoot)obj, reader);
							}
							if (num == 313352173)
							{
								return this.Deserialize313352173((ProtobufSerializer.ComponentHeader)obj, reader);
							}
							if (num == 315488296)
							{
								return this.Deserialize315488296((DayNightCycle)obj, reader);
							}
						}
					}
					else if (num <= 331658349)
					{
						if (num <= 328142573)
						{
							if (num == 325421431)
							{
								return this.Deserialize325421431((FireExtinguisher)obj, reader);
							}
							if (num == 326697518)
							{
								return this.Deserialize326697518((Constructor)obj, reader);
							}
							if (num == 328142573)
							{
								return this.Deserialize328142573((ProtobufSerializerCornerCases)obj, reader);
							}
						}
						else
						{
							if (num == 328683587)
							{
								return this.Deserialize356643005((Warper)obj, reader);
							}
							if (num == 328727906)
							{
								return this.Deserialize356643005((Hoopfish)obj, reader);
							}
							if (num == 331658349)
							{
								return this.Deserialize331658349((FixedBase)obj, reader);
							}
						}
					}
					else if (num <= 351821017)
					{
						if (num == 348559960)
						{
							return this.Deserialize348559960((NotificationManager.SerializedData)obj, reader);
						}
						if (num == 350666384)
						{
							return this.Deserialize350666384((SoundQueue)obj, reader);
						}
						if (num == 351821017)
						{
							return this.Deserialize356643005((Eyeye)obj, reader);
						}
					}
					else
					{
						if (num == 353579366)
						{
							return this.Deserialize356643005((LavaLarva)obj, reader);
						}
						if (num == 356643005)
						{
							return this.Deserialize356643005((Creature)obj, reader);
						}
						if (num == 356984973)
						{
							return this.Deserialize356984973((PrecursorAquariumPlatformTrigger)obj, reader);
						}
					}
				}
				else if (num <= 424968344)
				{
					if (num <= 391689956)
					{
						if (num <= 371084514)
						{
							if (num == 366077262)
							{
								return this.Deserialize2066256250((StorageContainer)obj, reader);
							}
							if (num == 371084514)
							{
								return this.Deserialize371084514((BaseExplicitFace)obj, reader);
							}
						}
						else
						{
							if (num == 383673295)
							{
								return this.Deserialize1585678550((BaseAddCellGhost)obj, reader);
							}
							if (num == 387767963)
							{
								return this.Deserialize387767963((ExchangerRocketConstructor)obj, reader);
							}
							if (num == 391689956)
							{
								return this.Deserialize391689956((Bounds)obj, reader);
							}
						}
					}
					else if (num <= 406373562)
					{
						if (num == 394322812)
						{
							return this.Deserialize394322812((Component)obj, reader);
						}
						if (num == 396637907)
						{
							return this.Deserialize2066256250((Constructable)obj, reader);
						}
						if (num == 406373562)
						{
							return this.Deserialize406373562((CreatureBehaviour)obj, reader);
						}
					}
					else
					{
						if (num == 407275749)
						{
							return this.Deserialize407275749((PlayerTimeCapsule)obj, reader);
						}
						if (num == 414351131)
						{
							return this.Deserialize356643005((Pinnacarid)obj, reader);
						}
						if (num == 424968344)
						{
							return this.Deserialize424968344((PlayerLilyPaddlerHypnosis)obj, reader);
						}
					}
				}
				else if (num <= 478713964)
				{
					if (num <= 469144263)
					{
						if (num == 438265826)
						{
							return this.Deserialize438265826((UnstuckPlayer)obj, reader);
						}
						if (num == 459225532)
						{
							return this.Deserialize459225532((GenericConsole)obj, reader);
						}
						if (num == 469144263)
						{
							return this.Deserialize356643005((Skyray)obj, reader);
						}
					}
					else
					{
						if (num == 474388930)
						{
							return this.Deserialize474388930((ItemExchanger)obj, reader);
						}
						if (num == 476284185)
						{
							return this.Deserialize356643005((GasoPod)obj, reader);
						}
						if (num == 478713964)
						{
							return this.Deserialize478713964((FrozenResource)obj, reader);
						}
					}
				}
				else if (num <= 496960061)
				{
					if (num == 483523761)
					{
						return this.Deserialize483523761((ColorNameControl)obj, reader);
					}
					if (num == 490474621)
					{
						return this.Deserialize1585678550((BaseAddPartitionGhost)obj, reader);
					}
					if (num == 496960061)
					{
						return this.Deserialize496960061((PrecursorPrisonVent)obj, reader);
					}
				}
				else
				{
					if (num == 497398254)
					{
						return this.Deserialize497398254((Base.Face)obj, reader);
					}
					if (num == 502247445)
					{
						return this.Deserialize502247445((StoryGoalCustomEventHandler)obj, reader);
					}
					if (num == 503490010)
					{
						return this.Deserialize503490010((MapRoomFunctionality)obj, reader);
					}
				}
			}
			else if (num <= 788408569)
			{
				if (num <= 646820922)
				{
					if (num <= 542223321)
					{
						if (num <= 524780017)
						{
							if (num <= 514291595)
							{
								if (num == 509097267)
								{
									return this.Deserialize509097267((VentGardenLarge)obj, reader);
								}
								if (num == 514291595)
								{
									return this.Deserialize514291595((SeaTruckUpgrades)obj, reader);
								}
							}
							else
							{
								if (num == 515927774)
								{
									return this.Deserialize2066256250((ColoredLabel)obj, reader);
								}
								if (num == 522953267)
								{
									return this.Deserialize522953267((WaterPark)obj, reader);
								}
								if (num == 524780017)
								{
									return this.Deserialize524780017((KeyValuePair<string, string>)obj, reader);
								}
							}
						}
						else if (num <= 530216075)
						{
							if (num == 524984727)
							{
								return this.Deserialize524984727((SolarPanel)obj, reader);
							}
							if (num == 526214298)
							{
								return this.Deserialize356643005((Penguin)obj, reader);
							}
							if (num == 530216075)
							{
								return this.Deserialize2066256250((GhostPickupable)obj, reader);
							}
						}
						else
						{
							if (num == 532876397)
							{
								return this.Deserialize1054395028((WalkingWaterParkCreature)obj, reader);
							}
							if (num == 535540024)
							{
								return this.Deserialize535540024((BodyTemperature)obj, reader);
							}
							if (num == 542223321)
							{
								return this.Deserialize542223321((Plantable)obj, reader);
							}
						}
					}
					else if (num <= 615648120)
					{
						if (num <= 577496260)
						{
							if (num == 569028242)
							{
								return this.Deserialize569028242((OxygenPipe)obj, reader);
							}
							if (num == 574222852)
							{
								return this.Deserialize356643005((SeaTreader)obj, reader);
							}
							if (num == 577496260)
							{
								return this.Deserialize577496260((LargeWorldEntity)obj, reader);
							}
						}
						else
						{
							if (num == 605020259)
							{
								return this.Deserialize605020259((Quaternion)obj, reader);
							}
							if (num == 606619525)
							{
								return this.Deserialize2066256250((Fabricator)obj, reader);
							}
							if (num == 615648120)
							{
								return this.Deserialize356643005((SeaMonkey)obj, reader);
							}
						}
					}
					else if (num <= 633495696)
					{
						if (num == 624729416)
						{
							return this.Deserialize624729416((AnteChamber)obj, reader);
						}
						if (num == 630473610)
						{
							return this.Deserialize2066256250((GhostCrafter)obj, reader);
						}
						if (num == 633495696)
						{
							return this.Deserialize1585678550((BaseAddConnectorGhost)obj, reader);
						}
					}
					else
					{
						if (num == 642877324)
						{
							return this.Deserialize642877324((Charger)obj, reader);
						}
						if (num == 645269343)
						{
							return this.Deserialize645269343((Terraformer)obj, reader);
						}
						if (num == 646820922)
						{
							return this.Deserialize356643005((Holefish)obj, reader);
						}
					}
				}
				else if (num <= 714689774)
				{
					if (num <= 660968298)
					{
						if (num <= 649861234)
						{
							if (num == 647827065)
							{
								return this.Deserialize356643005((Spadefish)obj, reader);
							}
							if (num == 649861234)
							{
								return this.Deserialize356643005((Biter)obj, reader);
							}
						}
						else
						{
							if (num == 656832482)
							{
								return this.Deserialize656832482((LeakingRadiation)obj, reader);
							}
							if (num == 658541966)
							{
								return this.Deserialize658541966((DeployableDrill)obj, reader);
							}
							if (num == 660968298)
							{
								return this.Deserialize660968298((CrashHome)obj, reader);
							}
						}
					}
					else if (num <= 682374214)
					{
						if (num == 662718200)
						{
							return this.Deserialize662718200((DropEnzymes)obj, reader);
						}
						if (num == 670501331)
						{
							return this.Deserialize2066256250((MedicalCabinet)obj, reader);
						}
						if (num == 682374214)
						{
							return this.Deserialize682374214((SoundQueue.Entry)obj, reader);
						}
					}
					else
					{
						if (num == 697741374)
						{
							return this.Deserialize356643005((Grower)obj, reader);
						}
						if (num == 704466011)
						{
							return this.Deserialize704466011((ScheduledGoal)obj, reader);
						}
						if (num == 714689774)
						{
							return this.Deserialize714689774((KeyValuePair<string, float>)obj, reader);
						}
					}
				}
				else if (num <= 746584541)
				{
					if (num <= 729882159)
					{
						if (num == 723629918)
						{
							return this.Deserialize2066256250((Pickupable)obj, reader);
						}
						if (num == 728043624)
						{
							return this.Deserialize728043624((SeaTruckTeleporter)obj, reader);
						}
						if (num == 729882159)
						{
							return this.Deserialize729882159((LiveMixin)obj, reader);
						}
					}
					else
					{
						if (num == 730995178)
						{
							return this.Deserialize2066256250((CreepvineSeed)obj, reader);
						}
						if (num == 737691900)
						{
							return this.Deserialize2066256250((StarshipDoor)obj, reader);
						}
						if (num == 746584541)
						{
							return this.Deserialize746584541((TileInstance)obj, reader);
						}
					}
				}
				else if (num <= 773384208)
				{
					if (num == 769725772)
					{
						return this.Deserialize769725772((LaserCutObject)obj, reader);
					}
					if (num == 771173439)
					{
						return this.Deserialize356643005((ArrowRay)obj, reader);
					}
					if (num == 773384208)
					{
						return this.Deserialize773384208((AttackLargeTarget)obj, reader);
					}
				}
				else
				{
					if (num == 776720259)
					{
						return this.Deserialize776720259((FairRandomizer)obj, reader);
					}
					if (num == 787786344)
					{
						return this.Deserialize2066256250((SupplyDrop)obj, reader);
					}
					if (num == 788408569)
					{
						return this.Deserialize642877324((BatteryCharger)obj, reader);
					}
				}
			}
			else if (num <= 882866214)
			{
				if (num <= 829906308)
				{
					if (num <= 802059837)
					{
						if (num <= 792963384)
						{
							if (num == 790665541)
							{
								return this.Deserialize790665541((Durable)obj, reader);
							}
							if (num == 792963384)
							{
								return this.Deserialize2066256250((GrowingPlant)obj, reader);
							}
						}
						else
						{
							if (num == 797173896)
							{
								return this.Deserialize797173896((PowerGenerator)obj, reader);
							}
							if (num == 801838245)
							{
								return this.Deserialize801838245((CreatureDeath)obj, reader);
							}
							if (num == 802059837)
							{
								return this.Deserialize802059837((Hoverbike)obj, reader);
							}
						}
					}
					else if (num <= 805312304)
					{
						if (num == 802993602)
						{
							return this.Deserialize2066256250((NuclearReactor)obj, reader);
						}
						if (num == 803494206)
						{
							return this.Deserialize803494206((ReefbackCreature)obj, reader);
						}
						if (num == 805312304)
						{
							return this.Deserialize805312304((LandCreatureGravity)obj, reader);
						}
					}
					else
					{
						if (num == 812739867)
						{
							return this.Deserialize812739867((CollectShiny)obj, reader);
						}
						if (num == 817046334)
						{
							return this.Deserialize2066256250((ConstructableBase)obj, reader);
						}
						if (num == 829906308)
						{
							return this.Deserialize356643005((BloomCreature)obj, reader);
						}
					}
				}
				else if (num <= 851981872)
				{
					if (num <= 840818195)
					{
						if (num == 836898529)
						{
							return this.Deserialize356643005((Chelicerate)obj, reader);
						}
						if (num == 837446894)
						{
							return this.Deserialize837446894((Pipe)obj, reader);
						}
						if (num == 840818195)
						{
							return this.Deserialize2066256250((WeldableWallPanelGeneric)obj, reader);
						}
					}
					else
					{
						if (num == 842397654)
						{
							return this.Deserialize356643005((RockPuncher)obj, reader);
						}
						if (num == 846562516)
						{
							return this.Deserialize846562516((SaveLoadManager.OptionsCache)obj, reader);
						}
						if (num == 851981872)
						{
							return this.Deserialize851981872((PrisonManager)obj, reader);
						}
					}
				}
				else if (num <= 861708591)
				{
					if (num == 859052613)
					{
						return this.Deserialize859052613((ResourceTrackerDatabase)obj, reader);
					}
					if (num == 860890656)
					{
						return this.Deserialize860890656((CurrentGenerator)obj, reader);
					}
					if (num == 861708591)
					{
						return this.Deserialize356643005((SquidShark)obj, reader);
					}
				}
				else
				{
					if (num == 862251519)
					{
						return this.Deserialize1585678550((BaseAddModuleGhost)obj, reader);
					}
					if (num == 880630407)
					{
						return this.Deserialize880630407((AnimatorParameterValue)obj, reader);
					}
					if (num == 882866214)
					{
						return this.Deserialize2066256250((BasePipeConnector)obj, reader);
					}
				}
			}
			else if (num <= 955443574)
			{
				if (num <= 916327342)
				{
					if (num <= 890247896)
					{
						if (num == 888605288)
						{
							return this.Deserialize888605288((Survival)obj, reader);
						}
						if (num == 890247896)
						{
							return this.Deserialize890247896((KeyValuePair<string, SceneObjectData>)obj, reader);
						}
					}
					else
					{
						if (num == 892833698)
						{
							return this.Deserialize892833698((BoxCollider)obj, reader);
						}
						if (num == 898747676)
						{
							return this.Deserialize898747676((DisableBeforeExplosion)obj, reader);
						}
						if (num == 916327342)
						{
							return this.Deserialize916327342((RocketPreflightCheckManager)obj, reader);
						}
					}
				}
				else if (num <= 944362993)
				{
					if (num == 924544622)
					{
						return this.Deserialize356643005((Reginald)obj, reader);
					}
					if (num == 929691462)
					{
						return this.Deserialize1427962681((BatterySource)obj, reader);
					}
					if (num == 944362993)
					{
						return this.Deserialize944362993((SeaTruckLights)obj, reader);
					}
				}
				else
				{
					if (num == 949139443)
					{
						return this.Deserialize949139443((CellManager.CellHeaderEx)obj, reader);
					}
					if (num == 953017598)
					{
						return this.Deserialize356643005((Bladderfish)obj, reader);
					}
					if (num == 955443574)
					{
						return this.Deserialize955443574((PipeSurfaceFloater)obj, reader);
					}
				}
			}
			else if (num <= 1012963343)
			{
				if (num <= 1004993247)
				{
					if (num == 997267884)
					{
						return this.Deserialize997267884((Grid3Shape)obj, reader);
					}
					if (num == 999481743)
					{
						return this.Deserialize999481743((PrecursorIonCrystal)obj, reader);
					}
					if (num == 1004993247)
					{
						return this.Deserialize1004993247((FiltrationMachine)obj, reader);
					}
				}
				else
				{
					if (num == 1008105993)
					{
						return this.Deserialize356643005((SnowStalker)obj, reader);
					}
					if (num == 1011566978)
					{
						return this.Deserialize2066256250((Bioreactor)obj, reader);
					}
					if (num == 1012963343)
					{
						return this.Deserialize1012963343((BlueprintHandTarget)obj, reader);
					}
				}
			}
			else if (num <= 1041366111)
			{
				if (num == 1024693509)
				{
					return this.Deserialize1024693509((Incubator)obj, reader);
				}
				if (num == 1032585975)
				{
					return this.Deserialize1032585975((KeypadDoorConsole)obj, reader);
				}
				if (num == 1041366111)
				{
					return this.Deserialize356643005((Bleeder)obj, reader);
				}
			}
			else
			{
				if (num == 1045809045)
				{
					return this.Deserialize2066256250((BaseSpotLight)obj, reader);
				}
				if (num == 1054395028)
				{
					return this.Deserialize1054395028((WaterParkCreature)obj, reader);
				}
				if (num == 1056558719)
				{
					return this.Deserialize1056558719((OxygenPlant)obj, reader);
				}
			}
		}
		else if (num <= 1590521044)
		{
			if (num <= 1304741297)
			{
				if (num <= 1159039820)
				{
					if (num <= 1103056798)
					{
						if (num <= 1077102969)
						{
							if (num <= 1059166753)
							{
								if (num == 1058623975)
								{
									return this.Deserialize356643005((SpineEel)obj, reader);
								}
								if (num == 1059166753)
								{
									return this.Deserialize1059166753((KeypadDoorConsoleUnlock)obj, reader);
								}
							}
							else
							{
								if (num == 1062675616)
								{
									return this.Deserialize1062675616((KeyValuePair<string, PDALog.Entry>)obj, reader);
								}
								if (num == 1070978565)
								{
									return this.Deserialize356643005((RockGrub)obj, reader);
								}
								if (num == 1077102969)
								{
									return this.Deserialize1077102969((ReefbackLife)obj, reader);
								}
							}
						}
						else if (num <= 1084867387)
						{
							if (num == 1080881920)
							{
								return this.Deserialize1080881920((Eatable)obj, reader);
							}
							if (num == 1082285174)
							{
								return this.Deserialize356643005((RabbitRay)obj, reader);
							}
							if (num == 1084867387)
							{
								return this.Deserialize2066256250((Sign)obj, reader);
							}
						}
						else
						{
							if (num == 1086395194)
							{
								return this.Deserialize1086395194((Sealed)obj, reader);
							}
							if (num == 1090472122)
							{
								return this.Deserialize1585678550((BaseAddFaceGhost)obj, reader);
							}
							if (num == 1103056798)
							{
								return this.Deserialize1103056798((CraftingAnalytics.EntryData)obj, reader);
							}
						}
					}
					else if (num <= 1124891617)
					{
						if (num <= 1116754719)
						{
							if (num == 1111417537)
							{
								return this.Deserialize1111417537((TimeCapsuleContent)obj, reader);
							}
							if (num == 1113570486)
							{
								return this.Deserialize2066256250((Vehicle)obj, reader);
							}
							if (num == 1116754719)
							{
								return this.Deserialize1116754719((KeyValuePair<int, SceneObjectData>)obj, reader);
							}
						}
						else
						{
							if (num == 1117396675)
							{
								return this.Deserialize1117396675((AttractedByLargeTarget)obj, reader);
							}
							if (num == 1124647116)
							{
								return this.Deserialize356643005((NootFish)obj, reader);
							}
							if (num == 1124891617)
							{
								return this.Deserialize356643005((Peeper)obj, reader);
							}
						}
					}
					else if (num <= 1151491255)
					{
						if (num == 1127946067)
						{
							return this.Deserialize1585678550((BaseAddWaterPark)obj, reader);
						}
						if (num == 1147135728)
						{
							return this.Deserialize1147135728((BaseName)obj, reader);
						}
						if (num == 1151491255)
						{
							return this.Deserialize356643005((Trivalve)obj, reader);
						}
					}
					else
					{
						if (num == 1157251956)
						{
							return this.Deserialize1157251956((SwimToMeat)obj, reader);
						}
						if (num == 1158933531)
						{
							return this.Deserialize1158933531((KeyValuePair<TechType, CraftingAnalytics.EntryData>)obj, reader);
						}
						if (num == 1159039820)
						{
							return this.Deserialize1159039820((ProtobufSerializer.GameObjectData)obj, reader);
						}
					}
				}
				else if (num <= 1191484888)
				{
					if (num <= 1174302959)
					{
						if (num <= 1164389947)
						{
							if (num == 1160243952)
							{
								return this.Deserialize1160243952((IntroDropshipExplode)obj, reader);
							}
							if (num == 1164389947)
							{
								return this.Deserialize1164389947((Int3.Bounds)obj, reader);
							}
						}
						else
						{
							if (num == 1169611549)
							{
								return this.Deserialize1169611549((PrecursorSurfaceVent)obj, reader);
							}
							if (num == 1170326782)
							{
								return this.Deserialize2066256250((RocketConstructorInput)obj, reader);
							}
							if (num == 1174302959)
							{
								return this.Deserialize2066256250((Exosuit)obj, reader);
							}
						}
					}
					else if (num <= 1181346080)
					{
						if (num == 1176920975)
						{
							return this.Deserialize356643005((CaveCrawler)obj, reader);
						}
						if (num == 1180542256)
						{
							return this.Deserialize1180542256((SubRoot)obj, reader);
						}
						switch (num)
						{
						case 1181346078:
							return this.Deserialize1181346078((Vector4)obj, reader);
						case 1181346079:
							return this.Deserialize1181346079((Vector3)obj, reader);
						case 1181346080:
							return this.Deserialize1181346080((Vector2)obj, reader);
						}
					}
					else
					{
						if (num == 1182280616)
						{
							return this.Deserialize1182280616((Grid3<float>)obj, reader);
						}
						if (num == 1186708671)
						{
							return this.Deserialize1186708671((QuantumLocker)obj, reader);
						}
						if (num == 1191484888)
						{
							return this.Deserialize356643005((ShadowLeviathan)obj, reader);
						}
					}
				}
				else if (num <= 1271521784)
				{
					if (num <= 1244614203)
					{
						if (num == 1234455261)
						{
							return this.Deserialize356643005((Crash)obj, reader);
						}
						if (num == 1238042655)
						{
							return this.Deserialize356643005((ArcticPeeper)obj, reader);
						}
						if (num == 1244614203)
						{
							return this.Deserialize1244614203((PDAEncyclopedia.Entry)obj, reader);
						}
					}
					else
					{
						if (num == 1249808124)
						{
							return this.Deserialize1249808124((KeyValuePair<string, TimeCapsuleContent>)obj, reader);
						}
						if (num == 1252700319)
						{
							return this.Deserialize356643005((Jumper)obj, reader);
						}
						if (num == 1271521784)
						{
							return this.Deserialize356643005((LilyPaddler)obj, reader);
						}
					}
				}
				else if (num <= 1287561620)
				{
					if (num == 1273669126)
					{
						return this.Deserialize1273669126((Rocket)obj, reader);
					}
					if (num == 1277798743)
					{
						return this.Deserialize1277798743((SeaMonkeySpawnRandomItem)obj, reader);
					}
					if (num == 1287561620)
					{
						return this.Deserialize356643005((Cryptosuchus)obj, reader);
					}
				}
				else
				{
					if (num == 1289092887)
					{
						return this.Deserialize2066256250((PickPrefab)obj, reader);
					}
					if (num == 1297003913)
					{
						return this.Deserialize2066256250((UpgradeConsole)obj, reader);
					}
					if (num == 1304741297)
					{
						return this.Deserialize1304741297((MapRoomCameraDocking)obj, reader);
					}
				}
			}
			else if (num <= 1427962681)
			{
				if (num <= 1364639273)
				{
					if (num <= 1332964068)
					{
						if (num <= 1319564559)
						{
							if (num == 1305740789)
							{
								return this.Deserialize1305740789((SpyPenguinName)obj, reader);
							}
							if (num == 1319564559)
							{
								return this.Deserialize1319564559((SeamothStorageContainer)obj, reader);
							}
						}
						else
						{
							if (num == 1327055215)
							{
								return this.Deserialize356643005((SeaEmperorBaby)obj, reader);
							}
							if (num == 1329426611)
							{
								return this.Deserialize1329426611((PDALog.Entry)obj, reader);
							}
							if (num == 1332964068)
							{
								return this.Deserialize356643005((Leviathan)obj, reader);
							}
						}
					}
					else if (num <= 1340645883)
					{
						if (num == 1333430695)
						{
							return this.Deserialize2066256250((Workbench)obj, reader);
						}
						if (num == 1338410882)
						{
							return this.Deserialize356643005((Jellyray)obj, reader);
						}
						if (num == 1340645883)
						{
							return this.Deserialize1340645883((PrecursorTeleporter)obj, reader);
						}
					}
					else
					{
						if (num == 1343493277)
						{
							return this.Deserialize2066256250((MapRoomScreen)obj, reader);
						}
						if (num == 1355655442)
						{
							return this.Deserialize356643005((Slime)obj, reader);
						}
						if (num == 1364639273)
						{
							return this.Deserialize1364639273((Light)obj, reader);
						}
					}
				}
				else if (num <= 1389926401)
				{
					if (num <= 1386031502)
					{
						if (num == 1372467290)
						{
							return this.Deserialize1372467290((LifepodDrop)obj, reader);
						}
						if (num == 1384707171)
						{
							return this.Deserialize1384707171((BaseNuclearReactor)obj, reader);
						}
						if (num == 1386031502)
						{
							return this.Deserialize1386031502((TimeCapsule)obj, reader);
						}
					}
					else
					{
						if (num == 1386215039)
						{
							return this.Deserialize356643005((Triops)obj, reader);
						}
						if (num == 1386435207)
						{
							return this.Deserialize642877324((PowerCellCharger)obj, reader);
						}
						if (num == 1389926401)
						{
							return this.Deserialize356643005((GhostRay)obj, reader);
						}
					}
				}
				else if (num <= 1404661584)
				{
					if (num == 1396620629)
					{
						return this.Deserialize1396620629((GlacialBasinBridgeController)obj, reader);
					}
					if (num == 1404549125)
					{
						return this.Deserialize1404549125((EntitySlotData)obj, reader);
					}
					if (num == 1404661584)
					{
						return this.Deserialize1404661584((Color)obj, reader);
					}
				}
				else
				{
					if (num == 1406047219)
					{
						return this.Deserialize1585678550((BaseAddPartitionDoorGhost)obj, reader);
					}
					if (num == 1422648694)
					{
						return this.Deserialize1585678550((BaseAddMapRoomGhost)obj, reader);
					}
					if (num == 1427962681)
					{
						return this.Deserialize1427962681((EnergyMixin)obj, reader);
					}
				}
			}
			else if (num <= 1506278612)
			{
				if (num <= 1457388542)
				{
					if (num <= 1433797848)
					{
						if (num == 1430634702)
						{
							return this.Deserialize1430634702((JointHelper)obj, reader);
						}
						if (num == 1433797848)
						{
							return this.Deserialize1433797848((ExecutionOrderTest)obj, reader);
						}
					}
					else
					{
						if (num == 1440414490)
						{
							return this.Deserialize356643005((Stalker)obj, reader);
						}
						if (num == 1457139245)
						{
							return this.Deserialize2066256250((PrecursorDisableGunTerminal)obj, reader);
						}
						if (num == 1457388542)
						{
							return this.Deserialize356643005((PenguinBaby)obj, reader);
						}
					}
				}
				else if (num <= 1489031418)
				{
					if (num == 1469570205)
					{
						return this.Deserialize1469570205((BaseDeconstructable)obj, reader);
					}
					if (num == 1488630837)
					{
						return this.Deserialize1488630837((PDASounds)obj, reader);
					}
					if (num == 1489031418)
					{
						return this.Deserialize1489031418((KeyValuePair<string, bool>)obj, reader);
					}
				}
				else
				{
					if (num == 1489909791)
					{
						return this.Deserialize1489909791((CyclopsDecoyLoadingTube)obj, reader);
					}
					if (num == 1505210158)
					{
						return this.Deserialize2066256250((PrecursorDoorKeyColumn)obj, reader);
					}
					if (num == 1506278612)
					{
						return this.Deserialize1506278612((StoryGoalScheduler)obj, reader);
					}
				}
			}
			else if (num <= 1537030892)
			{
				if (num <= 1522229446)
				{
					if (num == 1506893401)
					{
						return this.Deserialize1585678550((BaseAddCorridorGhost)obj, reader);
					}
					if (num == 1518696882)
					{
						return this.Deserialize1518696882((GradientAlphaKey)obj, reader);
					}
					if (num == 1522229446)
					{
						return this.Deserialize1522229446((PowerSource)obj, reader);
					}
				}
				else
				{
					if (num == 1527139359)
					{
						return this.Deserialize1527139359((PictureFrame)obj, reader);
					}
					if (num == 1535225367)
					{
						return this.Deserialize356643005((Shocker)obj, reader);
					}
					if (num == 1537030892)
					{
						return this.Deserialize1537030892((SubFire)obj, reader);
					}
				}
			}
			else if (num <= 1555952712)
			{
				if (num == 1537880658)
				{
					return this.Deserialize1537880658((BaseUpgradeConsole)obj, reader);
				}
				if (num == 1541346828)
				{
					return this.Deserialize1541346828((PrecursorComputerTerminal)obj, reader);
				}
				if (num == 1555952712)
				{
					return this.Deserialize2066256250((SupplyCrate)obj, reader);
				}
			}
			else
			{
				if (num == 1584912799)
				{
					return this.Deserialize1584912799((BaseBioReactor)obj, reader);
				}
				if (num == 1585678550)
				{
					return this.Deserialize1585678550((BaseGhost)obj, reader);
				}
				if (num == 1590521044)
				{
					return this.Deserialize1590521044((CapsuleCollider)obj, reader);
				}
			}
		}
		else if (num <= 1875862075)
		{
			if (num <= 1725266300)
			{
				if (num <= 1677184373)
				{
					if (num <= 1630308817)
					{
						if (num <= 1606650114)
						{
							if (num == 1603999327)
							{
								return this.Deserialize1603999327((SunlightSettings)obj, reader);
							}
							if (num == 1606650114)
							{
								return this.Deserialize356643005((SeaDragon)obj, reader);
							}
						}
						else
						{
							if (num == 1618351061)
							{
								return this.Deserialize1618351061((FireExtinguisherHolder)obj, reader);
							}
							if (num == 1624342325)
							{
								return this.Deserialize1624342325((SeaTruckDockingBay)obj, reader);
							}
							if (num == 1630308817)
							{
								return this.Deserialize356643005((SnowStalkerBaby)obj, reader);
							}
						}
					}
					else if (num <= 1662769415)
					{
						if (num == 1651949009)
						{
							return this.Deserialize356643005((Reefback)obj, reader);
						}
						if (num == 1659399257)
						{
							return this.Deserialize1659399257((Battery)obj, reader);
						}
						if (num == 1662769415)
						{
							return this.Deserialize1662769415((JukeboxInstance)obj, reader);
						}
					}
					else
					{
						if (num == 1671198874)
						{
							return this.Deserialize1671198874((TechLight)obj, reader);
						}
						if (num == 1675048343)
						{
							return this.Deserialize1675048343((PlayerWorldArrows)obj, reader);
						}
						if (num == 1677184373)
						{
							return this.Deserialize1677184373((PropulseCannonAmmoHandler)obj, reader);
						}
					}
				}
				else if (num <= 1711042137)
				{
					if (num <= 1702762571)
					{
						if (num == 1691070576)
						{
							return this.Deserialize1691070576((Int3)obj, reader);
						}
						if (num == 1702754208)
						{
							return this.Deserialize356643005((GlowWhale)obj, reader);
						}
						if (num == 1702762571)
						{
							return this.Deserialize356643005((ReaperLeviathan)obj, reader);
						}
					}
					else
					{
						if (num == 1703248490)
						{
							return this.Deserialize1703248490((LavaShell)obj, reader);
						}
						if (num == 1703576080)
						{
							return this.Deserialize1703576080((CraftingAnalytics)obj, reader);
						}
						if (num == 1711042137)
						{
							return this.Deserialize356643005((SpinnerFish)obj, reader);
						}
					}
				}
				else if (num <= 1713660373)
				{
					if (num == 1711377162)
					{
						return this.Deserialize1711377162((Beacon)obj, reader);
					}
					if (num == 1711422107)
					{
						return this.Deserialize1711422107((CrashedShipExploder)obj, reader);
					}
					if (num == 1713660373)
					{
						return this.Deserialize2066256250((PrecursorTeleporterActivationTerminal)obj, reader);
					}
				}
				else
				{
					if (num == 1716108768)
					{
						return this.Deserialize1716108768((SeaTruckConnection)obj, reader);
					}
					if (num == 1716510642)
					{
						return this.Deserialize356643005((Boomerang)obj, reader);
					}
					if (num == 1725266300)
					{
						return this.Deserialize1725266300((BaseFloodSim)obj, reader);
					}
				}
			}
			else if (num <= 1800229096)
			{
				if (num <= 1761765682)
				{
					if (num <= 1732754958)
					{
						if (num == 1731663660)
						{
							return this.Deserialize1731663660((NotificationManager.NotificationId)obj, reader);
						}
						if (num == 1732754958)
						{
							return this.Deserialize1732754958((SignalPing)obj, reader);
						}
					}
					else
					{
						if (num == 1747546845)
						{
							return this.Deserialize1747546845((GradientColorKey)obj, reader);
						}
						if (num == 1761034218)
						{
							return this.Deserialize1761034218((NitrogenLevel)obj, reader);
						}
						if (num == 1761765682)
						{
							return this.Deserialize1585678550((BaseAddFaceModuleGhost)obj, reader);
						}
					}
				}
				else if (num <= 1772819529)
				{
					if (num == 1762542304)
					{
						return this.Deserialize1762542304((SphereCollider)obj, reader);
					}
					if (num == 1765532648)
					{
						return this.Deserialize1765532648((Grid3<Vector3>)obj, reader);
					}
					if (num == 1772819529)
					{
						return this.Deserialize1772819529((Breach)obj, reader);
					}
				}
				else
				{
					if (num == 1793440205)
					{
						return this.Deserialize522953267((LargeRoomWaterPark)obj, reader);
					}
					if (num == 1794521971)
					{
						return this.Deserialize356643005((FeatherFish)obj, reader);
					}
					if (num == 1800229096)
					{
						return this.Deserialize2066256250((PowerCrafter)obj, reader);
					}
				}
			}
			else if (num <= 1852174394)
			{
				if (num <= 1817260405)
				{
					if (num == 1804294731)
					{
						return this.Deserialize1804294731((AmbientLightSettings)obj, reader);
					}
					if (num == 1816388137)
					{
						return this.Deserialize356643005((Garryfish)obj, reader);
					}
					if (num == 1817260405)
					{
						return this.Deserialize356643005((GhostLeviatanVoid)obj, reader);
					}
				}
				else
				{
					if (num == 1825589276)
					{
						return this.Deserialize1825589276((Behaviour)obj, reader);
					}
					if (num == 1829844631)
					{
						return this.Deserialize356643005((OculusFish)obj, reader);
					}
					if (num == 1852174394)
					{
						return this.Deserialize1852174394((KeyValuePair<NotificationManager.NotificationId, NotificationManager.NotificationData>)obj, reader);
					}
				}
			}
			else if (num <= 1859566378)
			{
				if (num == 1855998104)
				{
					return this.Deserialize1855998104((MapRoomCamera)obj, reader);
				}
				if (num == 1857674086)
				{
					return this.Deserialize1585678550((BaseAddWallFoundationGhost)obj, reader);
				}
				if (num == 1859566378)
				{
					return this.Deserialize356643005((Hoverfish)obj, reader);
				}
			}
			else
			{
				if (num == 1872669462)
				{
					return this.Deserialize356643005((ArcticRay)obj, reader);
				}
				if (num == 1874975849)
				{
					return this.Deserialize1874975849((NotificationManager.NotificationData)obj, reader);
				}
				if (num == 1875862075)
				{
					return this.Deserialize1875862075((Player)obj, reader);
				}
			}
		}
		else if (num <= 2001815917)
		{
			if (num <= 1941291928)
			{
				if (num <= 1882829928)
				{
					if (num <= 1878920823)
					{
						if (num == 1877364825)
						{
							return this.Deserialize1877364825((ToggleLights)obj, reader);
						}
						if (num == 1878920823)
						{
							return this.Deserialize1878920823((LargeWorldBatchRoot)obj, reader);
						}
					}
					else
					{
						if (num == 1880729675)
						{
							return this.Deserialize356643005((CuteFish)obj, reader);
						}
						if (num == 1881457915)
						{
							return this.Deserialize1881457915((SceneObjectData)obj, reader);
						}
						if (num == 1882829928)
						{
							return this.Deserialize356643005((LavaLizard)obj, reader);
						}
					}
				}
				else if (num <= 1896640149)
				{
					if (num == 1888807148)
					{
						return this.Deserialize356643005((TitanHolefish)obj, reader);
					}
					if (num == 1891515754)
					{
						return this.Deserialize1891515754((UnityEngine.Object)obj, reader);
					}
					if (num == 1896640149)
					{
						return this.Deserialize1585678550((BaseAddBulkheadGhost)obj, reader);
					}
				}
				else
				{
					if (num == 1921909083)
					{
						return this.Deserialize356643005((SeaEmperorJuvenile)obj, reader);
					}
					if (num == 1922274571)
					{
						return this.Deserialize1922274571((EntitySlot)obj, reader);
					}
					if (num == 1941291928)
					{
						return this.Deserialize356643005((Jellyfish)obj, reader);
					}
				}
			}
			else if (num <= 1975582319)
			{
				if (num <= 1956492848)
				{
					if (num == 1948869956)
					{
						return this.Deserialize1948869956((ReefbackPlant)obj, reader);
					}
					if (num == 1954617231)
					{
						return this.Deserialize2066256250((DiveReelAnchor)obj, reader);
					}
					if (num == 1956492848)
					{
						return this.Deserialize1956492848((CellManager.CellHeader)obj, reader);
					}
				}
				else
				{
					if (num == 1966747463)
					{
						return this.Deserialize1966747463((Base)obj, reader);
					}
					if (num == 1971823303)
					{
						return this.Deserialize1971823303((EntitySlotsPlaceholder)obj, reader);
					}
					if (num == 1975582319)
					{
						return this.Deserialize1975582319((Keyframe)obj, reader);
					}
				}
			}
			else if (num <= 1993981848)
			{
				if (num == 1982063882)
				{
					return this.Deserialize1982063882((StoryGoalManager)obj, reader);
				}
				if (num == 1983352738)
				{
					return this.Deserialize2066256250((ThermalPlant)obj, reader);
				}
				if (num == 1993981848)
				{
					return this.Deserialize1993981848((SpawnStoredLoot)obj, reader);
				}
			}
			else
			{
				if (num == 1998792992)
				{
					return this.Deserialize356643005((CrabSnake)obj, reader);
				}
				if (num == 2000594119)
				{
					return this.Deserialize2000594119((AmbientSettings)obj, reader);
				}
				if (num == 2001815917)
				{
					return this.Deserialize2001815917((CreatureFriend)obj, reader);
				}
			}
		}
		else if (num <= 2066256250)
		{
			if (num <= 2039446747)
			{
				if (num <= 2024062491)
				{
					if (num == 2004070125)
					{
						return this.Deserialize2004070125((InfectedMixin)obj, reader);
					}
					if (num == 2013353155)
					{
						return this.Deserialize2013353155((SceneObjectDataSet)obj, reader);
					}
					if (num == 2024062491)
					{
						return this.Deserialize2024062491((RestoreInventoryStorage)obj, reader);
					}
				}
				else
				{
					if (num == 2028243609)
					{
						return this.Deserialize2028243609((MonoBehaviour)obj, reader);
					}
					if (num == 2033371878)
					{
						return this.Deserialize356643005((Grabcrab)obj, reader);
					}
					if (num == 2039446747)
					{
						return this.Deserialize2039446747((BaseControlRoomModule)obj, reader);
					}
				}
			}
			else if (num <= 2054867230)
			{
				if (num == 2044575597)
				{
					return this.Deserialize2044575597((TimeCapsuleItem)obj, reader);
				}
				if (num == 2051895012)
				{
					return this.Deserialize2066256250((PrecursorKeyTerminal)obj, reader);
				}
				if (num == 2054867230)
				{
					return this.Deserialize2054867230((ResearchBase)obj, reader);
				}
			}
			else
			{
				if (num == 2060501761)
				{
					return this.Deserialize1585678550((BaseAddLadderGhost)obj, reader);
				}
				if (num == 2062152363)
				{
					return this.Deserialize2062152363((CyclopsMotorMode)obj, reader);
				}
				if (num == 2066256250)
				{
					return this.Deserialize2066256250((HandTarget)obj, reader);
				}
			}
		}
		else if (num <= 2100518191)
		{
			if (num <= 2092842303)
			{
				if (num == 2078931521)
				{
					return this.Deserialize2078931521((MobileExtractorMachine)obj, reader);
				}
				if (num == 2083308735)
				{
					return this.Deserialize2083308735((CyclopsLightingPanel)obj, reader);
				}
				if (num == 2092842303)
				{
					return this.Deserialize2092842303((Thumper)obj, reader);
				}
			}
			else
			{
				if (num == 2093360837)
				{
					return this.Deserialize356643005((Brinewing)obj, reader);
				}
				if (num == 2100222829)
				{
					return this.Deserialize2100222829((CrafterLogic)obj, reader);
				}
				if (num == 2100518191)
				{
					return this.Deserialize2100518191((Drillable)obj, reader);
				}
			}
		}
		else if (num <= 2111234577)
		{
			if (num == 2104816441)
			{
				return this.Deserialize2104816441((TeleporterManager)obj, reader);
			}
			if (num == 2106147891)
			{
				return this.Deserialize2066256250((SeaMoth)obj, reader);
			}
			if (num == 2111234577)
			{
				return this.Deserialize2111234577((PrefabPlaceholdersGroup)obj, reader);
			}
		}
		else
		{
			if (num == 2124310223)
			{
				return this.Deserialize2124310223((VFXConstructing)obj, reader);
			}
			if (num == 2137760429)
			{
				return this.Deserialize2137760429((PDAScanner.Data)obj, reader);
			}
			if (num == 2146397475)
			{
				return this.Deserialize2146397475((BaseCell)obj, reader);
			}
		}
		return null;
	}

	private void Serialize1804294731(AmbientLightSettings obj, int objTypeId, ProtoWriter writer)
	{
		obj.OnBeforeSerialization();
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.enabled, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1404661584(obj.color, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		if (obj.dayNightColor != null)
		{
			ProtoWriter.WriteFieldHeader(4, WireType.String, writer);
			SubItemToken token2 = ProtoWriter.StartSubItem(obj.dayNightColor, writer);
			this.Serialize175529349(obj.dayNightColor, objTypeId, writer);
			ProtoWriter.EndSubItem(token2, writer);
		}
		ProtoWriter.WriteFieldHeader(5, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.scale, writer);
	}

	private AmbientLightSettings Deserialize1804294731(AmbientLightSettings obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		if (obj == null)
		{
			obj = new AmbientLightSettings();
			ProtoReader.NoteObject(obj, reader);
		}
		while (i > 0)
		{
			switch (i)
			{
			case 1:
				obj.enabled = reader.ReadBoolean();
				break;
			case 2:
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj.color = this.Deserialize1404661584(obj.color, reader);
				ProtoReader.EndSubItem(token, reader);
				break;
			}
			case 3:
				obj.version = reader.ReadInt32();
				break;
			case 4:
			{
				SubItemToken token2 = ProtoReader.StartSubItem(reader);
				obj.dayNightColor = this.Deserialize175529349(obj.dayNightColor, reader);
				ProtoReader.EndSubItem(token2, reader);
				break;
			}
			case 5:
				obj.scale = reader.ReadSingle();
				break;
			default:
				reader.SkipField();
				break;
			}
			i = reader.ReadFieldHeader();
		}
		obj.OnAfterDeserialization();
		return obj;
	}

	private void Serialize2000594119(AmbientSettings obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1404661584(obj.ambientLight, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
	}

	private AmbientSettings Deserialize2000594119(AmbientSettings obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj.ambientLight = this.Deserialize1404661584(obj.ambientLight, reader);
				ProtoReader.EndSubItem(token, reader);
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize7443242(AnalyticsController obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		if (obj._playthroughId != null)
		{
			ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
			ProtoWriter.WriteString(obj._playthroughId, writer);
		}
		if (obj._tags != null)
		{
			foreach (string text in obj._tags)
			{
				if (text != null)
				{
					ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
					ProtoWriter.WriteString(text, writer);
				}
			}
		}
	}

	private AnalyticsController Deserialize7443242(AnalyticsController obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj._playthroughId = reader.ReadString();
				break;
			case 3:
			{
				HashSet<string> hashSet = obj._tags ?? new HashSet<string>();
				int fieldNumber = reader.FieldNumber;
				do
				{
					string item = reader.ReadString();
					hashSet.Add(item);
				}
				while (reader.TryReadFieldHeader(fieldNumber));
				break;
			}
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize880630407(AnimatorParameterValue obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.paramHash, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteInt32((int)obj.paramType, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.boolValue, writer);
		ProtoWriter.WriteFieldHeader(5, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.intValue, writer);
		ProtoWriter.WriteFieldHeader(6, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.floatValue, writer);
	}

	private AnimatorParameterValue Deserialize880630407(AnimatorParameterValue obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		if (obj == null)
		{
			obj = new AnimatorParameterValue();
			ProtoReader.NoteObject(obj, reader);
		}
		while (i > 0)
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.paramHash = reader.ReadInt32();
				break;
			case 3:
				obj.paramType = (AnimatorControllerParameterType)reader.ReadInt32();
				break;
			case 4:
				obj.boolValue = reader.ReadBoolean();
				break;
			case 5:
				obj.intValue = reader.ReadInt32();
				break;
			case 6:
				obj.floatValue = reader.ReadSingle();
				break;
			default:
				reader.SkipField();
				break;
			}
			i = reader.ReadFieldHeader();
		}
		return obj;
	}

	private void Serialize624729416(AnteChamber obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.timeScanBegin, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.scanning, writer);
	}

	private AnteChamber Deserialize624729416(AnteChamber obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.timeScanBegin = reader.ReadSingle();
				break;
			case 3:
				obj.scanning = reader.ReadBoolean();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1238042655(ArcticPeeper obj, int objTypeId, ProtoWriter writer)
	{
	}

	private ArcticPeeper Deserialize1238042655(ArcticPeeper obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1872669462(ArcticRay obj, int objTypeId, ProtoWriter writer)
	{
	}

	private ArcticRay Deserialize1872669462(ArcticRay obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize771173439(ArrowRay obj, int objTypeId, ProtoWriter writer)
	{
	}

	private ArrowRay Deserialize771173439(ArrowRay obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize239375628(AtmosphereVolume obj, int objTypeId, ProtoWriter writer)
	{
		obj.OnBeforeSerialization();
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.priority, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1404661584(obj.fogColor, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.fogStartDistance, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.fogMaxDistance, writer);
		ProtoWriter.WriteFieldHeader(5, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.fadeDefaultLights, writer);
		ProtoWriter.WriteFieldHeader(6, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.fadeRate, writer);
		if (obj.fog != null)
		{
			ProtoWriter.WriteFieldHeader(7, WireType.String, writer);
			SubItemToken token2 = ProtoWriter.StartSubItem(obj.fog, writer);
			this.Serialize108625815(obj.fog, objTypeId, writer);
			ProtoWriter.EndSubItem(token2, writer);
		}
		if (obj.sun != null)
		{
			ProtoWriter.WriteFieldHeader(8, WireType.String, writer);
			SubItemToken token3 = ProtoWriter.StartSubItem(obj.sun, writer);
			this.Serialize1603999327(obj.sun, objTypeId, writer);
			ProtoWriter.EndSubItem(token3, writer);
		}
		if (obj.amb != null)
		{
			ProtoWriter.WriteFieldHeader(9, WireType.String, writer);
			SubItemToken token4 = ProtoWriter.StartSubItem(obj.amb, writer);
			this.Serialize1804294731(obj.amb, objTypeId, writer);
			ProtoWriter.EndSubItem(token4, writer);
		}
		ProtoWriter.WriteFieldHeader(10, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		if (obj.overrideBiome != null)
		{
			ProtoWriter.WriteFieldHeader(11, WireType.String, writer);
			ProtoWriter.WriteString(obj.overrideBiome, writer);
		}
		ProtoWriter.WriteFieldHeader(13, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.highDetail, writer);
		ProtoWriter.WriteFieldHeader(14, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.affectsVisuals, writer);
	}

	private AtmosphereVolume Deserialize239375628(AtmosphereVolume obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		while (i > 0)
		{
			switch (i)
			{
			case 1:
				obj.priority = reader.ReadInt32();
				break;
			case 2:
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj.fogColor = this.Deserialize1404661584(obj.fogColor, reader);
				ProtoReader.EndSubItem(token, reader);
				break;
			}
			case 3:
				obj.fogStartDistance = reader.ReadSingle();
				break;
			case 4:
				obj.fogMaxDistance = reader.ReadSingle();
				break;
			case 5:
				obj.fadeDefaultLights = reader.ReadSingle();
				break;
			case 6:
				obj.fadeRate = reader.ReadSingle();
				break;
			case 7:
			{
				SubItemToken token2 = ProtoReader.StartSubItem(reader);
				obj.fog = this.Deserialize108625815(obj.fog, reader);
				ProtoReader.EndSubItem(token2, reader);
				break;
			}
			case 8:
			{
				SubItemToken token3 = ProtoReader.StartSubItem(reader);
				obj.sun = this.Deserialize1603999327(obj.sun, reader);
				ProtoReader.EndSubItem(token3, reader);
				break;
			}
			case 9:
			{
				SubItemToken token4 = ProtoReader.StartSubItem(reader);
				obj.amb = this.Deserialize1804294731(obj.amb, reader);
				ProtoReader.EndSubItem(token4, reader);
				break;
			}
			case 10:
				obj.version = reader.ReadInt32();
				break;
			case 11:
				obj.overrideBiome = reader.ReadString();
				break;
			case 12:
				goto IL_168;
			case 13:
				obj.highDetail = reader.ReadBoolean();
				break;
			case 14:
				obj.affectsVisuals = reader.ReadBoolean();
				break;
			default:
				goto IL_168;
			}
			IL_16E:
			i = reader.ReadFieldHeader();
			continue;
			IL_168:
			reader.SkipField();
			goto IL_16E;
		}
		obj.OnAfterDeserialization();
		return obj;
	}

	private void Serialize773384208(AttackLargeTarget obj, int objTypeId, ProtoWriter writer)
	{
	}

	private AttackLargeTarget Deserialize773384208(AttackLargeTarget obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1117396675(AttractedByLargeTarget obj, int objTypeId, ProtoWriter writer)
	{
	}

	private AttractedByLargeTarget Deserialize1117396675(AttractedByLargeTarget obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1966747463(Base obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize997267884(obj.baseShape, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
		if (obj.faces != null)
		{
			foreach (int value in obj.faces)
			{
				ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
				ProtoWriter.WriteInt32(value, writer);
			}
		}
		if (obj.cells != null)
		{
			foreach (int value2 in obj.cells)
			{
				ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
				ProtoWriter.WriteInt32(value2, writer);
			}
		}
		if (obj.links != null)
		{
			byte[] links = obj.links;
			ProtoWriter.WriteFieldHeader(4, WireType.String, writer);
			ProtoWriter.WriteBytes(links, writer);
		}
		ProtoWriter.WriteFieldHeader(5, WireType.String, writer);
		SubItemToken token2 = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1691070576(obj.cellOffset, objTypeId, writer);
		ProtoWriter.EndSubItem(token2, writer);
		if (obj.masks != null)
		{
			byte[] masks = obj.masks;
			ProtoWriter.WriteFieldHeader(6, WireType.String, writer);
			ProtoWriter.WriteBytes(masks, writer);
		}
		if (obj.isGlass != null)
		{
			foreach (bool value3 in obj.isGlass)
			{
				ProtoWriter.WriteFieldHeader(7, WireType.Variant, writer);
				ProtoWriter.WriteBoolean(value3, writer);
			}
		}
		ProtoWriter.WriteFieldHeader(8, WireType.String, writer);
		SubItemToken token3 = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1691070576(obj.anchor, objTypeId, writer);
		ProtoWriter.EndSubItem(token3, writer);
		if (obj.unpowered != null)
		{
			foreach (bool value4 in obj.unpowered)
			{
				ProtoWriter.WriteFieldHeader(9, WireType.Variant, writer);
				ProtoWriter.WriteBoolean(value4, writer);
			}
		}
	}

	private Base Deserialize1966747463(Base obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj.baseShape = this.Deserialize997267884(obj.baseShape, reader);
				ProtoReader.EndSubItem(token, reader);
				break;
			}
			case 2:
			{
				List<Base.FaceType> list = new List<Base.FaceType>();
				int fieldNumber = reader.FieldNumber;
				do
				{
					Base.FaceType item = (Base.FaceType)reader.ReadInt32();
					list.Add(item);
				}
				while (reader.TryReadFieldHeader(fieldNumber));
				obj.faces = list.ToArray();
				break;
			}
			case 3:
			{
				List<Base.CellType> list2 = new List<Base.CellType>();
				int fieldNumber2 = reader.FieldNumber;
				do
				{
					Base.CellType item2 = (Base.CellType)reader.ReadInt32();
					list2.Add(item2);
				}
				while (reader.TryReadFieldHeader(fieldNumber2));
				obj.cells = list2.ToArray();
				break;
			}
			case 4:
				obj.links = ProtoReader.AppendBytes(obj.links, reader);
				break;
			case 5:
			{
				SubItemToken token2 = ProtoReader.StartSubItem(reader);
				obj.cellOffset = this.Deserialize1691070576(obj.cellOffset, reader);
				ProtoReader.EndSubItem(token2, reader);
				break;
			}
			case 6:
				obj.masks = ProtoReader.AppendBytes(obj.masks, reader);
				break;
			case 7:
			{
				List<bool> list3 = new List<bool>();
				int fieldNumber3 = reader.FieldNumber;
				do
				{
					bool item3 = reader.ReadBoolean();
					list3.Add(item3);
				}
				while (reader.TryReadFieldHeader(fieldNumber3));
				obj.isGlass = list3.ToArray();
				break;
			}
			case 8:
			{
				SubItemToken token3 = ProtoReader.StartSubItem(reader);
				obj.anchor = this.Deserialize1691070576(obj.anchor, reader);
				ProtoReader.EndSubItem(token3, reader);
				break;
			}
			case 9:
			{
				List<bool> list4 = new List<bool>();
				int fieldNumber4 = reader.FieldNumber;
				do
				{
					bool item4 = reader.ReadBoolean();
					list4.Add(item4);
				}
				while (reader.TryReadFieldHeader(fieldNumber4));
				obj.unpowered = list4.ToArray();
				break;
			}
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize497398254(Base.Face obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1691070576(obj.cell, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteInt32((int)obj.direction, writer);
	}

	private Base.Face Deserialize497398254(Base.Face obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.direction = (Base.Direction)reader.ReadInt32();
				}
			}
			else
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj.cell = this.Deserialize1691070576(obj.cell, reader);
				ProtoReader.EndSubItem(token, reader);
			}
		}
		return obj;
	}

	private void Serialize1896640149(BaseAddBulkheadGhost obj, int objTypeId, ProtoWriter writer)
	{
	}

	private BaseAddBulkheadGhost Deserialize1896640149(BaseAddBulkheadGhost obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize383673295(BaseAddCellGhost obj, int objTypeId, ProtoWriter writer)
	{
	}

	private BaseAddCellGhost Deserialize383673295(BaseAddCellGhost obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize633495696(BaseAddConnectorGhost obj, int objTypeId, ProtoWriter writer)
	{
	}

	private BaseAddConnectorGhost Deserialize633495696(BaseAddConnectorGhost obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1506893401(BaseAddCorridorGhost obj, int objTypeId, ProtoWriter writer)
	{
	}

	private BaseAddCorridorGhost Deserialize1506893401(BaseAddCorridorGhost obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1090472122(BaseAddFaceGhost obj, int objTypeId, ProtoWriter writer)
	{
		if (objTypeId == 1761765682)
		{
			ProtoWriter.WriteFieldHeader(701, WireType.String, writer);
			SubItemToken token = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1761765682(obj as BaseAddFaceModuleGhost, objTypeId, writer);
			ProtoWriter.EndSubItem(token, writer);
		}
		if (obj.anchoredFace != null)
		{
			ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
			SubItemToken token2 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize497398254(obj.anchoredFace.GetValueOrDefault(), objTypeId, writer);
			ProtoWriter.EndSubItem(token2, writer);
		}
	}

	private BaseAddFaceGhost Deserialize1090472122(BaseAddFaceGhost obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 701)
			{
				IL_75:
				while (i > 0)
				{
					if (i == 1)
					{
						SubItemToken token = ProtoReader.StartSubItem(reader);
						obj.anchoredFace = new Base.Face?(this.Deserialize497398254(obj.anchoredFace.GetValueOrDefault(), reader));
						ProtoReader.EndSubItem(token, reader);
					}
					else
					{
						reader.SkipField();
					}
					i = reader.ReadFieldHeader();
				}
				return obj;
			}
			SubItemToken token2 = ProtoReader.StartSubItem(reader);
			obj = this.Deserialize1761765682(obj as BaseAddFaceModuleGhost, reader);
			ProtoReader.EndSubItem(token2, reader);
		}
		goto IL_75;
	}

	private void Serialize1761765682(BaseAddFaceModuleGhost obj, int objTypeId, ProtoWriter writer)
	{
	}

	private BaseAddFaceModuleGhost Deserialize1761765682(BaseAddFaceModuleGhost obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize2060501761(BaseAddLadderGhost obj, int objTypeId, ProtoWriter writer)
	{
	}

	private BaseAddLadderGhost Deserialize2060501761(BaseAddLadderGhost obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1422648694(BaseAddMapRoomGhost obj, int objTypeId, ProtoWriter writer)
	{
	}

	private BaseAddMapRoomGhost Deserialize1422648694(BaseAddMapRoomGhost obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize862251519(BaseAddModuleGhost obj, int objTypeId, ProtoWriter writer)
	{
		if (obj.anchoredFace != null)
		{
			ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
			SubItemToken token = ProtoWriter.StartSubItem(null, writer);
			this.Serialize497398254(obj.anchoredFace.GetValueOrDefault(), objTypeId, writer);
			ProtoWriter.EndSubItem(token, writer);
		}
	}

	private BaseAddModuleGhost Deserialize862251519(BaseAddModuleGhost obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj.anchoredFace = new Base.Face?(this.Deserialize497398254(obj.anchoredFace.GetValueOrDefault(), reader));
				ProtoReader.EndSubItem(token, reader);
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize1406047219(BaseAddPartitionDoorGhost obj, int objTypeId, ProtoWriter writer)
	{
		if (obj.anchoredFace != null)
		{
			ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
			SubItemToken token = ProtoWriter.StartSubItem(null, writer);
			this.Serialize497398254(obj.anchoredFace.GetValueOrDefault(), objTypeId, writer);
			ProtoWriter.EndSubItem(token, writer);
		}
	}

	private BaseAddPartitionDoorGhost Deserialize1406047219(BaseAddPartitionDoorGhost obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj.anchoredFace = new Base.Face?(this.Deserialize497398254(obj.anchoredFace.GetValueOrDefault(), reader));
				ProtoReader.EndSubItem(token, reader);
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize490474621(BaseAddPartitionGhost obj, int objTypeId, ProtoWriter writer)
	{
		if (obj.anchoredCell != null)
		{
			ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
			SubItemToken token = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1691070576(obj.anchoredCell.GetValueOrDefault(), objTypeId, writer);
			ProtoWriter.EndSubItem(token, writer);
		}
	}

	private BaseAddPartitionGhost Deserialize490474621(BaseAddPartitionGhost obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj.anchoredCell = new Int3?(this.Deserialize1691070576(obj.anchoredCell.GetValueOrDefault(), reader));
				ProtoReader.EndSubItem(token, reader);
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize1857674086(BaseAddWallFoundationGhost obj, int objTypeId, ProtoWriter writer)
	{
	}

	private BaseAddWallFoundationGhost Deserialize1857674086(BaseAddWallFoundationGhost obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1127946067(BaseAddWaterPark obj, int objTypeId, ProtoWriter writer)
	{
		if (obj.anchoredFace != null)
		{
			ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
			SubItemToken token = ProtoWriter.StartSubItem(null, writer);
			this.Serialize497398254(obj.anchoredFace.GetValueOrDefault(), objTypeId, writer);
			ProtoWriter.EndSubItem(token, writer);
		}
	}

	private BaseAddWaterPark Deserialize1127946067(BaseAddWaterPark obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj.anchoredFace = new Base.Face?(this.Deserialize497398254(obj.anchoredFace.GetValueOrDefault(), reader));
				ProtoReader.EndSubItem(token, reader);
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize1584912799(BaseBioReactor obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj._protoVersion, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize497398254(obj._moduleFace, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj._constructed, writer);
		if (obj._serializedStorage != null)
		{
			byte[] serializedStorage = obj._serializedStorage;
			ProtoWriter.WriteFieldHeader(4, WireType.String, writer);
			ProtoWriter.WriteBytes(serializedStorage, writer);
		}
		ProtoWriter.WriteFieldHeader(5, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj._toConsume, writer);
	}

	private BaseBioReactor Deserialize1584912799(BaseBioReactor obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj._protoVersion = reader.ReadInt32();
				break;
			case 2:
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj._moduleFace = this.Deserialize497398254(obj._moduleFace, reader);
				ProtoReader.EndSubItem(token, reader);
				break;
			}
			case 3:
				obj._constructed = reader.ReadSingle();
				break;
			case 4:
				obj._serializedStorage = ProtoReader.AppendBytes(obj._serializedStorage, reader);
				break;
			case 5:
				obj._toConsume = reader.ReadSingle();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize2146397475(BaseCell obj, int objTypeId, ProtoWriter writer)
	{
	}

	private BaseCell Deserialize2146397475(BaseCell obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize2039446747(BaseControlRoomModule obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize497398254(obj._moduleFace, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj._constructed, writer);
	}

	private BaseControlRoomModule Deserialize2039446747(BaseControlRoomModule obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj._moduleFace = this.Deserialize497398254(obj._moduleFace, reader);
				ProtoReader.EndSubItem(token, reader);
				break;
			}
			case 3:
				obj._constructed = reader.ReadSingle();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1469570205(BaseDeconstructable obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1164389947(obj.bounds, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
		if (obj.face != null)
		{
			ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
			SubItemToken token2 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize497398254(obj.face.GetValueOrDefault(), objTypeId, writer);
			ProtoWriter.EndSubItem(token2, writer);
		}
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteInt32((int)obj.faceType, writer);
	}

	private BaseDeconstructable Deserialize1469570205(BaseDeconstructable obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj.bounds = this.Deserialize1164389947(obj.bounds, reader);
				ProtoReader.EndSubItem(token, reader);
				break;
			}
			case 2:
			{
				SubItemToken token2 = ProtoReader.StartSubItem(reader);
				obj.face = new Base.Face?(this.Deserialize497398254(obj.face.GetValueOrDefault(), reader));
				ProtoReader.EndSubItem(token2, reader);
				break;
			}
			case 3:
				obj.faceType = (Base.FaceType)reader.ReadInt32();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize371084514(BaseExplicitFace obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		if (obj.face != null)
		{
			ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
			SubItemToken token = ProtoWriter.StartSubItem(null, writer);
			this.Serialize497398254(obj.face.GetValueOrDefault(), objTypeId, writer);
			ProtoWriter.EndSubItem(token, writer);
		}
	}

	private BaseExplicitFace Deserialize371084514(BaseExplicitFace obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					SubItemToken token = ProtoReader.StartSubItem(reader);
					obj.face = new Base.Face?(this.Deserialize497398254(obj.face.GetValueOrDefault(), reader));
					ProtoReader.EndSubItem(token, reader);
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize1725266300(BaseFloodSim obj, int objTypeId, ProtoWriter writer)
	{
		if (obj.flatValueGrid != null)
		{
			foreach (float value in obj.flatValueGrid)
			{
				ProtoWriter.WriteFieldHeader(1, WireType.Fixed32, writer);
				ProtoWriter.WriteSingle(value, writer);
			}
		}
	}

	private BaseFloodSim Deserialize1725266300(BaseFloodSim obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				List<float> list = new List<float>();
				int fieldNumber = reader.FieldNumber;
				do
				{
					float item = reader.ReadSingle();
					list.Add(item);
				}
				while (reader.TryReadFieldHeader(fieldNumber));
				obj.flatValueGrid = list.ToArray();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize1585678550(BaseGhost obj, int objTypeId, ProtoWriter writer)
	{
		if (objTypeId == 1896640149)
		{
			ProtoWriter.WriteFieldHeader(601, WireType.String, writer);
			SubItemToken token = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1896640149(obj as BaseAddBulkheadGhost, objTypeId, writer);
			ProtoWriter.EndSubItem(token, writer);
		}
		else if (objTypeId == 383673295)
		{
			ProtoWriter.WriteFieldHeader(602, WireType.String, writer);
			SubItemToken token2 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize383673295(obj as BaseAddCellGhost, objTypeId, writer);
			ProtoWriter.EndSubItem(token2, writer);
		}
		else if (objTypeId == 633495696)
		{
			ProtoWriter.WriteFieldHeader(603, WireType.String, writer);
			SubItemToken token3 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize633495696(obj as BaseAddConnectorGhost, objTypeId, writer);
			ProtoWriter.EndSubItem(token3, writer);
		}
		else if (objTypeId == 1506893401)
		{
			ProtoWriter.WriteFieldHeader(604, WireType.String, writer);
			SubItemToken token4 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1506893401(obj as BaseAddCorridorGhost, objTypeId, writer);
			ProtoWriter.EndSubItem(token4, writer);
		}
		else if (objTypeId == 1090472122 || objTypeId == 1761765682)
		{
			ProtoWriter.WriteFieldHeader(605, WireType.String, writer);
			SubItemToken token5 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1090472122(obj as BaseAddFaceGhost, objTypeId, writer);
			ProtoWriter.EndSubItem(token5, writer);
		}
		else if (objTypeId == 2060501761)
		{
			ProtoWriter.WriteFieldHeader(606, WireType.String, writer);
			SubItemToken token6 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize2060501761(obj as BaseAddLadderGhost, objTypeId, writer);
			ProtoWriter.EndSubItem(token6, writer);
		}
		else if (objTypeId == 1127946067)
		{
			ProtoWriter.WriteFieldHeader(607, WireType.String, writer);
			SubItemToken token7 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1127946067(obj as BaseAddWaterPark, objTypeId, writer);
			ProtoWriter.EndSubItem(token7, writer);
		}
		else if (objTypeId == 1422648694)
		{
			ProtoWriter.WriteFieldHeader(608, WireType.String, writer);
			SubItemToken token8 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1422648694(obj as BaseAddMapRoomGhost, objTypeId, writer);
			ProtoWriter.EndSubItem(token8, writer);
		}
		else if (objTypeId == 862251519)
		{
			ProtoWriter.WriteFieldHeader(609, WireType.String, writer);
			SubItemToken token9 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize862251519(obj as BaseAddModuleGhost, objTypeId, writer);
			ProtoWriter.EndSubItem(token9, writer);
		}
		else if (objTypeId == 1857674086)
		{
			ProtoWriter.WriteFieldHeader(610, WireType.String, writer);
			SubItemToken token10 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1857674086(obj as BaseAddWallFoundationGhost, objTypeId, writer);
			ProtoWriter.EndSubItem(token10, writer);
		}
		else if (objTypeId == 490474621)
		{
			ProtoWriter.WriteFieldHeader(611, WireType.String, writer);
			SubItemToken token11 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize490474621(obj as BaseAddPartitionGhost, objTypeId, writer);
			ProtoWriter.EndSubItem(token11, writer);
		}
		else if (objTypeId == 1406047219)
		{
			ProtoWriter.WriteFieldHeader(612, WireType.String, writer);
			SubItemToken token12 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1406047219(obj as BaseAddPartitionDoorGhost, objTypeId, writer);
			ProtoWriter.EndSubItem(token12, writer);
		}
		ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
		SubItemToken token13 = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1691070576(obj.targetOffset, objTypeId, writer);
		ProtoWriter.EndSubItem(token13, writer);
	}

	private BaseGhost Deserialize1585678550(BaseGhost obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 601)
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1896640149(obj as BaseAddBulkheadGhost, reader);
				ProtoReader.EndSubItem(token, reader);
			}
			else if (i == 602)
			{
				SubItemToken token2 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize383673295(obj as BaseAddCellGhost, reader);
				ProtoReader.EndSubItem(token2, reader);
			}
			else if (i == 603)
			{
				SubItemToken token3 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize633495696(obj as BaseAddConnectorGhost, reader);
				ProtoReader.EndSubItem(token3, reader);
			}
			else if (i == 604)
			{
				SubItemToken token4 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1506893401(obj as BaseAddCorridorGhost, reader);
				ProtoReader.EndSubItem(token4, reader);
			}
			else if (i == 605)
			{
				SubItemToken token5 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1090472122(obj as BaseAddFaceGhost, reader);
				ProtoReader.EndSubItem(token5, reader);
			}
			else if (i == 606)
			{
				SubItemToken token6 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize2060501761(obj as BaseAddLadderGhost, reader);
				ProtoReader.EndSubItem(token6, reader);
			}
			else if (i == 607)
			{
				SubItemToken token7 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1127946067(obj as BaseAddWaterPark, reader);
				ProtoReader.EndSubItem(token7, reader);
			}
			else if (i == 608)
			{
				SubItemToken token8 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1422648694(obj as BaseAddMapRoomGhost, reader);
				ProtoReader.EndSubItem(token8, reader);
			}
			else if (i == 609)
			{
				SubItemToken token9 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize862251519(obj as BaseAddModuleGhost, reader);
				ProtoReader.EndSubItem(token9, reader);
			}
			else if (i == 610)
			{
				SubItemToken token10 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1857674086(obj as BaseAddWallFoundationGhost, reader);
				ProtoReader.EndSubItem(token10, reader);
			}
			else if (i == 611)
			{
				SubItemToken token11 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize490474621(obj as BaseAddPartitionGhost, reader);
				ProtoReader.EndSubItem(token11, reader);
			}
			else
			{
				if (i != 612)
				{
					IL_220:
					while (i > 0)
					{
						if (i == 1)
						{
							SubItemToken token12 = ProtoReader.StartSubItem(reader);
							obj.targetOffset = this.Deserialize1691070576(obj.targetOffset, reader);
							ProtoReader.EndSubItem(token12, reader);
						}
						else
						{
							reader.SkipField();
						}
						i = reader.ReadFieldHeader();
					}
					return obj;
				}
				SubItemToken token13 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1406047219(obj as BaseAddPartitionDoorGhost, reader);
				ProtoReader.EndSubItem(token13, reader);
			}
		}
		goto IL_220;
	}

	private void Serialize1147135728(BaseName obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		if (obj.baseName != null)
		{
			ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
			ProtoWriter.WriteString(obj.baseName, writer);
		}
		if (obj.baseColors != null)
		{
			foreach (Vector3 obj2 in obj.baseColors)
			{
				ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
				SubItemToken token = ProtoWriter.StartSubItem(null, writer);
				this.Serialize1181346079(obj2, objTypeId, writer);
				ProtoWriter.EndSubItem(token, writer);
			}
		}
	}

	private BaseName Deserialize1147135728(BaseName obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.baseName = reader.ReadString();
				break;
			case 3:
			{
				List<Vector3> list = new List<Vector3>();
				int fieldNumber = reader.FieldNumber;
				do
				{
					Vector3 vector = default(Vector3);
					SubItemToken token = ProtoReader.StartSubItem(reader);
					vector = this.Deserialize1181346079(vector, reader);
					ProtoReader.EndSubItem(token, reader);
					list.Add(vector);
				}
				while (reader.TryReadFieldHeader(fieldNumber));
				obj.baseColors = list.ToArray();
				break;
			}
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1384707171(BaseNuclearReactor obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj._protoVersion, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize497398254(obj._moduleFace, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj._constructed, writer);
		if (obj._serializedEquipment != null)
		{
			byte[] serializedEquipment = obj._serializedEquipment;
			ProtoWriter.WriteFieldHeader(4, WireType.String, writer);
			ProtoWriter.WriteBytes(serializedEquipment, writer);
		}
		if (obj._serializedEquipmentSlots != null)
		{
			foreach (KeyValuePair<string, string> obj2 in obj._serializedEquipmentSlots)
			{
				ProtoWriter.WriteFieldHeader(5, WireType.String, writer);
				SubItemToken token2 = ProtoWriter.StartSubItem(null, writer);
				this.Serialize524780017(obj2, objTypeId, writer);
				ProtoWriter.EndSubItem(token2, writer);
			}
		}
		ProtoWriter.WriteFieldHeader(6, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj._toConsume, writer);
	}

	private BaseNuclearReactor Deserialize1384707171(BaseNuclearReactor obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj._protoVersion = reader.ReadInt32();
				break;
			case 2:
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj._moduleFace = this.Deserialize497398254(obj._moduleFace, reader);
				ProtoReader.EndSubItem(token, reader);
				break;
			}
			case 3:
				obj._constructed = reader.ReadSingle();
				break;
			case 4:
				obj._serializedEquipment = ProtoReader.AppendBytes(obj._serializedEquipment, reader);
				break;
			case 5:
			{
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				int fieldNumber = reader.FieldNumber;
				do
				{
					KeyValuePair<string, string> obj2 = default(KeyValuePair<string, string>);
					SubItemToken token2 = ProtoReader.StartSubItem(reader);
					obj2 = this.Deserialize524780017(obj2, reader);
					ProtoReader.EndSubItem(token2, reader);
					dictionary[obj2.Key] = obj2.Value;
				}
				while (reader.TryReadFieldHeader(fieldNumber));
				obj._serializedEquipmentSlots = dictionary;
				break;
			}
			case 6:
				obj._toConsume = reader.ReadSingle();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize882866214(BasePipeConnector obj, int objTypeId, ProtoWriter writer)
	{
		if (obj.childPipeUID != null)
		{
			foreach (string text in obj.childPipeUID)
			{
				if (text != null)
				{
					ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
					ProtoWriter.WriteString(text, writer);
				}
			}
		}
	}

	private BasePipeConnector Deserialize882866214(BasePipeConnector obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				List<string> list = new List<string>();
				int fieldNumber = reader.FieldNumber;
				do
				{
					string item = reader.ReadString();
					list.Add(item);
				}
				while (reader.TryReadFieldHeader(fieldNumber));
				obj.childPipeUID = list.ToArray();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize311542795(BaseRoot obj, int objTypeId, ProtoWriter writer)
	{
	}

	private BaseRoot Deserialize311542795(BaseRoot obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1045809045(BaseSpotLight obj, int objTypeId, ProtoWriter writer)
	{
	}

	private BaseSpotLight Deserialize1045809045(BaseSpotLight obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1537880658(BaseUpgradeConsole obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj._protoVersion, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize497398254(obj._moduleFace, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj._constructed, writer);
	}

	private BaseUpgradeConsole Deserialize1537880658(BaseUpgradeConsole obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj._protoVersion = reader.ReadInt32();
				break;
			case 2:
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj._moduleFace = this.Deserialize497398254(obj._moduleFace, reader);
				ProtoReader.EndSubItem(token, reader);
				break;
			}
			case 3:
				obj._constructed = reader.ReadSingle();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1659399257(Battery obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.protoVersion, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj._charge, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj._capacity, writer);
	}

	private Battery Deserialize1659399257(Battery obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.protoVersion = reader.ReadInt32();
				break;
			case 2:
				obj._charge = reader.ReadSingle();
				break;
			case 3:
				obj._capacity = reader.ReadSingle();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize788408569(BatteryCharger obj, int objTypeId, ProtoWriter writer)
	{
	}

	private BatteryCharger Deserialize788408569(BatteryCharger obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize929691462(BatterySource obj, int objTypeId, ProtoWriter writer)
	{
	}

	private BatterySource Deserialize929691462(BatterySource obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1711377162(Beacon obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		if (obj.label != null)
		{
			ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
			ProtoWriter.WriteString(obj.label, writer);
		}
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.deployedOnLand, writer);
	}

	private Beacon Deserialize1711377162(Beacon obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.label = reader.ReadString();
				break;
			case 3:
				obj.deployedOnLand = reader.ReadBoolean();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1011566978(Bioreactor obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Bioreactor Deserialize1011566978(Bioreactor obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize40841636(BirdBehaviour obj, int objTypeId, ProtoWriter writer)
	{
		if (objTypeId == 469144263)
		{
			ProtoWriter.WriteFieldHeader(4210, WireType.String, writer);
			SubItemToken token = ProtoWriter.StartSubItem(null, writer);
			this.Serialize469144263(obj as Skyray, objTypeId, writer);
			ProtoWriter.EndSubItem(token, writer);
		}
	}

	private BirdBehaviour Deserialize40841636(BirdBehaviour obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 4210)
			{
				IL_46:
				while (i > 0)
				{
					reader.SkipField();
					i = reader.ReadFieldHeader();
				}
				return obj;
			}
			SubItemToken token = ProtoReader.StartSubItem(reader);
			obj = this.Deserialize469144263(obj as Skyray, reader);
			ProtoReader.EndSubItem(token, reader);
		}
		goto IL_46;
	}

	private void Serialize649861234(Biter obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Biter Deserialize649861234(Biter obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize953017598(Bladderfish obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Bladderfish Deserialize953017598(Bladderfish obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1041366111(Bleeder obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Bleeder Deserialize1041366111(Bleeder obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize829906308(BloomCreature obj, int objTypeId, ProtoWriter writer)
	{
	}

	private BloomCreature Deserialize829906308(BloomCreature obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1012963343(BlueprintHandTarget obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.used, writer);
	}

	private BlueprintHandTarget Deserialize1012963343(BlueprintHandTarget obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				obj.used = reader.ReadBoolean();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize535540024(BodyTemperature obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.currentColdMeterValue, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.coldResistBuff, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.coldResistDuration, writer);
	}

	private BodyTemperature Deserialize535540024(BodyTemperature obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.currentColdMeterValue = reader.ReadSingle();
				break;
			case 3:
				obj.coldResistBuff = reader.ReadSingle();
				break;
			case 4:
				obj.coldResistDuration = reader.ReadSingle();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize242904679(BoneShark obj, int objTypeId, ProtoWriter writer)
	{
	}

	private BoneShark Deserialize242904679(BoneShark obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1716510642(Boomerang obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Boomerang Deserialize1716510642(Boomerang obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1772819529(Breach obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Breach Deserialize1772819529(Breach obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize2093360837(Brinewing obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Brinewing Deserialize2093360837(Brinewing obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize42492657(BruteShark obj, int objTypeId, ProtoWriter writer)
	{
	}

	private BruteShark Deserialize42492657(BruteShark obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1176920975(CaveCrawler obj, int objTypeId, ProtoWriter writer)
	{
	}

	private CaveCrawler Deserialize1176920975(CaveCrawler obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1956492848(CellManager.CellHeader obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1691070576(obj.cellId, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.level, writer);
	}

	private CellManager.CellHeader Deserialize1956492848(CellManager.CellHeader obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		if (obj == null)
		{
			obj = new CellManager.CellHeader();
			ProtoReader.NoteObject(obj, reader);
		}
		while (i > 0)
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.level = reader.ReadInt32();
				}
			}
			else
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj.cellId = this.Deserialize1691070576(obj.cellId, reader);
				ProtoReader.EndSubItem(token, reader);
			}
			i = reader.ReadFieldHeader();
		}
		return obj;
	}

	private void Serialize949139443(CellManager.CellHeaderEx obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1691070576(obj.cellId, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.level, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.dataLength, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.legacyDataLength, writer);
		ProtoWriter.WriteFieldHeader(5, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.waiterDataLength, writer);
		ProtoWriter.WriteFieldHeader(6, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.allowSpawnRestrictions, writer);
	}

	private CellManager.CellHeaderEx Deserialize949139443(CellManager.CellHeaderEx obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		if (obj == null)
		{
			obj = new CellManager.CellHeaderEx();
			ProtoReader.NoteObject(obj, reader);
		}
		while (i > 0)
		{
			switch (i)
			{
			case 1:
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj.cellId = this.Deserialize1691070576(obj.cellId, reader);
				ProtoReader.EndSubItem(token, reader);
				break;
			}
			case 2:
				obj.level = reader.ReadInt32();
				break;
			case 3:
				obj.dataLength = reader.ReadInt32();
				break;
			case 4:
				obj.legacyDataLength = reader.ReadInt32();
				break;
			case 5:
				obj.waiterDataLength = reader.ReadInt32();
				break;
			case 6:
				obj.allowSpawnRestrictions = reader.ReadBoolean();
				break;
			default:
				reader.SkipField();
				break;
			}
			i = reader.ReadFieldHeader();
		}
		return obj;
	}

	private void Serialize153467737(CellManager.CellsFileHeader obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.numCells, writer);
	}

	private CellManager.CellsFileHeader Deserialize153467737(CellManager.CellsFileHeader obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		if (obj == null)
		{
			obj = new CellManager.CellsFileHeader();
			ProtoReader.NoteObject(obj, reader);
		}
		while (i > 0)
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.numCells = reader.ReadInt32();
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
			i = reader.ReadFieldHeader();
		}
		return obj;
	}

	private void Serialize642877324(Charger obj, int objTypeId, ProtoWriter writer)
	{
		if (objTypeId == 788408569)
		{
			ProtoWriter.WriteFieldHeader(100, WireType.String, writer);
			SubItemToken token = ProtoWriter.StartSubItem(null, writer);
			this.Serialize788408569(obj as BatteryCharger, objTypeId, writer);
			ProtoWriter.EndSubItem(token, writer);
		}
		else if (objTypeId == 1386435207)
		{
			ProtoWriter.WriteFieldHeader(200, WireType.String, writer);
			SubItemToken token2 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1386435207(obj as PowerCellCharger, objTypeId, writer);
			ProtoWriter.EndSubItem(token2, writer);
		}
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.protoVersion, writer);
		if (obj.serializedSlots != null)
		{
			foreach (KeyValuePair<string, string> obj2 in obj.serializedSlots)
			{
				ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
				SubItemToken token3 = ProtoWriter.StartSubItem(null, writer);
				this.Serialize524780017(obj2, objTypeId, writer);
				ProtoWriter.EndSubItem(token3, writer);
			}
		}
	}

	private Charger Deserialize642877324(Charger obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 100)
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize788408569(obj as BatteryCharger, reader);
				ProtoReader.EndSubItem(token, reader);
			}
			else
			{
				if (i != 200)
				{
					IL_D3:
					while (i > 0)
					{
						if (i != 1)
						{
							if (i != 2)
							{
								reader.SkipField();
							}
							else
							{
								Dictionary<string, string> dictionary = new Dictionary<string, string>();
								int fieldNumber = reader.FieldNumber;
								do
								{
									KeyValuePair<string, string> obj2 = default(KeyValuePair<string, string>);
									SubItemToken token2 = ProtoReader.StartSubItem(reader);
									obj2 = this.Deserialize524780017(obj2, reader);
									ProtoReader.EndSubItem(token2, reader);
									dictionary[obj2.Key] = obj2.Value;
								}
								while (reader.TryReadFieldHeader(fieldNumber));
								obj.serializedSlots = dictionary;
							}
						}
						else
						{
							obj.protoVersion = reader.ReadInt32();
						}
						i = reader.ReadFieldHeader();
					}
					return obj;
				}
				SubItemToken token3 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1386435207(obj as PowerCellCharger, reader);
				ProtoReader.EndSubItem(token3, reader);
			}
		}
		goto IL_D3;
	}

	private void Serialize836898529(Chelicerate obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Chelicerate Deserialize836898529(Chelicerate obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize237257528(CoffeeMachineLegacy obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
	}

	private CoffeeMachineLegacy Deserialize237257528(CoffeeMachineLegacy obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				obj.version = reader.ReadInt32();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize812739867(CollectShiny obj, int objTypeId, ProtoWriter writer)
	{
	}

	private CollectShiny Deserialize812739867(CollectShiny obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize515927774(ColoredLabel obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		if (obj.text != null)
		{
			ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
			ProtoWriter.WriteString(obj.text, writer);
		}
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.colorIndex, writer);
	}

	private ColoredLabel Deserialize515927774(ColoredLabel obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.text = reader.ReadString();
				break;
			case 3:
				obj.colorIndex = reader.ReadInt32();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize483523761(ColorNameControl obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		if (obj.savedName != null)
		{
			ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
			ProtoWriter.WriteString(obj.savedName, writer);
		}
		if (obj.savedColors != null)
		{
			foreach (Vector3 obj2 in obj.savedColors)
			{
				ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
				SubItemToken token = ProtoWriter.StartSubItem(null, writer);
				this.Serialize1181346079(obj2, objTypeId, writer);
				ProtoWriter.EndSubItem(token, writer);
			}
		}
	}

	private ColorNameControl Deserialize483523761(ColorNameControl obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.savedName = reader.ReadString();
				break;
			case 3:
			{
				List<Vector3> list = new List<Vector3>();
				int fieldNumber = reader.FieldNumber;
				do
				{
					Vector3 vector = default(Vector3);
					SubItemToken token = ProtoReader.StartSubItem(reader);
					vector = this.Deserialize1181346079(vector, reader);
					ProtoReader.EndSubItem(token, reader);
					list.Add(vector);
				}
				while (reader.TryReadFieldHeader(fieldNumber));
				obj.savedColors = list.ToArray();
				break;
			}
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize396637907(Constructable obj, int objTypeId, ProtoWriter writer)
	{
		if (objTypeId == 817046334)
		{
			ProtoWriter.WriteFieldHeader(3100, WireType.String, writer);
			SubItemToken token = ProtoWriter.StartSubItem(null, writer);
			this.Serialize817046334(obj as ConstructableBase, objTypeId, writer);
			ProtoWriter.EndSubItem(token, writer);
		}
		else if (objTypeId == 1045809045)
		{
			ProtoWriter.WriteFieldHeader(3201, WireType.String, writer);
			SubItemToken token2 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1045809045(obj as BaseSpotLight, objTypeId, writer);
			ProtoWriter.EndSubItem(token2, writer);
		}
		else if (objTypeId == 882866214)
		{
			ProtoWriter.WriteFieldHeader(3202, WireType.String, writer);
			SubItemToken token3 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize882866214(obj as BasePipeConnector, objTypeId, writer);
			ProtoWriter.EndSubItem(token3, writer);
		}
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj._constructed, writer);
		ProtoWriter.WriteFieldHeader(5, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.constructedAmount, writer);
		ProtoWriter.WriteFieldHeader(6, WireType.Variant, writer);
		ProtoWriter.WriteInt32((int)obj.techType, writer);
		ProtoWriter.WriteFieldHeader(7, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.isNew, writer);
		ProtoWriter.WriteFieldHeader(8, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.isInside, writer);
	}

	private Constructable Deserialize396637907(Constructable obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 3100)
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize817046334(obj as ConstructableBase, reader);
				ProtoReader.EndSubItem(token, reader);
			}
			else if (i == 3201)
			{
				SubItemToken token2 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1045809045(obj as BaseSpotLight, reader);
				ProtoReader.EndSubItem(token2, reader);
			}
			else
			{
				if (i != 3202)
				{
					IL_114:
					while (i > 0)
					{
						switch (i)
						{
						case 1:
							obj.version = reader.ReadInt32();
							break;
						case 2:
							obj._constructed = reader.ReadBoolean();
							break;
						case 3:
						case 4:
							goto IL_107;
						case 5:
							obj.constructedAmount = reader.ReadSingle();
							break;
						case 6:
							obj.techType = (TechType)reader.ReadInt32();
							break;
						case 7:
							obj.isNew = reader.ReadBoolean();
							break;
						case 8:
							obj.isInside = reader.ReadBoolean();
							break;
						default:
							goto IL_107;
						}
						IL_10D:
						i = reader.ReadFieldHeader();
						continue;
						IL_107:
						reader.SkipField();
						goto IL_10D;
					}
					return obj;
				}
				SubItemToken token3 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize882866214(obj as BasePipeConnector, reader);
				ProtoReader.EndSubItem(token3, reader);
			}
		}
		goto IL_114;
	}

	private void Serialize817046334(ConstructableBase obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.protoVersion, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteInt32((int)obj.faceLinkedModuleType, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1181346079(obj.faceLinkedModulePosition, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
		if (obj.moduleFace != null)
		{
			ProtoWriter.WriteFieldHeader(4, WireType.String, writer);
			SubItemToken token2 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize497398254(obj.moduleFace.GetValueOrDefault(), objTypeId, writer);
			ProtoWriter.EndSubItem(token2, writer);
		}
	}

	private ConstructableBase Deserialize817046334(ConstructableBase obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.protoVersion = reader.ReadInt32();
				break;
			case 2:
				obj.faceLinkedModuleType = (TechType)reader.ReadInt32();
				break;
			case 3:
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj.faceLinkedModulePosition = this.Deserialize1181346079(obj.faceLinkedModulePosition, reader);
				ProtoReader.EndSubItem(token, reader);
				break;
			}
			case 4:
			{
				SubItemToken token2 = ProtoReader.StartSubItem(reader);
				obj.moduleFace = new Base.Face?(this.Deserialize497398254(obj.moduleFace.GetValueOrDefault(), reader));
				ProtoReader.EndSubItem(token2, reader);
				break;
			}
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize326697518(Constructor obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.deployed, writer);
	}

	private Constructor Deserialize326697518(Constructor obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				obj.deployed = reader.ReadBoolean();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize257036954(ConstructorInput obj, int objTypeId, ProtoWriter writer)
	{
	}

	private ConstructorInput Deserialize257036954(ConstructorInput obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1998792992(CrabSnake obj, int objTypeId, ProtoWriter writer)
	{
	}

	private CrabSnake Deserialize1998792992(CrabSnake obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize49368518(CrabSquid obj, int objTypeId, ProtoWriter writer)
	{
	}

	private CrabSquid Deserialize49368518(CrabSquid obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize135876261(Crafter obj, int objTypeId, ProtoWriter writer)
	{
		if (objTypeId == 1800229096 || objTypeId == 1011566978 || objTypeId == 802993602)
		{
			ProtoWriter.WriteFieldHeader(5100, WireType.String, writer);
			SubItemToken token = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1800229096(obj as PowerCrafter, objTypeId, writer);
			ProtoWriter.EndSubItem(token, writer);
			return;
		}
		if (objTypeId == 257036954)
		{
			ProtoWriter.WriteFieldHeader(5200, WireType.String, writer);
			SubItemToken token2 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize257036954(obj as ConstructorInput, objTypeId, writer);
			ProtoWriter.EndSubItem(token2, writer);
			return;
		}
		if (objTypeId == 630473610 || objTypeId == 606619525 || objTypeId == 1333430695 || objTypeId == 309711119)
		{
			ProtoWriter.WriteFieldHeader(5500, WireType.String, writer);
			SubItemToken token3 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize630473610(obj as GhostCrafter, objTypeId, writer);
			ProtoWriter.EndSubItem(token3, writer);
			return;
		}
		if (objTypeId == 1170326782)
		{
			ProtoWriter.WriteFieldHeader(5600, WireType.String, writer);
			SubItemToken token4 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1170326782(obj as RocketConstructorInput, objTypeId, writer);
			ProtoWriter.EndSubItem(token4, writer);
		}
	}

	private Crafter Deserialize135876261(Crafter obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 5100)
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1800229096(obj as PowerCrafter, reader);
				ProtoReader.EndSubItem(token, reader);
			}
			else if (i == 5200)
			{
				SubItemToken token2 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize257036954(obj as ConstructorInput, reader);
				ProtoReader.EndSubItem(token2, reader);
			}
			else if (i == 5500)
			{
				SubItemToken token3 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize630473610(obj as GhostCrafter, reader);
				ProtoReader.EndSubItem(token3, reader);
			}
			else
			{
				if (i != 5600)
				{
					IL_BB:
					while (i > 0)
					{
						reader.SkipField();
						i = reader.ReadFieldHeader();
					}
					return obj;
				}
				SubItemToken token4 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1170326782(obj as RocketConstructorInput, reader);
				ProtoReader.EndSubItem(token4, reader);
			}
		}
		goto IL_BB;
	}

	private void Serialize2100222829(CrafterLogic obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.timeCraftingBegin, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.timeCraftingEnd, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.Variant, writer);
		ProtoWriter.WriteInt32((int)obj.craftingTechType, writer);
		ProtoWriter.WriteFieldHeader(5, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.linkedIndex, writer);
		ProtoWriter.WriteFieldHeader(6, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.numCrafted, writer);
	}

	private CrafterLogic Deserialize2100222829(CrafterLogic obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.timeCraftingBegin = reader.ReadSingle();
				break;
			case 3:
				obj.timeCraftingEnd = reader.ReadSingle();
				break;
			case 4:
				obj.craftingTechType = (TechType)reader.ReadInt32();
				break;
			case 5:
				obj.linkedIndex = reader.ReadInt32();
				break;
			case 6:
				obj.numCrafted = reader.ReadInt32();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1703576080(CraftingAnalytics obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj._serializedVersion, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj._active, writer);
		if (obj.entries != null)
		{
			foreach (KeyValuePair<TechType, CraftingAnalytics.EntryData> obj2 in obj.entries)
			{
				ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
				SubItemToken token = ProtoWriter.StartSubItem(null, writer);
				this.Serialize1158933531(obj2, objTypeId, writer);
				ProtoWriter.EndSubItem(token, writer);
			}
		}
	}

	private CraftingAnalytics Deserialize1703576080(CraftingAnalytics obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj._serializedVersion = reader.ReadInt32();
				break;
			case 2:
				obj._active = reader.ReadBoolean();
				break;
			case 3:
			{
				Dictionary<TechType, CraftingAnalytics.EntryData> dictionary = obj.entries ?? new Dictionary<TechType, CraftingAnalytics.EntryData>();
				int fieldNumber = reader.FieldNumber;
				do
				{
					KeyValuePair<TechType, CraftingAnalytics.EntryData> obj2 = default(KeyValuePair<TechType, CraftingAnalytics.EntryData>);
					SubItemToken token = ProtoReader.StartSubItem(reader);
					obj2 = this.Deserialize1158933531(obj2, reader);
					ProtoReader.EndSubItem(token, reader);
					dictionary[obj2.Key] = obj2.Value;
				}
				while (reader.TryReadFieldHeader(fieldNumber));
				break;
			}
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1103056798(CraftingAnalytics.EntryData obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.timeScanFirst, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.timeScanLast, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.craftCount, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.timeCraftFirst, writer);
		ProtoWriter.WriteFieldHeader(5, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.timeCraftLast, writer);
	}

	private CraftingAnalytics.EntryData Deserialize1103056798(CraftingAnalytics.EntryData obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.timeScanFirst = reader.ReadInt32();
				break;
			case 2:
				obj.timeScanLast = reader.ReadInt32();
				break;
			case 3:
				obj.craftCount = reader.ReadInt32();
				break;
			case 4:
				obj.timeCraftFirst = reader.ReadInt32();
				break;
			case 5:
				obj.timeCraftLast = reader.ReadInt32();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1234455261(Crash obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Crash Deserialize1234455261(Crash obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1711422107(CrashedShipExploder obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.timeToStartCountdown, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.timeSerialized, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.timeToStartWarning, writer);
	}

	private CrashedShipExploder Deserialize1711422107(CrashedShipExploder obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.timeToStartCountdown = reader.ReadSingle();
				break;
			case 2:
				obj.timeSerialized = reader.ReadSingle();
				break;
			case 3:
				obj.version = reader.ReadInt32();
				break;
			case 4:
				obj.timeToStartWarning = reader.ReadSingle();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize660968298(CrashHome obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.spawnTime, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
	}

	private CrashHome Deserialize660968298(CrashHome obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 2)
			{
				if (i != 3)
				{
					reader.SkipField();
				}
				else
				{
					obj.version = reader.ReadInt32();
				}
			}
			else
			{
				obj.spawnTime = reader.ReadSingle();
			}
		}
		return obj;
	}

	private void Serialize356643005(Creature obj, int objTypeId, ProtoWriter writer)
	{
		if (objTypeId == 829906308)
		{
			ProtoWriter.WriteFieldHeader(1000, WireType.String, writer);
			SubItemToken token = ProtoWriter.StartSubItem(null, writer);
			this.Serialize829906308(obj as BloomCreature, objTypeId, writer);
			ProtoWriter.EndSubItem(token, writer);
		}
		else if (objTypeId == 1716510642)
		{
			ProtoWriter.WriteFieldHeader(1200, WireType.String, writer);
			SubItemToken token2 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1716510642(obj as Boomerang, objTypeId, writer);
			ProtoWriter.EndSubItem(token2, writer);
		}
		else if (objTypeId == 353579366)
		{
			ProtoWriter.WriteFieldHeader(1300, WireType.String, writer);
			SubItemToken token3 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize353579366(obj as LavaLarva, objTypeId, writer);
			ProtoWriter.EndSubItem(token3, writer);
		}
		else if (objTypeId == 1829844631)
		{
			ProtoWriter.WriteFieldHeader(1400, WireType.String, writer);
			SubItemToken token4 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1829844631(obj as OculusFish, objTypeId, writer);
			ProtoWriter.EndSubItem(token4, writer);
		}
		else if (objTypeId == 351821017)
		{
			ProtoWriter.WriteFieldHeader(1500, WireType.String, writer);
			SubItemToken token5 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize351821017(obj as Eyeye, objTypeId, writer);
			ProtoWriter.EndSubItem(token5, writer);
		}
		else if (objTypeId == 1816388137)
		{
			ProtoWriter.WriteFieldHeader(1600, WireType.String, writer);
			SubItemToken token6 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1816388137(obj as Garryfish, objTypeId, writer);
			ProtoWriter.EndSubItem(token6, writer);
		}
		else if (objTypeId == 476284185)
		{
			ProtoWriter.WriteFieldHeader(1700, WireType.String, writer);
			SubItemToken token7 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize476284185(obj as GasoPod, objTypeId, writer);
			ProtoWriter.EndSubItem(token7, writer);
		}
		else if (objTypeId == 2033371878)
		{
			ProtoWriter.WriteFieldHeader(1800, WireType.String, writer);
			SubItemToken token8 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize2033371878(obj as Grabcrab, objTypeId, writer);
			ProtoWriter.EndSubItem(token8, writer);
		}
		else if (objTypeId == 697741374)
		{
			ProtoWriter.WriteFieldHeader(1900, WireType.String, writer);
			SubItemToken token9 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize697741374(obj as Grower, objTypeId, writer);
			ProtoWriter.EndSubItem(token9, writer);
		}
		else if (objTypeId == 646820922)
		{
			ProtoWriter.WriteFieldHeader(2000, WireType.String, writer);
			SubItemToken token10 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize646820922(obj as Holefish, objTypeId, writer);
			ProtoWriter.EndSubItem(token10, writer);
		}
		else if (objTypeId == 1859566378)
		{
			ProtoWriter.WriteFieldHeader(2100, WireType.String, writer);
			SubItemToken token11 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1859566378(obj as Hoverfish, objTypeId, writer);
			ProtoWriter.EndSubItem(token11, writer);
		}
		else if (objTypeId == 1338410882)
		{
			ProtoWriter.WriteFieldHeader(2200, WireType.String, writer);
			SubItemToken token12 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1338410882(obj as Jellyray, objTypeId, writer);
			ProtoWriter.EndSubItem(token12, writer);
		}
		else if (objTypeId == 1252700319)
		{
			ProtoWriter.WriteFieldHeader(2300, WireType.String, writer);
			SubItemToken token13 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1252700319(obj as Jumper, objTypeId, writer);
			ProtoWriter.EndSubItem(token13, writer);
		}
		else if (objTypeId == 1124891617)
		{
			ProtoWriter.WriteFieldHeader(2400, WireType.String, writer);
			SubItemToken token14 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1124891617(obj as Peeper, objTypeId, writer);
			ProtoWriter.EndSubItem(token14, writer);
		}
		else if (objTypeId == 1082285174)
		{
			ProtoWriter.WriteFieldHeader(2500, WireType.String, writer);
			SubItemToken token15 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1082285174(obj as RabbitRay, objTypeId, writer);
			ProtoWriter.EndSubItem(token15, writer);
		}
		else if (objTypeId == 1651949009)
		{
			ProtoWriter.WriteFieldHeader(2600, WireType.String, writer);
			SubItemToken token16 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1651949009(obj as Reefback, objTypeId, writer);
			ProtoWriter.EndSubItem(token16, writer);
		}
		else if (objTypeId == 924544622)
		{
			ProtoWriter.WriteFieldHeader(2700, WireType.String, writer);
			SubItemToken token17 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize924544622(obj as Reginald, objTypeId, writer);
			ProtoWriter.EndSubItem(token17, writer);
		}
		else if (objTypeId == 81014147)
		{
			ProtoWriter.WriteFieldHeader(2800, WireType.String, writer);
			SubItemToken token18 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize81014147(obj as SandShark, objTypeId, writer);
			ProtoWriter.EndSubItem(token18, writer);
		}
		else if (objTypeId == 647827065)
		{
			ProtoWriter.WriteFieldHeader(2900, WireType.String, writer);
			SubItemToken token19 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize647827065(obj as Spadefish, objTypeId, writer);
			ProtoWriter.EndSubItem(token19, writer);
		}
		else if (objTypeId == 1440414490)
		{
			ProtoWriter.WriteFieldHeader(3000, WireType.String, writer);
			SubItemToken token20 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1440414490(obj as Stalker, objTypeId, writer);
			ProtoWriter.EndSubItem(token20, writer);
		}
		else if (objTypeId == 953017598)
		{
			ProtoWriter.WriteFieldHeader(3100, WireType.String, writer);
			SubItemToken token21 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize953017598(obj as Bladderfish, objTypeId, writer);
			ProtoWriter.EndSubItem(token21, writer);
		}
		else if (objTypeId == 328727906)
		{
			ProtoWriter.WriteFieldHeader(3200, WireType.String, writer);
			SubItemToken token22 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize328727906(obj as Hoopfish, objTypeId, writer);
			ProtoWriter.EndSubItem(token22, writer);
		}
		else if (objTypeId == 123477383)
		{
			ProtoWriter.WriteFieldHeader(3300, WireType.String, writer);
			SubItemToken token23 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize123477383(obj as Mesmer, objTypeId, writer);
			ProtoWriter.EndSubItem(token23, writer);
		}
		else if (objTypeId == 1041366111)
		{
			ProtoWriter.WriteFieldHeader(3400, WireType.String, writer);
			SubItemToken token24 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1041366111(obj as Bleeder, objTypeId, writer);
			ProtoWriter.EndSubItem(token24, writer);
		}
		else if (objTypeId == 1355655442)
		{
			ProtoWriter.WriteFieldHeader(3500, WireType.String, writer);
			SubItemToken token25 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1355655442(obj as Slime, objTypeId, writer);
			ProtoWriter.EndSubItem(token25, writer);
		}
		else if (objTypeId == 1234455261)
		{
			ProtoWriter.WriteFieldHeader(3600, WireType.String, writer);
			SubItemToken token26 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1234455261(obj as Crash, objTypeId, writer);
			ProtoWriter.EndSubItem(token26, writer);
		}
		else if (objTypeId == 242904679)
		{
			ProtoWriter.WriteFieldHeader(3700, WireType.String, writer);
			SubItemToken token27 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize242904679(obj as BoneShark, objTypeId, writer);
			ProtoWriter.EndSubItem(token27, writer);
		}
		else if (objTypeId == 1880729675)
		{
			ProtoWriter.WriteFieldHeader(3800, WireType.String, writer);
			SubItemToken token28 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1880729675(obj as CuteFish, objTypeId, writer);
			ProtoWriter.EndSubItem(token28, writer);
		}
		else if (objTypeId == 1332964068)
		{
			ProtoWriter.WriteFieldHeader(3900, WireType.String, writer);
			SubItemToken token29 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1332964068(obj as Leviathan, objTypeId, writer);
			ProtoWriter.EndSubItem(token29, writer);
		}
		else if (objTypeId == 1702762571)
		{
			ProtoWriter.WriteFieldHeader(4000, WireType.String, writer);
			SubItemToken token30 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1702762571(obj as ReaperLeviathan, objTypeId, writer);
			ProtoWriter.EndSubItem(token30, writer);
		}
		else if (objTypeId == 1176920975)
		{
			ProtoWriter.WriteFieldHeader(4100, WireType.String, writer);
			SubItemToken token31 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1176920975(obj as CaveCrawler, objTypeId, writer);
			ProtoWriter.EndSubItem(token31, writer);
		}
		else if (objTypeId == 40841636 || objTypeId == 469144263)
		{
			ProtoWriter.WriteFieldHeader(4200, WireType.String, writer);
			SubItemToken token32 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize40841636(obj as BirdBehaviour, objTypeId, writer);
			ProtoWriter.EndSubItem(token32, writer);
		}
		else if (objTypeId == 649861234)
		{
			ProtoWriter.WriteFieldHeader(4400, WireType.String, writer);
			SubItemToken token33 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize649861234(obj as Biter, objTypeId, writer);
			ProtoWriter.EndSubItem(token33, writer);
		}
		else if (objTypeId == 1535225367)
		{
			ProtoWriter.WriteFieldHeader(4500, WireType.String, writer);
			SubItemToken token34 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1535225367(obj as Shocker, objTypeId, writer);
			ProtoWriter.EndSubItem(token34, writer);
		}
		else if (objTypeId == 1998792992)
		{
			ProtoWriter.WriteFieldHeader(4600, WireType.String, writer);
			SubItemToken token35 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1998792992(obj as CrabSnake, objTypeId, writer);
			ProtoWriter.EndSubItem(token35, writer);
		}
		else if (objTypeId == 1058623975)
		{
			ProtoWriter.WriteFieldHeader(4700, WireType.String, writer);
			SubItemToken token36 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1058623975(obj as SpineEel, objTypeId, writer);
			ProtoWriter.EndSubItem(token36, writer);
		}
		else if (objTypeId == 574222852)
		{
			ProtoWriter.WriteFieldHeader(4800, WireType.String, writer);
			SubItemToken token37 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize574222852(obj as SeaTreader, objTypeId, writer);
			ProtoWriter.EndSubItem(token37, writer);
		}
		else if (objTypeId == 49368518)
		{
			ProtoWriter.WriteFieldHeader(4900, WireType.String, writer);
			SubItemToken token38 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize49368518(obj as CrabSquid, objTypeId, writer);
			ProtoWriter.EndSubItem(token38, writer);
		}
		else if (objTypeId == 328683587)
		{
			ProtoWriter.WriteFieldHeader(4910, WireType.String, writer);
			SubItemToken token39 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize328683587(obj as Warper, objTypeId, writer);
			ProtoWriter.EndSubItem(token39, writer);
		}
		else if (objTypeId == 1882829928)
		{
			ProtoWriter.WriteFieldHeader(4920, WireType.String, writer);
			SubItemToken token40 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1882829928(obj as LavaLizard, objTypeId, writer);
			ProtoWriter.EndSubItem(token40, writer);
		}
		else if (objTypeId == 1606650114)
		{
			ProtoWriter.WriteFieldHeader(5000, WireType.String, writer);
			SubItemToken token41 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1606650114(obj as SeaDragon, objTypeId, writer);
			ProtoWriter.EndSubItem(token41, writer);
		}
		else if (objTypeId == 1389926401)
		{
			ProtoWriter.WriteFieldHeader(5100, WireType.String, writer);
			SubItemToken token42 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1389926401(obj as GhostRay, objTypeId, writer);
			ProtoWriter.EndSubItem(token42, writer);
		}
		else if (objTypeId == 1327055215)
		{
			ProtoWriter.WriteFieldHeader(5200, WireType.String, writer);
			SubItemToken token43 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1327055215(obj as SeaEmperorBaby, objTypeId, writer);
			ProtoWriter.EndSubItem(token43, writer);
		}
		else if (objTypeId == 35332337)
		{
			ProtoWriter.WriteFieldHeader(5300, WireType.String, writer);
			SubItemToken token44 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize35332337(obj as GhostLeviathan, objTypeId, writer);
			ProtoWriter.EndSubItem(token44, writer);
		}
		else if (objTypeId == 1921909083)
		{
			ProtoWriter.WriteFieldHeader(5400, WireType.String, writer);
			SubItemToken token45 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1921909083(obj as SeaEmperorJuvenile, objTypeId, writer);
			ProtoWriter.EndSubItem(token45, writer);
		}
		else if (objTypeId == 1817260405)
		{
			ProtoWriter.WriteFieldHeader(5500, WireType.String, writer);
			SubItemToken token46 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1817260405(obj as GhostLeviatanVoid, objTypeId, writer);
			ProtoWriter.EndSubItem(token46, writer);
		}
		else if (objTypeId == 1702754208)
		{
			ProtoWriter.WriteFieldHeader(5600, WireType.String, writer);
			SubItemToken token47 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1702754208(obj as GlowWhale, objTypeId, writer);
			ProtoWriter.EndSubItem(token47, writer);
		}
		else if (objTypeId == 1271521784)
		{
			ProtoWriter.WriteFieldHeader(5700, WireType.String, writer);
			SubItemToken token48 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1271521784(obj as LilyPaddler, objTypeId, writer);
			ProtoWriter.EndSubItem(token48, writer);
		}
		else if (objTypeId == 526214298)
		{
			ProtoWriter.WriteFieldHeader(5800, WireType.String, writer);
			SubItemToken token49 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize526214298(obj as Penguin, objTypeId, writer);
			ProtoWriter.EndSubItem(token49, writer);
		}
		else if (objTypeId == 1457388542)
		{
			ProtoWriter.WriteFieldHeader(5850, WireType.String, writer);
			SubItemToken token50 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1457388542(obj as PenguinBaby, objTypeId, writer);
			ProtoWriter.EndSubItem(token50, writer);
		}
		else if (objTypeId == 414351131)
		{
			ProtoWriter.WriteFieldHeader(5900, WireType.String, writer);
			SubItemToken token51 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize414351131(obj as Pinnacarid, objTypeId, writer);
			ProtoWriter.EndSubItem(token51, writer);
		}
		else if (objTypeId == 842397654)
		{
			ProtoWriter.WriteFieldHeader(6000, WireType.String, writer);
			SubItemToken token52 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize842397654(obj as RockPuncher, objTypeId, writer);
			ProtoWriter.EndSubItem(token52, writer);
		}
		else if (objTypeId == 1711042137)
		{
			ProtoWriter.WriteFieldHeader(6100, WireType.String, writer);
			SubItemToken token53 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1711042137(obj as SpinnerFish, objTypeId, writer);
			ProtoWriter.EndSubItem(token53, writer);
		}
		else if (objTypeId == 1872669462)
		{
			ProtoWriter.WriteFieldHeader(6200, WireType.String, writer);
			SubItemToken token54 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1872669462(obj as ArcticRay, objTypeId, writer);
			ProtoWriter.EndSubItem(token54, writer);
		}
		else if (objTypeId == 1070978565)
		{
			ProtoWriter.WriteFieldHeader(6300, WireType.String, writer);
			SubItemToken token55 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1070978565(obj as RockGrub, objTypeId, writer);
			ProtoWriter.EndSubItem(token55, writer);
		}
		else if (objTypeId == 3219972)
		{
			ProtoWriter.WriteFieldHeader(6400, WireType.String, writer);
			SubItemToken token56 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize3219972(obj as SymbioteFish, objTypeId, writer);
			ProtoWriter.EndSubItem(token56, writer);
		}
		else if (objTypeId == 42492657)
		{
			ProtoWriter.WriteFieldHeader(6500, WireType.String, writer);
			SubItemToken token57 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize42492657(obj as BruteShark, objTypeId, writer);
			ProtoWriter.EndSubItem(token57, writer);
		}
		else if (objTypeId == 1151491255)
		{
			ProtoWriter.WriteFieldHeader(6600, WireType.String, writer);
			SubItemToken token58 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1151491255(obj as Trivalve, objTypeId, writer);
			ProtoWriter.EndSubItem(token58, writer);
		}
		else if (objTypeId == 1238042655)
		{
			ProtoWriter.WriteFieldHeader(6700, WireType.String, writer);
			SubItemToken token59 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1238042655(obj as ArcticPeeper, objTypeId, writer);
			ProtoWriter.EndSubItem(token59, writer);
		}
		else if (objTypeId == 771173439)
		{
			ProtoWriter.WriteFieldHeader(6800, WireType.String, writer);
			SubItemToken token60 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize771173439(obj as ArrowRay, objTypeId, writer);
			ProtoWriter.EndSubItem(token60, writer);
		}
		else if (objTypeId == 615648120)
		{
			ProtoWriter.WriteFieldHeader(6900, WireType.String, writer);
			SubItemToken token61 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize615648120(obj as SeaMonkey, objTypeId, writer);
			ProtoWriter.EndSubItem(token61, writer);
		}
		else if (objTypeId == 1888807148)
		{
			ProtoWriter.WriteFieldHeader(7000, WireType.String, writer);
			SubItemToken token62 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1888807148(obj as TitanHolefish, objTypeId, writer);
			ProtoWriter.EndSubItem(token62, writer);
		}
		else if (objTypeId == 1124647116)
		{
			ProtoWriter.WriteFieldHeader(7100, WireType.String, writer);
			SubItemToken token63 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1124647116(obj as NootFish, objTypeId, writer);
			ProtoWriter.EndSubItem(token63, writer);
		}
		else if (objTypeId == 2093360837)
		{
			ProtoWriter.WriteFieldHeader(7200, WireType.String, writer);
			SubItemToken token64 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize2093360837(obj as Brinewing, objTypeId, writer);
			ProtoWriter.EndSubItem(token64, writer);
		}
		else if (objTypeId == 1386215039)
		{
			ProtoWriter.WriteFieldHeader(7300, WireType.String, writer);
			SubItemToken token65 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1386215039(obj as Triops, objTypeId, writer);
			ProtoWriter.EndSubItem(token65, writer);
		}
		else if (objTypeId == 861708591)
		{
			ProtoWriter.WriteFieldHeader(7400, WireType.String, writer);
			SubItemToken token66 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize861708591(obj as SquidShark, objTypeId, writer);
			ProtoWriter.EndSubItem(token66, writer);
		}
		else if (objTypeId == 1640880)
		{
			ProtoWriter.WriteFieldHeader(7500, WireType.String, writer);
			SubItemToken token67 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1640880(obj as SeaMonkeyBaby, objTypeId, writer);
			ProtoWriter.EndSubItem(token67, writer);
		}
		else if (objTypeId == 836898529)
		{
			ProtoWriter.WriteFieldHeader(7600, WireType.String, writer);
			SubItemToken token68 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize836898529(obj as Chelicerate, objTypeId, writer);
			ProtoWriter.EndSubItem(token68, writer);
		}
		else if (objTypeId == 1008105993)
		{
			ProtoWriter.WriteFieldHeader(7700, WireType.String, writer);
			SubItemToken token69 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1008105993(obj as SnowStalker, objTypeId, writer);
			ProtoWriter.EndSubItem(token69, writer);
		}
		else if (objTypeId == 1630308817)
		{
			ProtoWriter.WriteFieldHeader(7750, WireType.String, writer);
			SubItemToken token70 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1630308817(obj as SnowStalkerBaby, objTypeId, writer);
			ProtoWriter.EndSubItem(token70, writer);
		}
		else if (objTypeId == 1794521971)
		{
			ProtoWriter.WriteFieldHeader(7800, WireType.String, writer);
			SubItemToken token71 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1794521971(obj as FeatherFish, objTypeId, writer);
			ProtoWriter.EndSubItem(token71, writer);
		}
		else if (objTypeId == 1191484888)
		{
			ProtoWriter.WriteFieldHeader(7900, WireType.String, writer);
			SubItemToken token72 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1191484888(obj as ShadowLeviathan, objTypeId, writer);
			ProtoWriter.EndSubItem(token72, writer);
		}
		else if (objTypeId == 1941291928)
		{
			ProtoWriter.WriteFieldHeader(8000, WireType.String, writer);
			SubItemToken token73 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1941291928(obj as Jellyfish, objTypeId, writer);
			ProtoWriter.EndSubItem(token73, writer);
		}
		else if (objTypeId == 236473635)
		{
			ProtoWriter.WriteFieldHeader(8100, WireType.String, writer);
			SubItemToken token74 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize236473635(obj as DiscusFish, objTypeId, writer);
			ProtoWriter.EndSubItem(token74, writer);
		}
		else if (objTypeId == 1287561620)
		{
			ProtoWriter.WriteFieldHeader(8200, WireType.String, writer);
			SubItemToken token75 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1287561620(obj as Cryptosuchus, objTypeId, writer);
			ProtoWriter.EndSubItem(token75, writer);
		}
		else if (objTypeId == 252526906)
		{
			ProtoWriter.WriteFieldHeader(8300, WireType.String, writer);
			SubItemToken token76 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize252526906(obj as VoidLeviathan, objTypeId, writer);
			ProtoWriter.EndSubItem(token76, writer);
		}
		ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
		SubItemToken token77 = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1181346079(obj.leashPosition, objTypeId, writer);
		ProtoWriter.EndSubItem(token77, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.isInitialized, writer);
	}

	private Creature Deserialize356643005(Creature obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1000)
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize829906308(obj as BloomCreature, reader);
				ProtoReader.EndSubItem(token, reader);
			}
			else if (i == 1200)
			{
				SubItemToken token2 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1716510642(obj as Boomerang, reader);
				ProtoReader.EndSubItem(token2, reader);
			}
			else if (i == 1300)
			{
				SubItemToken token3 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize353579366(obj as LavaLarva, reader);
				ProtoReader.EndSubItem(token3, reader);
			}
			else if (i == 1400)
			{
				SubItemToken token4 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1829844631(obj as OculusFish, reader);
				ProtoReader.EndSubItem(token4, reader);
			}
			else if (i == 1500)
			{
				SubItemToken token5 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize351821017(obj as Eyeye, reader);
				ProtoReader.EndSubItem(token5, reader);
			}
			else if (i == 1600)
			{
				SubItemToken token6 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1816388137(obj as Garryfish, reader);
				ProtoReader.EndSubItem(token6, reader);
			}
			else if (i == 1700)
			{
				SubItemToken token7 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize476284185(obj as GasoPod, reader);
				ProtoReader.EndSubItem(token7, reader);
			}
			else if (i == 1800)
			{
				SubItemToken token8 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize2033371878(obj as Grabcrab, reader);
				ProtoReader.EndSubItem(token8, reader);
			}
			else if (i == 1900)
			{
				SubItemToken token9 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize697741374(obj as Grower, reader);
				ProtoReader.EndSubItem(token9, reader);
			}
			else if (i == 2000)
			{
				SubItemToken token10 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize646820922(obj as Holefish, reader);
				ProtoReader.EndSubItem(token10, reader);
			}
			else if (i == 2100)
			{
				SubItemToken token11 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1859566378(obj as Hoverfish, reader);
				ProtoReader.EndSubItem(token11, reader);
			}
			else if (i == 2200)
			{
				SubItemToken token12 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1338410882(obj as Jellyray, reader);
				ProtoReader.EndSubItem(token12, reader);
			}
			else if (i == 2300)
			{
				SubItemToken token13 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1252700319(obj as Jumper, reader);
				ProtoReader.EndSubItem(token13, reader);
			}
			else if (i == 2400)
			{
				SubItemToken token14 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1124891617(obj as Peeper, reader);
				ProtoReader.EndSubItem(token14, reader);
			}
			else if (i == 2500)
			{
				SubItemToken token15 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1082285174(obj as RabbitRay, reader);
				ProtoReader.EndSubItem(token15, reader);
			}
			else if (i == 2600)
			{
				SubItemToken token16 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1651949009(obj as Reefback, reader);
				ProtoReader.EndSubItem(token16, reader);
			}
			else if (i == 2700)
			{
				SubItemToken token17 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize924544622(obj as Reginald, reader);
				ProtoReader.EndSubItem(token17, reader);
			}
			else if (i == 2800)
			{
				SubItemToken token18 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize81014147(obj as SandShark, reader);
				ProtoReader.EndSubItem(token18, reader);
			}
			else if (i == 2900)
			{
				SubItemToken token19 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize647827065(obj as Spadefish, reader);
				ProtoReader.EndSubItem(token19, reader);
			}
			else if (i == 3000)
			{
				SubItemToken token20 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1440414490(obj as Stalker, reader);
				ProtoReader.EndSubItem(token20, reader);
			}
			else if (i == 3100)
			{
				SubItemToken token21 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize953017598(obj as Bladderfish, reader);
				ProtoReader.EndSubItem(token21, reader);
			}
			else if (i == 3200)
			{
				SubItemToken token22 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize328727906(obj as Hoopfish, reader);
				ProtoReader.EndSubItem(token22, reader);
			}
			else if (i == 3300)
			{
				SubItemToken token23 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize123477383(obj as Mesmer, reader);
				ProtoReader.EndSubItem(token23, reader);
			}
			else if (i == 3400)
			{
				SubItemToken token24 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1041366111(obj as Bleeder, reader);
				ProtoReader.EndSubItem(token24, reader);
			}
			else if (i == 3500)
			{
				SubItemToken token25 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1355655442(obj as Slime, reader);
				ProtoReader.EndSubItem(token25, reader);
			}
			else if (i == 3600)
			{
				SubItemToken token26 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1234455261(obj as Crash, reader);
				ProtoReader.EndSubItem(token26, reader);
			}
			else if (i == 3700)
			{
				SubItemToken token27 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize242904679(obj as BoneShark, reader);
				ProtoReader.EndSubItem(token27, reader);
			}
			else if (i == 3800)
			{
				SubItemToken token28 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1880729675(obj as CuteFish, reader);
				ProtoReader.EndSubItem(token28, reader);
			}
			else if (i == 3900)
			{
				SubItemToken token29 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1332964068(obj as Leviathan, reader);
				ProtoReader.EndSubItem(token29, reader);
			}
			else if (i == 4000)
			{
				SubItemToken token30 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1702762571(obj as ReaperLeviathan, reader);
				ProtoReader.EndSubItem(token30, reader);
			}
			else if (i == 4100)
			{
				SubItemToken token31 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1176920975(obj as CaveCrawler, reader);
				ProtoReader.EndSubItem(token31, reader);
			}
			else if (i == 4200)
			{
				SubItemToken token32 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize40841636(obj as BirdBehaviour, reader);
				ProtoReader.EndSubItem(token32, reader);
			}
			else if (i == 4400)
			{
				SubItemToken token33 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize649861234(obj as Biter, reader);
				ProtoReader.EndSubItem(token33, reader);
			}
			else if (i == 4500)
			{
				SubItemToken token34 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1535225367(obj as Shocker, reader);
				ProtoReader.EndSubItem(token34, reader);
			}
			else if (i == 4600)
			{
				SubItemToken token35 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1998792992(obj as CrabSnake, reader);
				ProtoReader.EndSubItem(token35, reader);
			}
			else if (i == 4700)
			{
				SubItemToken token36 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1058623975(obj as SpineEel, reader);
				ProtoReader.EndSubItem(token36, reader);
			}
			else if (i == 4800)
			{
				SubItemToken token37 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize574222852(obj as SeaTreader, reader);
				ProtoReader.EndSubItem(token37, reader);
			}
			else if (i == 4900)
			{
				SubItemToken token38 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize49368518(obj as CrabSquid, reader);
				ProtoReader.EndSubItem(token38, reader);
			}
			else if (i == 4910)
			{
				SubItemToken token39 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize328683587(obj as Warper, reader);
				ProtoReader.EndSubItem(token39, reader);
			}
			else if (i == 4920)
			{
				SubItemToken token40 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1882829928(obj as LavaLizard, reader);
				ProtoReader.EndSubItem(token40, reader);
			}
			else if (i == 5000)
			{
				SubItemToken token41 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1606650114(obj as SeaDragon, reader);
				ProtoReader.EndSubItem(token41, reader);
			}
			else if (i == 5100)
			{
				SubItemToken token42 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1389926401(obj as GhostRay, reader);
				ProtoReader.EndSubItem(token42, reader);
			}
			else if (i == 5200)
			{
				SubItemToken token43 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1327055215(obj as SeaEmperorBaby, reader);
				ProtoReader.EndSubItem(token43, reader);
			}
			else if (i == 5300)
			{
				SubItemToken token44 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize35332337(obj as GhostLeviathan, reader);
				ProtoReader.EndSubItem(token44, reader);
			}
			else if (i == 5400)
			{
				SubItemToken token45 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1921909083(obj as SeaEmperorJuvenile, reader);
				ProtoReader.EndSubItem(token45, reader);
			}
			else if (i == 5500)
			{
				SubItemToken token46 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1817260405(obj as GhostLeviatanVoid, reader);
				ProtoReader.EndSubItem(token46, reader);
			}
			else if (i == 5600)
			{
				SubItemToken token47 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1702754208(obj as GlowWhale, reader);
				ProtoReader.EndSubItem(token47, reader);
			}
			else if (i == 5700)
			{
				SubItemToken token48 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1271521784(obj as LilyPaddler, reader);
				ProtoReader.EndSubItem(token48, reader);
			}
			else if (i == 5800)
			{
				SubItemToken token49 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize526214298(obj as Penguin, reader);
				ProtoReader.EndSubItem(token49, reader);
			}
			else if (i == 5850)
			{
				SubItemToken token50 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1457388542(obj as PenguinBaby, reader);
				ProtoReader.EndSubItem(token50, reader);
			}
			else if (i == 5900)
			{
				SubItemToken token51 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize414351131(obj as Pinnacarid, reader);
				ProtoReader.EndSubItem(token51, reader);
			}
			else if (i == 6000)
			{
				SubItemToken token52 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize842397654(obj as RockPuncher, reader);
				ProtoReader.EndSubItem(token52, reader);
			}
			else if (i == 6100)
			{
				SubItemToken token53 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1711042137(obj as SpinnerFish, reader);
				ProtoReader.EndSubItem(token53, reader);
			}
			else if (i == 6200)
			{
				SubItemToken token54 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1872669462(obj as ArcticRay, reader);
				ProtoReader.EndSubItem(token54, reader);
			}
			else if (i == 6300)
			{
				SubItemToken token55 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1070978565(obj as RockGrub, reader);
				ProtoReader.EndSubItem(token55, reader);
			}
			else if (i == 6400)
			{
				SubItemToken token56 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize3219972(obj as SymbioteFish, reader);
				ProtoReader.EndSubItem(token56, reader);
			}
			else if (i == 6500)
			{
				SubItemToken token57 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize42492657(obj as BruteShark, reader);
				ProtoReader.EndSubItem(token57, reader);
			}
			else if (i == 6600)
			{
				SubItemToken token58 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1151491255(obj as Trivalve, reader);
				ProtoReader.EndSubItem(token58, reader);
			}
			else if (i == 6700)
			{
				SubItemToken token59 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1238042655(obj as ArcticPeeper, reader);
				ProtoReader.EndSubItem(token59, reader);
			}
			else if (i == 6800)
			{
				SubItemToken token60 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize771173439(obj as ArrowRay, reader);
				ProtoReader.EndSubItem(token60, reader);
			}
			else if (i == 6900)
			{
				SubItemToken token61 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize615648120(obj as SeaMonkey, reader);
				ProtoReader.EndSubItem(token61, reader);
			}
			else if (i == 7000)
			{
				SubItemToken token62 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1888807148(obj as TitanHolefish, reader);
				ProtoReader.EndSubItem(token62, reader);
			}
			else if (i == 7100)
			{
				SubItemToken token63 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1124647116(obj as NootFish, reader);
				ProtoReader.EndSubItem(token63, reader);
			}
			else if (i == 7200)
			{
				SubItemToken token64 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize2093360837(obj as Brinewing, reader);
				ProtoReader.EndSubItem(token64, reader);
			}
			else if (i == 7300)
			{
				SubItemToken token65 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1386215039(obj as Triops, reader);
				ProtoReader.EndSubItem(token65, reader);
			}
			else if (i == 7400)
			{
				SubItemToken token66 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize861708591(obj as SquidShark, reader);
				ProtoReader.EndSubItem(token66, reader);
			}
			else if (i == 7500)
			{
				SubItemToken token67 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1640880(obj as SeaMonkeyBaby, reader);
				ProtoReader.EndSubItem(token67, reader);
			}
			else if (i == 7600)
			{
				SubItemToken token68 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize836898529(obj as Chelicerate, reader);
				ProtoReader.EndSubItem(token68, reader);
			}
			else if (i == 7700)
			{
				SubItemToken token69 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1008105993(obj as SnowStalker, reader);
				ProtoReader.EndSubItem(token69, reader);
			}
			else if (i == 7750)
			{
				SubItemToken token70 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1630308817(obj as SnowStalkerBaby, reader);
				ProtoReader.EndSubItem(token70, reader);
			}
			else if (i == 7800)
			{
				SubItemToken token71 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1794521971(obj as FeatherFish, reader);
				ProtoReader.EndSubItem(token71, reader);
			}
			else if (i == 7900)
			{
				SubItemToken token72 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1191484888(obj as ShadowLeviathan, reader);
				ProtoReader.EndSubItem(token72, reader);
			}
			else if (i == 8000)
			{
				SubItemToken token73 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1941291928(obj as Jellyfish, reader);
				ProtoReader.EndSubItem(token73, reader);
			}
			else if (i == 8100)
			{
				SubItemToken token74 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize236473635(obj as DiscusFish, reader);
				ProtoReader.EndSubItem(token74, reader);
			}
			else if (i == 8200)
			{
				SubItemToken token75 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1287561620(obj as Cryptosuchus, reader);
				ProtoReader.EndSubItem(token75, reader);
			}
			else
			{
				if (i != 8300)
				{
					IL_C51:
					while (i > 0)
					{
						switch (i)
						{
						case 1:
						{
							SubItemToken token76 = ProtoReader.StartSubItem(reader);
							obj.leashPosition = this.Deserialize1181346079(obj.leashPosition, reader);
							ProtoReader.EndSubItem(token76, reader);
							break;
						}
						case 2:
							obj.version = reader.ReadInt32();
							break;
						case 3:
							obj.isInitialized = reader.ReadBoolean();
							break;
						default:
							reader.SkipField();
							break;
						}
						i = reader.ReadFieldHeader();
					}
					return obj;
				}
				SubItemToken token77 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize252526906(obj as VoidLeviathan, reader);
				ProtoReader.EndSubItem(token77, reader);
			}
		}
		goto IL_C51;
	}

	private void Serialize406373562(CreatureBehaviour obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1181346079(obj.leashPosition, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
	}

	private CreatureBehaviour Deserialize406373562(CreatureBehaviour obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj.leashPosition = this.Deserialize1181346079(obj.leashPosition, reader);
				ProtoReader.EndSubItem(token, reader);
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize801838245(CreatureDeath obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.hasSpawnedRespawner, writer);
	}

	private CreatureDeath Deserialize801838245(CreatureDeath obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				obj.hasSpawnedRespawner = reader.ReadBoolean();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize59821228(CreatureEgg obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.progress, writer);
	}

	private CreatureEgg Deserialize59821228(CreatureEgg obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.progress = reader.ReadSingle();
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize2001815917(CreatureFriend obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed64, writer);
		ProtoWriter.WriteDouble(obj.timeFriendshipEnd, writer);
		if (obj.currentFriendUID != null)
		{
			ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
			ProtoWriter.WriteString(obj.currentFriendUID, writer);
		}
	}

	private CreatureFriend Deserialize2001815917(CreatureFriend obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.timeFriendshipEnd = reader.ReadDouble();
				break;
			case 3:
				obj.currentFriendUID = reader.ReadString();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize730995178(CreepvineSeed obj, int objTypeId, ProtoWriter writer)
	{
	}

	private CreepvineSeed Deserialize730995178(CreepvineSeed obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1287561620(Cryptosuchus obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Cryptosuchus Deserialize1287561620(Cryptosuchus obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize860890656(CurrentGenerator obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.isActive, writer);
	}

	private CurrentGenerator Deserialize860890656(CurrentGenerator obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				obj.isActive = reader.ReadBoolean();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize1880729675(CuteFish obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj._followingPlayer, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj._goodbyePlayed, writer);
	}

	private CuteFish Deserialize1880729675(CuteFish obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj._goodbyePlayed = reader.ReadBoolean();
				}
			}
			else
			{
				obj._followingPlayer = reader.ReadBoolean();
			}
		}
		return obj;
	}

	private void Serialize1489909791(CyclopsDecoyLoadingTube obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		if (obj.serializedDecoySlots != null)
		{
			foreach (KeyValuePair<string, string> obj2 in obj.serializedDecoySlots)
			{
				ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
				SubItemToken token = ProtoWriter.StartSubItem(null, writer);
				this.Serialize524780017(obj2, objTypeId, writer);
				ProtoWriter.EndSubItem(token, writer);
			}
		}
	}

	private CyclopsDecoyLoadingTube Deserialize1489909791(CyclopsDecoyLoadingTube obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					Dictionary<string, string> dictionary = new Dictionary<string, string>();
					int fieldNumber = reader.FieldNumber;
					do
					{
						KeyValuePair<string, string> obj2 = default(KeyValuePair<string, string>);
						SubItemToken token = ProtoReader.StartSubItem(reader);
						obj2 = this.Deserialize524780017(obj2, reader);
						ProtoReader.EndSubItem(token, reader);
						dictionary[obj2.Key] = obj2.Value;
					}
					while (reader.TryReadFieldHeader(fieldNumber));
					obj.serializedDecoySlots = dictionary;
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize2083308735(CyclopsLightingPanel obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.lightingOn, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.floodlightsOn, writer);
	}

	private CyclopsLightingPanel Deserialize2083308735(CyclopsLightingPanel obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.floodlightsOn = reader.ReadBoolean();
				}
			}
			else
			{
				obj.lightingOn = reader.ReadBoolean();
			}
		}
		return obj;
	}

	private void Serialize2062152363(CyclopsMotorMode obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.engineOn, writer);
	}

	private CyclopsMotorMode Deserialize2062152363(CyclopsMotorMode obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.engineOn = reader.ReadBoolean();
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize315488296(DayNightCycle obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.timePassedDeprecated, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Fixed64, writer);
		ProtoWriter.WriteDouble(obj.timePassedAsDouble, writer);
	}

	private DayNightCycle Deserialize315488296(DayNightCycle obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.timePassedDeprecated = reader.ReadSingle();
				break;
			case 3:
				obj.timePassedAsDouble = reader.ReadDouble();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize26260290(DayNightLight obj, int objTypeId, ProtoWriter writer)
	{
		if (obj.colorR != null)
		{
			ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
			SubItemToken token = ProtoWriter.StartSubItem(obj.colorR, writer);
			this.Serialize118512508(obj.colorR, objTypeId, writer);
			ProtoWriter.EndSubItem(token, writer);
		}
		if (obj.colorG != null)
		{
			ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
			SubItemToken token2 = ProtoWriter.StartSubItem(obj.colorG, writer);
			this.Serialize118512508(obj.colorG, objTypeId, writer);
			ProtoWriter.EndSubItem(token2, writer);
		}
		if (obj.colorB != null)
		{
			ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
			SubItemToken token3 = ProtoWriter.StartSubItem(obj.colorB, writer);
			this.Serialize118512508(obj.colorB, objTypeId, writer);
			ProtoWriter.EndSubItem(token3, writer);
		}
		if (obj.intensity != null)
		{
			ProtoWriter.WriteFieldHeader(4, WireType.String, writer);
			SubItemToken token4 = ProtoWriter.StartSubItem(obj.intensity, writer);
			this.Serialize118512508(obj.intensity, objTypeId, writer);
			ProtoWriter.EndSubItem(token4, writer);
		}
		if (obj.sunFraction != null)
		{
			ProtoWriter.WriteFieldHeader(5, WireType.String, writer);
			SubItemToken token5 = ProtoWriter.StartSubItem(obj.sunFraction, writer);
			this.Serialize118512508(obj.sunFraction, objTypeId, writer);
			ProtoWriter.EndSubItem(token5, writer);
		}
	}

	private DayNightLight Deserialize26260290(DayNightLight obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj.colorR = this.Deserialize118512508(obj.colorR, reader);
				ProtoReader.EndSubItem(token, reader);
				break;
			}
			case 2:
			{
				SubItemToken token2 = ProtoReader.StartSubItem(reader);
				obj.colorG = this.Deserialize118512508(obj.colorG, reader);
				ProtoReader.EndSubItem(token2, reader);
				break;
			}
			case 3:
			{
				SubItemToken token3 = ProtoReader.StartSubItem(reader);
				obj.colorB = this.Deserialize118512508(obj.colorB, reader);
				ProtoReader.EndSubItem(token3, reader);
				break;
			}
			case 4:
			{
				SubItemToken token4 = ProtoReader.StartSubItem(reader);
				obj.intensity = this.Deserialize118512508(obj.intensity, reader);
				ProtoReader.EndSubItem(token4, reader);
				break;
			}
			case 5:
			{
				SubItemToken token5 = ProtoReader.StartSubItem(reader);
				obj.sunFraction = this.Deserialize118512508(obj.sunFraction, reader);
				ProtoReader.EndSubItem(token5, reader);
				break;
			}
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize658541966(DeployableDrill obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.deployed, writer);
	}

	private DeployableDrill Deserialize658541966(DeployableDrill obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.deployed = reader.ReadBoolean();
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize898747676(DisableBeforeExplosion obj, int objTypeId, ProtoWriter writer)
	{
	}

	private DisableBeforeExplosion Deserialize898747676(DisableBeforeExplosion obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize236473635(DiscusFish obj, int objTypeId, ProtoWriter writer)
	{
	}

	private DiscusFish Deserialize236473635(DiscusFish obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize10881664(DiveReel obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.state, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		if (obj.nodePositions != null)
		{
			foreach (Vector3 obj2 in obj.nodePositions)
			{
				ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
				SubItemToken token = ProtoWriter.StartSubItem(null, writer);
				this.Serialize1181346079(obj2, objTypeId, writer);
				ProtoWriter.EndSubItem(token, writer);
			}
		}
	}

	private DiveReel Deserialize10881664(DiveReel obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.state = reader.ReadInt32();
				break;
			case 2:
				obj.version = reader.ReadInt32();
				break;
			case 3:
			{
				List<Vector3> list = new List<Vector3>();
				int fieldNumber = reader.FieldNumber;
				do
				{
					Vector3 vector = default(Vector3);
					SubItemToken token = ProtoReader.StartSubItem(reader);
					vector = this.Deserialize1181346079(vector, reader);
					ProtoReader.EndSubItem(token, reader);
					list.Add(vector);
				}
				while (reader.TryReadFieldHeader(fieldNumber));
				obj.nodePositions = list;
				break;
			}
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1954617231(DiveReelAnchor obj, int objTypeId, ProtoWriter writer)
	{
		if (obj.reelId != null)
		{
			ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
			ProtoWriter.WriteString(obj.reelId, writer);
		}
		if (obj.contactPts != null)
		{
			foreach (Vector3 obj2 in obj.contactPts)
			{
				ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
				SubItemToken token = ProtoWriter.StartSubItem(null, writer);
				this.Serialize1181346079(obj2, objTypeId, writer);
				ProtoWriter.EndSubItem(token, writer);
			}
		}
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.lastContactUnraveling, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.String, writer);
		SubItemToken token2 = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1181346079(obj.prevLineEndPos, objTypeId, writer);
		ProtoWriter.EndSubItem(token2, writer);
		ProtoWriter.WriteFieldHeader(5, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.reelWasDropped, writer);
	}

	private DiveReelAnchor Deserialize1954617231(DiveReelAnchor obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.reelId = reader.ReadString();
				break;
			case 2:
			{
				List<Vector3> list = obj.contactPts ?? new List<Vector3>();
				int fieldNumber = reader.FieldNumber;
				do
				{
					Vector3 vector = default(Vector3);
					SubItemToken token = ProtoReader.StartSubItem(reader);
					vector = this.Deserialize1181346079(vector, reader);
					ProtoReader.EndSubItem(token, reader);
					list.Add(vector);
				}
				while (reader.TryReadFieldHeader(fieldNumber));
				break;
			}
			case 3:
				obj.lastContactUnraveling = reader.ReadBoolean();
				break;
			case 4:
			{
				SubItemToken token2 = ProtoReader.StartSubItem(reader);
				obj.prevLineEndPos = this.Deserialize1181346079(obj.prevLineEndPos, reader);
				ProtoReader.EndSubItem(token2, reader);
				break;
			}
			case 5:
				obj.reelWasDropped = reader.ReadBoolean();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize205226061(Dockable obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.docked, writer);
	}

	private Dockable Deserialize205226061(Dockable obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				obj.docked = reader.ReadBoolean();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize2100518191(Drillable obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		if (obj.health != null)
		{
			foreach (float value in obj.health)
			{
				ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
				ProtoWriter.WriteSingle(value, writer);
			}
		}
	}

	private Drillable Deserialize2100518191(Drillable obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					List<float> list = new List<float>();
					int fieldNumber = reader.FieldNumber;
					do
					{
						float item = reader.ReadSingle();
						list.Add(item);
					}
					while (reader.TryReadFieldHeader(fieldNumber));
					obj.health = list.ToArray();
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize662718200(DropEnzymes obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.timeNextDrop, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.firstDrop, writer);
	}

	private DropEnzymes Deserialize662718200(DropEnzymes obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.firstDrop = reader.ReadBoolean();
				}
			}
			else
			{
				obj.timeNextDrop = reader.ReadSingle();
			}
		}
		return obj;
	}

	private void Serialize790665541(Durable obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Durable Deserialize790665541(Durable obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1080881920(Eatable obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.timeDecayStart, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.decayPaused, writer);
		ProtoWriter.WriteFieldHeader(5, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.timeDecayPause, writer);
		ProtoWriter.WriteFieldHeader(6, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.charges, writer);
	}

	private Eatable Deserialize1080881920(Eatable obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		while (i > 0)
		{
			switch (i)
			{
			case 1:
				obj.timeDecayStart = reader.ReadSingle();
				break;
			case 2:
			case 3:
				goto IL_63;
			case 4:
				obj.decayPaused = reader.ReadBoolean();
				break;
			case 5:
				obj.timeDecayPause = reader.ReadSingle();
				break;
			case 6:
				obj.charges = reader.ReadInt32();
				break;
			default:
				goto IL_63;
			}
			IL_69:
			i = reader.ReadFieldHeader();
			continue;
			IL_63:
			reader.SkipField();
			goto IL_69;
		}
		return obj;
	}

	private void Serialize1427962681(EnergyMixin obj, int objTypeId, ProtoWriter writer)
	{
		if (objTypeId == 929691462)
		{
			ProtoWriter.WriteFieldHeader(1000, WireType.String, writer);
			SubItemToken token = ProtoWriter.StartSubItem(null, writer);
			this.Serialize929691462(obj as BatterySource, objTypeId, writer);
			ProtoWriter.EndSubItem(token, writer);
		}
		ProtoWriter.WriteFieldHeader(1, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.energy, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.maxEnergy, writer);
	}

	private EnergyMixin Deserialize1427962681(EnergyMixin obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1000)
			{
				IL_6C:
				while (i > 0)
				{
					if (i != 1)
					{
						if (i != 2)
						{
							reader.SkipField();
						}
						else
						{
							obj.maxEnergy = reader.ReadSingle();
						}
					}
					else
					{
						obj.energy = reader.ReadSingle();
					}
					i = reader.ReadFieldHeader();
				}
				return obj;
			}
			SubItemToken token = ProtoReader.StartSubItem(reader);
			obj = this.Deserialize929691462(obj as BatterySource, reader);
			ProtoReader.EndSubItem(token, reader);
		}
		goto IL_6C;
	}

	private void Serialize1922274571(EntitySlot obj, int objTypeId, ProtoWriter writer)
	{
		if (obj.allowedTypes != null)
		{
			foreach (int value in obj.allowedTypes)
			{
				ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
				ProtoWriter.WriteInt32(value, writer);
			}
		}
		ProtoWriter.WriteFieldHeader(4, WireType.Variant, writer);
		ProtoWriter.WriteInt32((int)obj.biomeType, writer);
		ProtoWriter.WriteFieldHeader(6, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.autoGenerated, writer);
		ProtoWriter.WriteFieldHeader(7, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.density, writer);
	}

	private EntitySlot Deserialize1922274571(EntitySlot obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		while (i > 0)
		{
			switch (i)
			{
			case 2:
			{
				List<EntitySlot.Type> list = new List<EntitySlot.Type>();
				int fieldNumber = reader.FieldNumber;
				do
				{
					EntitySlot.Type item = (EntitySlot.Type)reader.ReadInt32();
					list.Add(item);
				}
				while (reader.TryReadFieldHeader(fieldNumber));
				obj.allowedTypes = list;
				break;
			}
			case 3:
			case 5:
				goto IL_87;
			case 4:
				obj.biomeType = (BiomeType)reader.ReadInt32();
				break;
			case 6:
				obj.autoGenerated = reader.ReadBoolean();
				break;
			case 7:
				obj.density = reader.ReadSingle();
				break;
			default:
				goto IL_87;
			}
			IL_8D:
			i = reader.ReadFieldHeader();
			continue;
			IL_87:
			reader.SkipField();
			goto IL_8D;
		}
		return obj;
	}

	private void Serialize1404549125(EntitySlotData obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteInt32((int)obj.biomeType, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteInt32((int)obj.allowedTypes, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.density, writer);
		ProtoWriter.WriteFieldHeader(5, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1181346079(obj.localPosition, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
		ProtoWriter.WriteFieldHeader(6, WireType.String, writer);
		SubItemToken token2 = ProtoWriter.StartSubItem(null, writer);
		this.Serialize605020259(obj.localRotation, objTypeId, writer);
		ProtoWriter.EndSubItem(token2, writer);
	}

	private EntitySlotData Deserialize1404549125(EntitySlotData obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		if (obj == null)
		{
			obj = new EntitySlotData();
			ProtoReader.NoteObject(obj, reader);
		}
		while (i > 0)
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.biomeType = (BiomeType)reader.ReadInt32();
				break;
			case 3:
				obj.allowedTypes = (EntitySlotData.EntitySlotType)reader.ReadInt32();
				break;
			case 4:
				obj.density = reader.ReadSingle();
				break;
			case 5:
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj.localPosition = this.Deserialize1181346079(obj.localPosition, reader);
				ProtoReader.EndSubItem(token, reader);
				break;
			}
			case 6:
			{
				SubItemToken token2 = ProtoReader.StartSubItem(reader);
				obj.localRotation = this.Deserialize605020259(obj.localRotation, reader);
				ProtoReader.EndSubItem(token2, reader);
				break;
			}
			default:
				reader.SkipField();
				break;
			}
			i = reader.ReadFieldHeader();
		}
		return obj;
	}

	private void Serialize1971823303(EntitySlotsPlaceholder obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		if (obj.slotsData != null)
		{
			foreach (EntitySlotData entitySlotData in obj.slotsData)
			{
				if (entitySlotData != null)
				{
					ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
					SubItemToken token = ProtoWriter.StartSubItem(entitySlotData, writer);
					this.Serialize1404549125(entitySlotData, objTypeId, writer);
					ProtoWriter.EndSubItem(token, writer);
				}
			}
		}
	}

	private EntitySlotsPlaceholder Deserialize1971823303(EntitySlotsPlaceholder obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					List<EntitySlotData> list = new List<EntitySlotData>();
					int fieldNumber = reader.FieldNumber;
					do
					{
						EntitySlotData entitySlotData = new EntitySlotData();
						SubItemToken token = ProtoReader.StartSubItem(reader);
						entitySlotData = this.Deserialize1404549125(entitySlotData, reader);
						ProtoReader.EndSubItem(token, reader);
						list.Add(entitySlotData);
					}
					while (reader.TryReadFieldHeader(fieldNumber));
					obj.slotsData = list.ToArray();
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize387767963(ExchangerRocketConstructor obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.spawnFirstExchanger, writer);
	}

	private ExchangerRocketConstructor Deserialize387767963(ExchangerRocketConstructor obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				obj.spawnFirstExchanger = reader.ReadBoolean();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize1433797848(ExecutionOrderTest obj, int objTypeId, ProtoWriter writer)
	{
	}

	private ExecutionOrderTest Deserialize1433797848(ExecutionOrderTest obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1174302959(Exosuit obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Exosuit Deserialize1174302959(Exosuit obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize351821017(Eyeye obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Eyeye Deserialize351821017(Eyeye obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize606619525(Fabricator obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Fabricator Deserialize606619525(Fabricator obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize776720259(FairRandomizer obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.timeLastCheck, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.entropy, writer);
	}

	private FairRandomizer Deserialize776720259(FairRandomizer obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.timeLastCheck = reader.ReadSingle();
				break;
			case 3:
				obj.entropy = reader.ReadSingle();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1794521971(FeatherFish obj, int objTypeId, ProtoWriter writer)
	{
	}

	private FeatherFish Deserialize1794521971(FeatherFish obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1004993247(FiltrationMachine obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.timeRemainingWater, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.timeRemainingSalt, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize497398254(obj._moduleFace, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
		ProtoWriter.WriteFieldHeader(5, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj._constructed, writer);
	}

	private FiltrationMachine Deserialize1004993247(FiltrationMachine obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.timeRemainingWater = reader.ReadSingle();
				break;
			case 3:
				obj.timeRemainingSalt = reader.ReadSingle();
				break;
			case 4:
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj._moduleFace = this.Deserialize497398254(obj._moduleFace, reader);
				ProtoReader.EndSubItem(token, reader);
				break;
			}
			case 5:
				obj._constructed = reader.ReadSingle();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize325421431(FireExtinguisher obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.fuel, writer);
	}

	private FireExtinguisher Deserialize325421431(FireExtinguisher obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				obj.fuel = reader.ReadSingle();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize1618351061(FireExtinguisherHolder obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.hasTank, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.fuel, writer);
	}

	private FireExtinguisherHolder Deserialize1618351061(FireExtinguisherHolder obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.hasTank = reader.ReadBoolean();
				break;
			case 3:
				obj.fuel = reader.ReadSingle();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize331658349(FixedBase obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.currentVersion, writer);
		if (obj.bulkheadDoorsStates != null)
		{
			foreach (bool value in obj.bulkheadDoorsStates)
			{
				ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
				ProtoWriter.WriteBoolean(value, writer);
			}
		}
	}

	private FixedBase Deserialize331658349(FixedBase obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					List<bool> list = new List<bool>();
					int fieldNumber = reader.FieldNumber;
					do
					{
						bool item = reader.ReadBoolean();
						list.Add(item);
					}
					while (reader.TryReadFieldHeader(fieldNumber));
					obj.bulkheadDoorsStates = list.ToArray();
				}
			}
			else
			{
				obj.currentVersion = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize304513582(global::Flare obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.energyLeft, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.flareActiveState, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.hasBeenThrown, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.flareActivateTime, writer);
	}

	private global::Flare Deserialize304513582(global::Flare obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.energyLeft = reader.ReadSingle();
				break;
			case 2:
				obj.flareActiveState = reader.ReadBoolean();
				break;
			case 3:
				obj.hasBeenThrown = reader.ReadBoolean();
				break;
			case 4:
				obj.flareActivateTime = reader.ReadSingle();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize108625815(FogSettings obj, int objTypeId, ProtoWriter writer)
	{
		obj.OnBeforeSerialization();
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.enabled, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1404661584(obj.color, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.startDistance, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.maxDistance, writer);
		ProtoWriter.WriteFieldHeader(5, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.absorptionSpeed, writer);
		ProtoWriter.WriteFieldHeader(6, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.sunGlowAmount, writer);
		ProtoWriter.WriteFieldHeader(7, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		if (obj.dayNightColor != null)
		{
			ProtoWriter.WriteFieldHeader(8, WireType.String, writer);
			SubItemToken token2 = ProtoWriter.StartSubItem(obj.dayNightColor, writer);
			this.Serialize175529349(obj.dayNightColor, objTypeId, writer);
			ProtoWriter.EndSubItem(token2, writer);
		}
		ProtoWriter.WriteFieldHeader(9, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.depthDispersion, writer);
		ProtoWriter.WriteFieldHeader(10, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.scatteringScale, writer);
	}

	private FogSettings Deserialize108625815(FogSettings obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		if (obj == null)
		{
			obj = new FogSettings();
			ProtoReader.NoteObject(obj, reader);
		}
		while (i > 0)
		{
			switch (i)
			{
			case 1:
				obj.enabled = reader.ReadBoolean();
				break;
			case 2:
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj.color = this.Deserialize1404661584(obj.color, reader);
				ProtoReader.EndSubItem(token, reader);
				break;
			}
			case 3:
				obj.startDistance = reader.ReadSingle();
				break;
			case 4:
				obj.maxDistance = reader.ReadSingle();
				break;
			case 5:
				obj.absorptionSpeed = reader.ReadSingle();
				break;
			case 6:
				obj.sunGlowAmount = reader.ReadSingle();
				break;
			case 7:
				obj.version = reader.ReadInt32();
				break;
			case 8:
			{
				SubItemToken token2 = ProtoReader.StartSubItem(reader);
				obj.dayNightColor = this.Deserialize175529349(obj.dayNightColor, reader);
				ProtoReader.EndSubItem(token2, reader);
				break;
			}
			case 9:
				obj.depthDispersion = reader.ReadSingle();
				break;
			case 10:
				obj.scatteringScale = reader.ReadSingle();
				break;
			default:
				reader.SkipField();
				break;
			}
			i = reader.ReadFieldHeader();
		}
		obj.OnAfterDeserialization();
		return obj;
	}

	private void Serialize478713964(FrozenResource obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.health, writer);
	}

	private FrozenResource Deserialize478713964(FrozenResource obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.health = reader.ReadInt32();
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize41335609(FruitPlant obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.fruitSpawnEnabled, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.timeNextFruit, writer);
	}

	private FruitPlant Deserialize41335609(FruitPlant obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.fruitSpawnEnabled = reader.ReadBoolean();
				break;
			case 3:
				obj.timeNextFruit = reader.ReadSingle();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1816388137(Garryfish obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Garryfish Deserialize1816388137(Garryfish obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize476284185(GasoPod obj, int objTypeId, ProtoWriter writer)
	{
	}

	private GasoPod Deserialize476284185(GasoPod obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize459225532(GenericConsole obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.gotUsed, writer);
	}

	private GenericConsole Deserialize459225532(GenericConsole obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				obj.gotUsed = reader.ReadBoolean();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize630473610(GhostCrafter obj, int objTypeId, ProtoWriter writer)
	{
		if (objTypeId == 606619525)
		{
			ProtoWriter.WriteFieldHeader(5100, WireType.String, writer);
			SubItemToken token = ProtoWriter.StartSubItem(null, writer);
			this.Serialize606619525(obj as Fabricator, objTypeId, writer);
			ProtoWriter.EndSubItem(token, writer);
			return;
		}
		if (objTypeId == 1333430695)
		{
			ProtoWriter.WriteFieldHeader(5200, WireType.String, writer);
			SubItemToken token2 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1333430695(obj as Workbench, objTypeId, writer);
			ProtoWriter.EndSubItem(token2, writer);
			return;
		}
		if (objTypeId == 309711119)
		{
			ProtoWriter.WriteFieldHeader(5300, WireType.String, writer);
			SubItemToken token3 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize309711119(obj as PrecursorPartFabricator, objTypeId, writer);
			ProtoWriter.EndSubItem(token3, writer);
		}
	}

	private GhostCrafter Deserialize630473610(GhostCrafter obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 5100)
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize606619525(obj as Fabricator, reader);
				ProtoReader.EndSubItem(token, reader);
			}
			else if (i == 5200)
			{
				SubItemToken token2 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1333430695(obj as Workbench, reader);
				ProtoReader.EndSubItem(token2, reader);
			}
			else
			{
				if (i != 5300)
				{
					IL_90:
					while (i > 0)
					{
						reader.SkipField();
						i = reader.ReadFieldHeader();
					}
					return obj;
				}
				SubItemToken token3 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize309711119(obj as PrecursorPartFabricator, reader);
				ProtoReader.EndSubItem(token3, reader);
			}
		}
		goto IL_90;
	}

	private void Serialize1817260405(GhostLeviatanVoid obj, int objTypeId, ProtoWriter writer)
	{
	}

	private GhostLeviatanVoid Deserialize1817260405(GhostLeviatanVoid obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize35332337(GhostLeviathan obj, int objTypeId, ProtoWriter writer)
	{
	}

	private GhostLeviathan Deserialize35332337(GhostLeviathan obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize530216075(GhostPickupable obj, int objTypeId, ProtoWriter writer)
	{
	}

	private GhostPickupable Deserialize530216075(GhostPickupable obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1389926401(GhostRay obj, int objTypeId, ProtoWriter writer)
	{
	}

	private GhostRay Deserialize1389926401(GhostRay obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1396620629(GlacialBasinBridgeController obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.extended, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.firstExtension, writer);
	}

	private GlacialBasinBridgeController Deserialize1396620629(GlacialBasinBridgeController obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.extended = reader.ReadBoolean();
				break;
			case 3:
				obj.firstExtension = reader.ReadBoolean();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1702754208(GlowWhale obj, int objTypeId, ProtoWriter writer)
	{
	}

	private GlowWhale Deserialize1702754208(GlowWhale obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize2033371878(Grabcrab obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Grabcrab Deserialize2033371878(Grabcrab obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1182280616(Grid3<float> obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize997267884(obj.shape, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
		if (obj.values != null)
		{
			foreach (float value in obj.values)
			{
				ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
				ProtoWriter.WriteSingle(value, writer);
			}
		}
	}

	private Grid3<float> Deserialize1182280616(Grid3<float> obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		if (obj == null)
		{
			obj = new Grid3<float>();
			ProtoReader.NoteObject(obj, reader);
		}
		while (i > 0)
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					List<float> list = new List<float>();
					int fieldNumber = reader.FieldNumber;
					do
					{
						float item = reader.ReadSingle();
						list.Add(item);
					}
					while (reader.TryReadFieldHeader(fieldNumber));
					obj.values = list.ToArray();
				}
			}
			else
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj.shape = this.Deserialize997267884(obj.shape, reader);
				ProtoReader.EndSubItem(token, reader);
			}
			i = reader.ReadFieldHeader();
		}
		return obj;
	}

	private void Serialize1765532648(Grid3<Vector3> obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize997267884(obj.shape, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
		if (obj.values != null)
		{
			foreach (Vector3 obj2 in obj.values)
			{
				ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
				SubItemToken token2 = ProtoWriter.StartSubItem(null, writer);
				this.Serialize1181346079(obj2, objTypeId, writer);
				ProtoWriter.EndSubItem(token2, writer);
			}
		}
	}

	private Grid3<Vector3> Deserialize1765532648(Grid3<Vector3> obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		if (obj == null)
		{
			obj = new Grid3<Vector3>();
			ProtoReader.NoteObject(obj, reader);
		}
		while (i > 0)
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					List<Vector3> list = new List<Vector3>();
					int fieldNumber = reader.FieldNumber;
					do
					{
						Vector3 vector = default(Vector3);
						SubItemToken token = ProtoReader.StartSubItem(reader);
						vector = this.Deserialize1181346079(vector, reader);
						ProtoReader.EndSubItem(token, reader);
						list.Add(vector);
					}
					while (reader.TryReadFieldHeader(fieldNumber));
					obj.values = list.ToArray();
				}
			}
			else
			{
				SubItemToken token2 = ProtoReader.StartSubItem(reader);
				obj.shape = this.Deserialize997267884(obj.shape, reader);
				ProtoReader.EndSubItem(token2, reader);
			}
			i = reader.ReadFieldHeader();
		}
		return obj;
	}

	private void Serialize997267884(Grid3Shape obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.x, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.y, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.z, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.xy, writer);
	}

	private Grid3Shape Deserialize997267884(Grid3Shape obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.x = reader.ReadInt32();
				break;
			case 2:
				obj.y = reader.ReadInt32();
				break;
			case 3:
				obj.z = reader.ReadInt32();
				break;
			case 4:
				obj.xy = reader.ReadInt32();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize697741374(Grower obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Grower Deserialize697741374(Grower obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize792963384(GrowingPlant obj, int objTypeId, ProtoWriter writer)
	{
	}

	private GrowingPlant Deserialize792963384(GrowingPlant obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize113236186(GrownPlant obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		if (obj.seedUID != null)
		{
			ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
			ProtoWriter.WriteString(obj.seedUID, writer);
		}
	}

	private GrownPlant Deserialize113236186(GrownPlant obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.seedUID = reader.ReadString();
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize2066256250(HandTarget obj, int objTypeId, ProtoWriter writer)
	{
		if (objTypeId == 723629918 || objTypeId == 730995178)
		{
			ProtoWriter.WriteFieldHeader(1000, WireType.String, writer);
			SubItemToken token = ProtoWriter.StartSubItem(null, writer);
			this.Serialize723629918(obj as Pickupable, objTypeId, writer);
			ProtoWriter.EndSubItem(token, writer);
			return;
		}
		if (objTypeId == 366077262 || objTypeId == 787786344)
		{
			ProtoWriter.WriteFieldHeader(1100, WireType.String, writer);
			SubItemToken token2 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize366077262(obj as StorageContainer, objTypeId, writer);
			ProtoWriter.EndSubItem(token2, writer);
			return;
		}
		if (objTypeId == 1954617231)
		{
			ProtoWriter.WriteFieldHeader(1200, WireType.String, writer);
			SubItemToken token3 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1954617231(obj as DiveReelAnchor, objTypeId, writer);
			ProtoWriter.EndSubItem(token3, writer);
			return;
		}
		if (objTypeId == 1297003913)
		{
			ProtoWriter.WriteFieldHeader(1300, WireType.String, writer);
			SubItemToken token4 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1297003913(obj as UpgradeConsole, objTypeId, writer);
			ProtoWriter.EndSubItem(token4, writer);
			return;
		}
		if (objTypeId == 1084867387)
		{
			ProtoWriter.WriteFieldHeader(1400, WireType.String, writer);
			SubItemToken token5 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1084867387(obj as Sign, objTypeId, writer);
			ProtoWriter.EndSubItem(token5, writer);
			return;
		}
		if (objTypeId == 515927774)
		{
			ProtoWriter.WriteFieldHeader(1500, WireType.String, writer);
			SubItemToken token6 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize515927774(obj as ColoredLabel, objTypeId, writer);
			ProtoWriter.EndSubItem(token6, writer);
			return;
		}
		if (objTypeId == 1289092887)
		{
			ProtoWriter.WriteFieldHeader(1600, WireType.String, writer);
			SubItemToken token7 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1289092887(obj as PickPrefab, objTypeId, writer);
			ProtoWriter.EndSubItem(token7, writer);
			return;
		}
		if (objTypeId == 1983352738)
		{
			ProtoWriter.WriteFieldHeader(1800, WireType.String, writer);
			SubItemToken token8 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1983352738(obj as ThermalPlant, objTypeId, writer);
			ProtoWriter.EndSubItem(token8, writer);
			return;
		}
		if (objTypeId == 113236186)
		{
			ProtoWriter.WriteFieldHeader(1900, WireType.String, writer);
			SubItemToken token9 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize113236186(obj as GrownPlant, objTypeId, writer);
			ProtoWriter.EndSubItem(token9, writer);
			return;
		}
		if (objTypeId == 792963384)
		{
			ProtoWriter.WriteFieldHeader(1950, WireType.String, writer);
			SubItemToken token10 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize792963384(obj as GrowingPlant, objTypeId, writer);
			ProtoWriter.EndSubItem(token10, writer);
			return;
		}
		if (objTypeId == 1113570486 || objTypeId == 2106147891 || objTypeId == 1174302959)
		{
			ProtoWriter.WriteFieldHeader(2000, WireType.String, writer);
			SubItemToken token11 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1113570486(obj as Vehicle, objTypeId, writer);
			ProtoWriter.EndSubItem(token11, writer);
			return;
		}
		if (objTypeId == 396637907 || objTypeId == 817046334 || objTypeId == 1045809045 || objTypeId == 882866214)
		{
			ProtoWriter.WriteFieldHeader(3000, WireType.String, writer);
			SubItemToken token12 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize396637907(obj as Constructable, objTypeId, writer);
			ProtoWriter.EndSubItem(token12, writer);
			return;
		}
		if (objTypeId == 1555952712)
		{
			ProtoWriter.WriteFieldHeader(4000, WireType.String, writer);
			SubItemToken token13 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1555952712(obj as SupplyCrate, objTypeId, writer);
			ProtoWriter.EndSubItem(token13, writer);
			return;
		}
		if (objTypeId == 135876261 || objTypeId == 1800229096 || objTypeId == 1011566978 || objTypeId == 802993602 || objTypeId == 257036954 || objTypeId == 630473610 || objTypeId == 606619525 || objTypeId == 1333430695 || objTypeId == 309711119 || objTypeId == 1170326782)
		{
			ProtoWriter.WriteFieldHeader(5000, WireType.String, writer);
			SubItemToken token14 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize135876261(obj as Crafter, objTypeId, writer);
			ProtoWriter.EndSubItem(token14, writer);
			return;
		}
		if (objTypeId == 737691900)
		{
			ProtoWriter.WriteFieldHeader(6000, WireType.String, writer);
			SubItemToken token15 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize737691900(obj as StarshipDoor, objTypeId, writer);
			ProtoWriter.EndSubItem(token15, writer);
			return;
		}
		if (objTypeId == 670501331)
		{
			ProtoWriter.WriteFieldHeader(7000, WireType.String, writer);
			SubItemToken token16 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize670501331(obj as MedicalCabinet, objTypeId, writer);
			ProtoWriter.EndSubItem(token16, writer);
			return;
		}
		if (objTypeId == 1343493277)
		{
			ProtoWriter.WriteFieldHeader(8000, WireType.String, writer);
			SubItemToken token17 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1343493277(obj as MapRoomScreen, objTypeId, writer);
			ProtoWriter.EndSubItem(token17, writer);
			return;
		}
		if (objTypeId == 530216075)
		{
			ProtoWriter.WriteFieldHeader(10000, WireType.String, writer);
			SubItemToken token18 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize530216075(obj as GhostPickupable, objTypeId, writer);
			ProtoWriter.EndSubItem(token18, writer);
			return;
		}
		if (objTypeId == 840818195)
		{
			ProtoWriter.WriteFieldHeader(11000, WireType.String, writer);
			SubItemToken token19 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize840818195(obj as WeldableWallPanelGeneric, objTypeId, writer);
			ProtoWriter.EndSubItem(token19, writer);
			return;
		}
		if (objTypeId == 1505210158)
		{
			ProtoWriter.WriteFieldHeader(12000, WireType.String, writer);
			SubItemToken token20 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1505210158(obj as PrecursorDoorKeyColumn, objTypeId, writer);
			ProtoWriter.EndSubItem(token20, writer);
			return;
		}
		if (objTypeId == 2051895012)
		{
			ProtoWriter.WriteFieldHeader(13000, WireType.String, writer);
			SubItemToken token21 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize2051895012(obj as PrecursorKeyTerminal, objTypeId, writer);
			ProtoWriter.EndSubItem(token21, writer);
			return;
		}
		if (objTypeId == 1713660373)
		{
			ProtoWriter.WriteFieldHeader(14000, WireType.String, writer);
			SubItemToken token22 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1713660373(obj as PrecursorTeleporterActivationTerminal, objTypeId, writer);
			ProtoWriter.EndSubItem(token22, writer);
			return;
		}
		if (objTypeId == 1457139245)
		{
			ProtoWriter.WriteFieldHeader(15000, WireType.String, writer);
			SubItemToken token23 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1457139245(obj as PrecursorDisableGunTerminal, objTypeId, writer);
			ProtoWriter.EndSubItem(token23, writer);
		}
	}

	private HandTarget Deserialize2066256250(HandTarget obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1000)
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize723629918(obj as Pickupable, reader);
				ProtoReader.EndSubItem(token, reader);
			}
			else if (i == 1100)
			{
				SubItemToken token2 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize366077262(obj as StorageContainer, reader);
				ProtoReader.EndSubItem(token2, reader);
			}
			else if (i == 1200)
			{
				SubItemToken token3 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1954617231(obj as DiveReelAnchor, reader);
				ProtoReader.EndSubItem(token3, reader);
			}
			else if (i == 1300)
			{
				SubItemToken token4 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1297003913(obj as UpgradeConsole, reader);
				ProtoReader.EndSubItem(token4, reader);
			}
			else if (i == 1400)
			{
				SubItemToken token5 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1084867387(obj as Sign, reader);
				ProtoReader.EndSubItem(token5, reader);
			}
			else if (i == 1500)
			{
				SubItemToken token6 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize515927774(obj as ColoredLabel, reader);
				ProtoReader.EndSubItem(token6, reader);
			}
			else if (i == 1600)
			{
				SubItemToken token7 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1289092887(obj as PickPrefab, reader);
				ProtoReader.EndSubItem(token7, reader);
			}
			else if (i == 1800)
			{
				SubItemToken token8 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1983352738(obj as ThermalPlant, reader);
				ProtoReader.EndSubItem(token8, reader);
			}
			else if (i == 1900)
			{
				SubItemToken token9 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize113236186(obj as GrownPlant, reader);
				ProtoReader.EndSubItem(token9, reader);
			}
			else if (i == 1950)
			{
				SubItemToken token10 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize792963384(obj as GrowingPlant, reader);
				ProtoReader.EndSubItem(token10, reader);
			}
			else if (i == 2000)
			{
				SubItemToken token11 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1113570486(obj as Vehicle, reader);
				ProtoReader.EndSubItem(token11, reader);
			}
			else if (i == 3000)
			{
				SubItemToken token12 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize396637907(obj as Constructable, reader);
				ProtoReader.EndSubItem(token12, reader);
			}
			else if (i == 4000)
			{
				SubItemToken token13 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1555952712(obj as SupplyCrate, reader);
				ProtoReader.EndSubItem(token13, reader);
			}
			else if (i == 5000)
			{
				SubItemToken token14 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize135876261(obj as Crafter, reader);
				ProtoReader.EndSubItem(token14, reader);
			}
			else if (i == 6000)
			{
				SubItemToken token15 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize737691900(obj as StarshipDoor, reader);
				ProtoReader.EndSubItem(token15, reader);
			}
			else if (i == 7000)
			{
				SubItemToken token16 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize670501331(obj as MedicalCabinet, reader);
				ProtoReader.EndSubItem(token16, reader);
			}
			else if (i == 8000)
			{
				SubItemToken token17 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1343493277(obj as MapRoomScreen, reader);
				ProtoReader.EndSubItem(token17, reader);
			}
			else if (i == 10000)
			{
				SubItemToken token18 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize530216075(obj as GhostPickupable, reader);
				ProtoReader.EndSubItem(token18, reader);
			}
			else if (i == 11000)
			{
				SubItemToken token19 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize840818195(obj as WeldableWallPanelGeneric, reader);
				ProtoReader.EndSubItem(token19, reader);
			}
			else if (i == 12000)
			{
				SubItemToken token20 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1505210158(obj as PrecursorDoorKeyColumn, reader);
				ProtoReader.EndSubItem(token20, reader);
			}
			else if (i == 13000)
			{
				SubItemToken token21 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize2051895012(obj as PrecursorKeyTerminal, reader);
				ProtoReader.EndSubItem(token21, reader);
			}
			else if (i == 14000)
			{
				SubItemToken token22 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1713660373(obj as PrecursorTeleporterActivationTerminal, reader);
				ProtoReader.EndSubItem(token22, reader);
			}
			else
			{
				if (i != 15000)
				{
					IL_3B3:
					while (i > 0)
					{
						reader.SkipField();
						i = reader.ReadFieldHeader();
					}
					return obj;
				}
				SubItemToken token23 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1457139245(obj as PrecursorDisableGunTerminal, reader);
				ProtoReader.EndSubItem(token23, reader);
			}
		}
		goto IL_3B3;
	}

	private void Serialize646820922(Holefish obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Holefish Deserialize646820922(Holefish obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize328727906(Hoopfish obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Hoopfish Deserialize328727906(Hoopfish obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize802059837(Hoverbike obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.forceLandMode, writer);
		if (obj.serializedModuleSlots != null)
		{
			foreach (KeyValuePair<string, string> obj2 in obj.serializedModuleSlots)
			{
				ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
				SubItemToken token = ProtoWriter.StartSubItem(null, writer);
				this.Serialize524780017(obj2, objTypeId, writer);
				ProtoWriter.EndSubItem(token, writer);
			}
		}
	}

	private Hoverbike Deserialize802059837(Hoverbike obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.forceLandMode = reader.ReadBoolean();
				break;
			case 3:
			{
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				int fieldNumber = reader.FieldNumber;
				do
				{
					KeyValuePair<string, string> obj2 = default(KeyValuePair<string, string>);
					SubItemToken token = ProtoReader.StartSubItem(reader);
					obj2 = this.Deserialize524780017(obj2, reader);
					ProtoReader.EndSubItem(token, reader);
					dictionary[obj2.Key] = obj2.Value;
				}
				while (reader.TryReadFieldHeader(fieldNumber));
				obj.serializedModuleSlots = dictionary;
				break;
			}
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1859566378(Hoverfish obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Hoverfish Deserialize1859566378(Hoverfish obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1024693509(Incubator obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.powered, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.hatched, writer);
	}

	private Incubator Deserialize1024693509(Incubator obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.powered = reader.ReadBoolean();
				break;
			case 3:
				obj.hatched = reader.ReadBoolean();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize2004070125(InfectedMixin obj, int objTypeId, ProtoWriter writer)
	{
	}

	private InfectedMixin Deserialize2004070125(InfectedMixin obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1691070576(Int3 obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.x, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.y, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.z, writer);
	}

	private Int3 Deserialize1691070576(Int3 obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.x = reader.ReadInt32();
				break;
			case 2:
				obj.y = reader.ReadInt32();
				break;
			case 3:
				obj.z = reader.ReadInt32();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1164389947(Int3.Bounds obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1691070576(obj.mins, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
		SubItemToken token2 = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1691070576(obj.maxs, objTypeId, writer);
		ProtoWriter.EndSubItem(token2, writer);
	}

	private Int3.Bounds Deserialize1164389947(Int3.Bounds obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					SubItemToken token = ProtoReader.StartSubItem(reader);
					obj.maxs = this.Deserialize1691070576(obj.maxs, reader);
					ProtoReader.EndSubItem(token, reader);
				}
			}
			else
			{
				SubItemToken token2 = ProtoReader.StartSubItem(reader);
				obj.mins = this.Deserialize1691070576(obj.mins, reader);
				ProtoReader.EndSubItem(token2, reader);
			}
		}
		return obj;
	}

	private void Serialize289177516(Int3Class obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.x, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.y, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.z, writer);
	}

	private Int3Class Deserialize289177516(Int3Class obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		if (obj == null)
		{
			obj = new Int3Class();
			ProtoReader.NoteObject(obj, reader);
		}
		while (i > 0)
		{
			switch (i)
			{
			case 1:
				obj.x = reader.ReadInt32();
				break;
			case 2:
				obj.y = reader.ReadInt32();
				break;
			case 3:
				obj.z = reader.ReadInt32();
				break;
			default:
				reader.SkipField();
				break;
			}
			i = reader.ReadFieldHeader();
		}
		return obj;
	}

	private void Serialize1160243952(IntroDropshipExplode obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.timeToExplode, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.exploded, writer);
	}

	private IntroDropshipExplode Deserialize1160243952(IntroDropshipExplode obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.timeToExplode = reader.ReadSingle();
				break;
			case 3:
				obj.exploded = reader.ReadBoolean();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize51037994(Inventory obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		if (obj.serializedStorage != null)
		{
			byte[] serializedStorage = obj.serializedStorage;
			ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
			ProtoWriter.WriteBytes(serializedStorage, writer);
		}
		if (obj.serializedQuickSlots != null)
		{
			foreach (string text in obj.serializedQuickSlots)
			{
				if (text != null)
				{
					ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
					ProtoWriter.WriteString(text, writer);
				}
			}
		}
		if (obj.serializedEquipment != null)
		{
			byte[] serializedEquipment = obj.serializedEquipment;
			ProtoWriter.WriteFieldHeader(4, WireType.String, writer);
			ProtoWriter.WriteBytes(serializedEquipment, writer);
		}
		if (obj.serializedEquipmentSlots != null)
		{
			foreach (KeyValuePair<string, string> obj2 in obj.serializedEquipmentSlots)
			{
				ProtoWriter.WriteFieldHeader(5, WireType.String, writer);
				SubItemToken token = ProtoWriter.StartSubItem(null, writer);
				this.Serialize524780017(obj2, objTypeId, writer);
				ProtoWriter.EndSubItem(token, writer);
			}
		}
		if (obj.serializedPendingItems != null)
		{
			byte[] serializedPendingItems = obj.serializedPendingItems;
			ProtoWriter.WriteFieldHeader(7, WireType.String, writer);
			ProtoWriter.WriteBytes(serializedPendingItems, writer);
		}
	}

	private Inventory Deserialize51037994(Inventory obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		while (i > 0)
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.serializedStorage = ProtoReader.AppendBytes(obj.serializedStorage, reader);
				break;
			case 3:
			{
				List<string> list = new List<string>();
				int fieldNumber = reader.FieldNumber;
				do
				{
					string item = reader.ReadString();
					list.Add(item);
				}
				while (reader.TryReadFieldHeader(fieldNumber));
				obj.serializedQuickSlots = list.ToArray();
				break;
			}
			case 4:
				obj.serializedEquipment = ProtoReader.AppendBytes(obj.serializedEquipment, reader);
				break;
			case 5:
			{
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				int fieldNumber2 = reader.FieldNumber;
				do
				{
					KeyValuePair<string, string> obj2 = default(KeyValuePair<string, string>);
					SubItemToken token = ProtoReader.StartSubItem(reader);
					obj2 = this.Deserialize524780017(obj2, reader);
					ProtoReader.EndSubItem(token, reader);
					dictionary[obj2.Key] = obj2.Value;
				}
				while (reader.TryReadFieldHeader(fieldNumber2));
				obj.serializedEquipmentSlots = dictionary;
				break;
			}
			case 6:
				goto IL_113;
			case 7:
				obj.serializedPendingItems = ProtoReader.AppendBytes(obj.serializedPendingItems, reader);
				break;
			default:
				goto IL_113;
			}
			IL_119:
			i = reader.ReadFieldHeader();
			continue;
			IL_113:
			reader.SkipField();
			goto IL_119;
		}
		return obj;
	}

	private void Serialize474388930(ItemExchanger obj, int objTypeId, ProtoWriter writer)
	{
	}

	private ItemExchanger Deserialize474388930(ItemExchanger obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1941291928(Jellyfish obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Jellyfish Deserialize1941291928(Jellyfish obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1338410882(Jellyray obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Jellyray Deserialize1338410882(Jellyray obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1430634702(JointHelper obj, int objTypeId, ProtoWriter writer)
	{
		if (obj.connectedObjectUid != null)
		{
			ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
			ProtoWriter.WriteString(obj.connectedObjectUid, writer);
		}
		if (obj.jointType != null)
		{
			ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
			ProtoWriter.WriteString(obj.jointType, writer);
		}
	}

	private JointHelper Deserialize1430634702(JointHelper obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.jointType = reader.ReadString();
				}
			}
			else
			{
				obj.connectedObjectUid = reader.ReadString();
			}
		}
		return obj;
	}

	private void Serialize1662769415(JukeboxInstance obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		if (obj._file != null)
		{
			ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
			ProtoWriter.WriteString(obj._file, writer);
		}
		ProtoWriter.WriteFieldHeader(3, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.volume, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.Variant, writer);
		ProtoWriter.WriteInt32((int)obj.repeat, writer);
		ProtoWriter.WriteFieldHeader(5, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.shuffle, writer);
	}

	private JukeboxInstance Deserialize1662769415(JukeboxInstance obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj._file = reader.ReadString();
				break;
			case 3:
				obj.volume = reader.ReadSingle();
				break;
			case 4:
				obj.repeat = (Jukebox.Repeat)reader.ReadInt32();
				break;
			case 5:
				obj.shuffle = reader.ReadBoolean();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1252700319(Jumper obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Jumper Deserialize1252700319(Jumper obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1032585975(KeypadDoorConsole obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.unlocked, writer);
	}

	private KeypadDoorConsole Deserialize1032585975(KeypadDoorConsole obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				obj.unlocked = reader.ReadBoolean();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize1059166753(KeypadDoorConsoleUnlock obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.unlocked, writer);
	}

	private KeypadDoorConsoleUnlock Deserialize1059166753(KeypadDoorConsoleUnlock obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				obj.unlocked = reader.ReadBoolean();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize805312304(LandCreatureGravity obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.forceLandMode, writer);
	}

	private LandCreatureGravity Deserialize805312304(LandCreatureGravity obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.forceLandMode = reader.ReadBoolean();
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize1793440205(LargeRoomWaterPark obj, int objTypeId, ProtoWriter writer)
	{
	}

	private LargeRoomWaterPark Deserialize1793440205(LargeRoomWaterPark obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1878920823(LargeWorldBatchRoot obj, int objTypeId, ProtoWriter writer)
	{
		obj.OnBeforeSerialization();
		if (obj.overrideBiome != null)
		{
			ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
			ProtoWriter.WriteString(obj.overrideBiome, writer);
		}
		ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1404661584(obj.fogColor, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.fogStartDistance, writer);
		ProtoWriter.WriteFieldHeader(5, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.fogMaxDistance, writer);
		ProtoWriter.WriteFieldHeader(6, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.fadeDefaultLights, writer);
		ProtoWriter.WriteFieldHeader(7, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.fadeRate, writer);
		if (obj.fog != null)
		{
			ProtoWriter.WriteFieldHeader(8, WireType.String, writer);
			SubItemToken token2 = ProtoWriter.StartSubItem(obj.fog, writer);
			this.Serialize108625815(obj.fog, objTypeId, writer);
			ProtoWriter.EndSubItem(token2, writer);
		}
		if (obj.sun != null)
		{
			ProtoWriter.WriteFieldHeader(9, WireType.String, writer);
			SubItemToken token3 = ProtoWriter.StartSubItem(obj.sun, writer);
			this.Serialize1603999327(obj.sun, objTypeId, writer);
			ProtoWriter.EndSubItem(token3, writer);
		}
		if (obj.amb != null)
		{
			ProtoWriter.WriteFieldHeader(10, WireType.String, writer);
			SubItemToken token4 = ProtoWriter.StartSubItem(obj.amb, writer);
			this.Serialize1804294731(obj.amb, objTypeId, writer);
			ProtoWriter.EndSubItem(token4, writer);
		}
		ProtoWriter.WriteFieldHeader(11, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		if (obj.atmospherePrefabClassId != null)
		{
			ProtoWriter.WriteFieldHeader(12, WireType.String, writer);
			ProtoWriter.WriteString(obj.atmospherePrefabClassId, writer);
		}
	}

	private LargeWorldBatchRoot Deserialize1878920823(LargeWorldBatchRoot obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 2:
				obj.overrideBiome = reader.ReadString();
				break;
			case 3:
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj.fogColor = this.Deserialize1404661584(obj.fogColor, reader);
				ProtoReader.EndSubItem(token, reader);
				break;
			}
			case 4:
				obj.fogStartDistance = reader.ReadSingle();
				break;
			case 5:
				obj.fogMaxDistance = reader.ReadSingle();
				break;
			case 6:
				obj.fadeDefaultLights = reader.ReadSingle();
				break;
			case 7:
				obj.fadeRate = reader.ReadSingle();
				break;
			case 8:
			{
				SubItemToken token2 = ProtoReader.StartSubItem(reader);
				obj.fog = this.Deserialize108625815(obj.fog, reader);
				ProtoReader.EndSubItem(token2, reader);
				break;
			}
			case 9:
			{
				SubItemToken token3 = ProtoReader.StartSubItem(reader);
				obj.sun = this.Deserialize1603999327(obj.sun, reader);
				ProtoReader.EndSubItem(token3, reader);
				break;
			}
			case 10:
			{
				SubItemToken token4 = ProtoReader.StartSubItem(reader);
				obj.amb = this.Deserialize1804294731(obj.amb, reader);
				ProtoReader.EndSubItem(token4, reader);
				break;
			}
			case 11:
				obj.version = reader.ReadInt32();
				break;
			case 12:
				obj.atmospherePrefabClassId = reader.ReadString();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		obj.OnAfterDeserialization();
		return obj;
	}

	private void Serialize577496260(LargeWorldEntity obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteInt32((int)obj.cellLevel, writer);
	}

	private LargeWorldEntity Deserialize577496260(LargeWorldEntity obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 2)
			{
				obj.cellLevel = (LargeWorldEntity.CellLevel)reader.ReadInt32();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize122249312(LargeWorldEntityCell obj, int objTypeId, ProtoWriter writer)
	{
	}

	private LargeWorldEntityCell Deserialize122249312(LargeWorldEntityCell obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize769725772(LaserCutObject obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.isCutOpen, writer);
	}

	private LaserCutObject Deserialize769725772(LaserCutObject obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				obj.isCutOpen = reader.ReadBoolean();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize353579366(LavaLarva obj, int objTypeId, ProtoWriter writer)
	{
	}

	private LavaLarva Deserialize353579366(LavaLarva obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1882829928(LavaLizard obj, int objTypeId, ProtoWriter writer)
	{
	}

	private LavaLizard Deserialize1882829928(LavaLizard obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1703248490(LavaShell obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.armorPoints, writer);
	}

	private LavaShell Deserialize1703248490(LavaShell obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.armorPoints = reader.ReadSingle();
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize656832482(LeakingRadiation obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.currentRadius, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.radiationFixed, writer);
	}

	private LeakingRadiation Deserialize656832482(LeakingRadiation obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.currentRadius = reader.ReadSingle();
				break;
			case 3:
				obj.radiationFixed = reader.ReadBoolean();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize200911463(LEDLight obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.deployed, writer);
	}

	private LEDLight Deserialize200911463(LEDLight obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				obj.deployed = reader.ReadBoolean();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize1332964068(Leviathan obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Leviathan Deserialize1332964068(Leviathan obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1372467290(LifepodDrop obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.dropComplete, writer);
		if (obj.dropStoryGoal != null)
		{
			ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
			ProtoWriter.WriteString(obj.dropStoryGoal, writer);
		}
	}

	private LifepodDrop Deserialize1372467290(LifepodDrop obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.dropComplete = reader.ReadBoolean();
				break;
			case 3:
				obj.dropStoryGoal = reader.ReadString();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1271521784(LilyPaddler obj, int objTypeId, ProtoWriter writer)
	{
	}

	private LilyPaddler Deserialize1271521784(LilyPaddler obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize729882159(LiveMixin obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.health, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.tempDamage, writer);
		if (obj.reqRes != null)
		{
			foreach (int value in obj.reqRes)
			{
				ProtoWriter.WriteFieldHeader(5, WireType.Variant, writer);
				ProtoWriter.WriteInt32(value, writer);
			}
		}
	}

	private LiveMixin Deserialize729882159(LiveMixin obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		while (i > 0)
		{
			switch (i)
			{
			case 1:
				obj.health = reader.ReadSingle();
				break;
			case 2:
			case 4:
				goto IL_77;
			case 3:
				obj.tempDamage = reader.ReadSingle();
				break;
			case 5:
			{
				List<TechType> list = new List<TechType>();
				int fieldNumber = reader.FieldNumber;
				do
				{
					TechType item = (TechType)reader.ReadInt32();
					list.Add(item);
				}
				while (reader.TryReadFieldHeader(fieldNumber));
				obj.reqRes = list.ToArray();
				break;
			}
			default:
				goto IL_77;
			}
			IL_7D:
			i = reader.ReadFieldHeader();
			continue;
			IL_77:
			reader.SkipField();
			goto IL_7D;
		}
		return obj;
	}

	private void Serialize1855998104(MapRoomCamera obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.cameraNumber, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.lightState, writer);
	}

	private MapRoomCamera Deserialize1855998104(MapRoomCamera obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.cameraNumber = reader.ReadInt32();
				break;
			case 3:
				obj.lightState = reader.ReadBoolean();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1304741297(MapRoomCameraDocking obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.cameraDocked, writer);
	}

	private MapRoomCameraDocking Deserialize1304741297(MapRoomCameraDocking obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.cameraDocked = reader.ReadBoolean();
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize503490010(MapRoomFunctionality obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.numNodesScanned, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteInt32((int)obj.typeToScan, writer);
	}

	private MapRoomFunctionality Deserialize503490010(MapRoomFunctionality obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.numNodesScanned = reader.ReadInt32();
				break;
			case 3:
				obj.typeToScan = (TechType)reader.ReadInt32();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1343493277(MapRoomScreen obj, int objTypeId, ProtoWriter writer)
	{
	}

	private MapRoomScreen Deserialize1343493277(MapRoomScreen obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize670501331(MedicalCabinet obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.hasMedKit, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.timeSpawnMedKit, writer);
	}

	private MedicalCabinet Deserialize670501331(MedicalCabinet obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.timeSpawnMedKit = reader.ReadSingle();
				}
			}
			else
			{
				obj.hasMedKit = reader.ReadBoolean();
			}
		}
		return obj;
	}

	private void Serialize123477383(Mesmer obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Mesmer Deserialize123477383(Mesmer obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize2078931521(MobileExtractorMachine obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.inPosition, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.hasSample, writer);
	}

	private MobileExtractorMachine Deserialize2078931521(MobileExtractorMachine obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.inPosition = reader.ReadBoolean();
				break;
			case 3:
				obj.hasSample = reader.ReadBoolean();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1761034218(NitrogenLevel obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.nitrogenLevel, writer);
	}

	private NitrogenLevel Deserialize1761034218(NitrogenLevel obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				obj.nitrogenLevel = reader.ReadSingle();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize1124647116(NootFish obj, int objTypeId, ProtoWriter writer)
	{
	}

	private NootFish Deserialize1124647116(NootFish obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1874975849(NotificationManager.NotificationData obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.duration, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.timeLeft, writer);
	}

	private NotificationManager.NotificationData Deserialize1874975849(NotificationManager.NotificationData obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		if (obj == null)
		{
			obj = new NotificationManager.NotificationData();
			ProtoReader.NoteObject(obj, reader);
		}
		while (i > 0)
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.timeLeft = reader.ReadSingle();
				}
			}
			else
			{
				obj.duration = reader.ReadSingle();
			}
			i = reader.ReadFieldHeader();
		}
		return obj;
	}

	private void Serialize1731663660(NotificationManager.NotificationId obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32((int)obj.group, writer);
		if (obj.key != null)
		{
			ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
			ProtoWriter.WriteString(obj.key, writer);
		}
	}

	private NotificationManager.NotificationId Deserialize1731663660(NotificationManager.NotificationId obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.key = reader.ReadString();
				}
			}
			else
			{
				obj.group = (NotificationManager.Group)reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize348559960(NotificationManager.SerializedData obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.protoVersion, writer);
		if (obj.notifications != null)
		{
			foreach (KeyValuePair<NotificationManager.NotificationId, NotificationManager.NotificationData> obj2 in obj.notifications)
			{
				ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
				SubItemToken token = ProtoWriter.StartSubItem(null, writer);
				this.Serialize1852174394(obj2, objTypeId, writer);
				ProtoWriter.EndSubItem(token, writer);
			}
		}
	}

	private NotificationManager.SerializedData Deserialize348559960(NotificationManager.SerializedData obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		if (obj == null)
		{
			obj = new NotificationManager.SerializedData();
			ProtoReader.NoteObject(obj, reader);
		}
		while (i > 0)
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					Dictionary<NotificationManager.NotificationId, NotificationManager.NotificationData> dictionary = obj.notifications ?? new Dictionary<NotificationManager.NotificationId, NotificationManager.NotificationData>();
					int fieldNumber = reader.FieldNumber;
					do
					{
						KeyValuePair<NotificationManager.NotificationId, NotificationManager.NotificationData> obj2 = default(KeyValuePair<NotificationManager.NotificationId, NotificationManager.NotificationData>);
						SubItemToken token = ProtoReader.StartSubItem(reader);
						obj2 = this.Deserialize1852174394(obj2, reader);
						ProtoReader.EndSubItem(token, reader);
						dictionary[obj2.Key] = obj2.Value;
					}
					while (reader.TryReadFieldHeader(fieldNumber));
				}
			}
			else
			{
				obj.protoVersion = reader.ReadInt32();
			}
			i = reader.ReadFieldHeader();
		}
		return obj;
	}

	private void Serialize802993602(NuclearReactor obj, int objTypeId, ProtoWriter writer)
	{
	}

	private NuclearReactor Deserialize802993602(NuclearReactor obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1829844631(OculusFish obj, int objTypeId, ProtoWriter writer)
	{
	}

	private OculusFish Deserialize1829844631(OculusFish obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize190681690(Oxygen obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.oxygenAvailable, writer);
	}

	private Oxygen Deserialize190681690(Oxygen obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				obj.oxygenAvailable = reader.ReadSingle();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize569028242(OxygenPipe obj, int objTypeId, ProtoWriter writer)
	{
		if (obj.parentPipeUID != null)
		{
			ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
			ProtoWriter.WriteString(obj.parentPipeUID, writer);
		}
		if (obj.rootPipeUID != null)
		{
			ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
			ProtoWriter.WriteString(obj.rootPipeUID, writer);
		}
		ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1181346079(obj.parentPosition, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		if (obj.childPipeUID != null)
		{
			foreach (string text in obj.childPipeUID)
			{
				if (text != null)
				{
					ProtoWriter.WriteFieldHeader(5, WireType.String, writer);
					ProtoWriter.WriteString(text, writer);
				}
			}
		}
	}

	private OxygenPipe Deserialize569028242(OxygenPipe obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.parentPipeUID = reader.ReadString();
				break;
			case 2:
				obj.rootPipeUID = reader.ReadString();
				break;
			case 3:
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj.parentPosition = this.Deserialize1181346079(obj.parentPosition, reader);
				ProtoReader.EndSubItem(token, reader);
				break;
			}
			case 4:
				obj.version = reader.ReadInt32();
				break;
			case 5:
			{
				List<string> list = new List<string>();
				int fieldNumber = reader.FieldNumber;
				do
				{
					string item = reader.ReadString();
					list.Add(item);
				}
				while (reader.TryReadFieldHeader(fieldNumber));
				obj.childPipeUID = list.ToArray();
				break;
			}
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1056558719(OxygenPlant obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed64, writer);
		ProtoWriter.WriteDouble(obj.start, writer);
	}

	private OxygenPlant Deserialize1056558719(OxygenPlant obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.start = reader.ReadDouble();
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize1244614203(PDAEncyclopedia.Entry obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.timestamp, writer);
		if (obj.timeCapsuleId != null)
		{
			ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
			ProtoWriter.WriteString(obj.timeCapsuleId, writer);
		}
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.revealed, writer);
	}

	private PDAEncyclopedia.Entry Deserialize1244614203(PDAEncyclopedia.Entry obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		if (obj == null)
		{
			obj = new PDAEncyclopedia.Entry();
			ProtoReader.NoteObject(obj, reader);
		}
		while (i > 0)
		{
			switch (i)
			{
			case 1:
				obj.timestamp = reader.ReadSingle();
				break;
			case 2:
				obj.timeCapsuleId = reader.ReadString();
				break;
			case 3:
				obj.revealed = reader.ReadBoolean();
				break;
			default:
				reader.SkipField();
				break;
			}
			i = reader.ReadFieldHeader();
		}
		return obj;
	}

	private void Serialize1329426611(PDALog.Entry obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.timestamp, writer);
	}

	private PDALog.Entry Deserialize1329426611(PDALog.Entry obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		if (obj == null)
		{
			obj = new PDALog.Entry();
			ProtoReader.NoteObject(obj, reader);
		}
		while (i > 0)
		{
			if (i == 1)
			{
				obj.timestamp = reader.ReadSingle();
			}
			else
			{
				reader.SkipField();
			}
			i = reader.ReadFieldHeader();
		}
		return obj;
	}

	private void Serialize2137760429(PDAScanner.Data obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		if (obj.fragments != null)
		{
			foreach (KeyValuePair<string, float> obj2 in obj.fragments)
			{
				ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
				SubItemToken token = ProtoWriter.StartSubItem(null, writer);
				this.Serialize714689774(obj2, objTypeId, writer);
				ProtoWriter.EndSubItem(token, writer);
			}
		}
		if (obj.partial != null)
		{
			foreach (PDAScanner.Entry entry in obj.partial)
			{
				if (entry != null)
				{
					ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
					SubItemToken token2 = ProtoWriter.StartSubItem(entry, writer);
					this.Serialize248259089(entry, objTypeId, writer);
					ProtoWriter.EndSubItem(token2, writer);
				}
			}
		}
		if (obj.complete != null)
		{
			foreach (int value in obj.complete)
			{
				ProtoWriter.WriteFieldHeader(4, WireType.Variant, writer);
				ProtoWriter.WriteInt32(value, writer);
			}
		}
	}

	private PDAScanner.Data Deserialize2137760429(PDAScanner.Data obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		if (obj == null)
		{
			obj = new PDAScanner.Data();
			ProtoReader.NoteObject(obj, reader);
		}
		while (i > 0)
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
			{
				Dictionary<string, float> dictionary = new Dictionary<string, float>();
				int fieldNumber = reader.FieldNumber;
				do
				{
					KeyValuePair<string, float> obj2 = default(KeyValuePair<string, float>);
					SubItemToken token = ProtoReader.StartSubItem(reader);
					obj2 = this.Deserialize714689774(obj2, reader);
					ProtoReader.EndSubItem(token, reader);
					dictionary[obj2.Key] = obj2.Value;
				}
				while (reader.TryReadFieldHeader(fieldNumber));
				obj.fragments = dictionary;
				break;
			}
			case 3:
			{
				List<PDAScanner.Entry> list = new List<PDAScanner.Entry>();
				int fieldNumber2 = reader.FieldNumber;
				do
				{
					PDAScanner.Entry entry = new PDAScanner.Entry();
					SubItemToken token2 = ProtoReader.StartSubItem(reader);
					entry = this.Deserialize248259089(entry, reader);
					ProtoReader.EndSubItem(token2, reader);
					list.Add(entry);
				}
				while (reader.TryReadFieldHeader(fieldNumber2));
				obj.partial = list;
				break;
			}
			case 4:
			{
				HashSet<TechType> hashSet = new HashSet<TechType>();
				int fieldNumber3 = reader.FieldNumber;
				do
				{
					TechType item = (TechType)reader.ReadInt32();
					hashSet.Add(item);
				}
				while (reader.TryReadFieldHeader(fieldNumber3));
				obj.complete = hashSet;
				break;
			}
			default:
				reader.SkipField();
				break;
			}
			i = reader.ReadFieldHeader();
		}
		return obj;
	}

	private void Serialize248259089(PDAScanner.Entry obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32((int)obj.techType, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.progress, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.unlocked, writer);
	}

	private PDAScanner.Entry Deserialize248259089(PDAScanner.Entry obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		if (obj == null)
		{
			obj = new PDAScanner.Entry();
			ProtoReader.NoteObject(obj, reader);
		}
		while (i > 0)
		{
			switch (i)
			{
			case 1:
				obj.techType = (TechType)reader.ReadInt32();
				break;
			case 2:
				obj.progress = reader.ReadSingle();
				break;
			case 3:
				obj.unlocked = reader.ReadInt32();
				break;
			default:
				reader.SkipField();
				break;
			}
			i = reader.ReadFieldHeader();
		}
		return obj;
	}

	private void Serialize1488630837(PDASounds obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		if (obj._queue != null)
		{
			ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
			SubItemToken token = ProtoWriter.StartSubItem(obj._queue, writer);
			this.Serialize350666384(obj._queue, objTypeId, writer);
			ProtoWriter.EndSubItem(token, writer);
		}
	}

	private PDASounds Deserialize1488630837(PDASounds obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					SubItemToken token = ProtoReader.StartSubItem(reader);
					obj._queue = this.Deserialize350666384(obj._queue, reader);
					ProtoReader.EndSubItem(token, reader);
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize1124891617(Peeper obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
	}

	private Peeper Deserialize1124891617(Peeper obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				obj.version = reader.ReadInt32();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize526214298(Penguin obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Penguin Deserialize526214298(Penguin obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1457388542(PenguinBaby obj, int objTypeId, ProtoWriter writer)
	{
	}

	private PenguinBaby Deserialize1457388542(PenguinBaby obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1289092887(PickPrefab obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.pickedState, writer);
	}

	private PickPrefab Deserialize1289092887(PickPrefab obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				obj.pickedState = reader.ReadBoolean();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize723629918(Pickupable obj, int objTypeId, ProtoWriter writer)
	{
		if (objTypeId == 730995178)
		{
			ProtoWriter.WriteFieldHeader(1010, WireType.String, writer);
			SubItemToken token = ProtoWriter.StartSubItem(null, writer);
			this.Serialize730995178(obj as CreepvineSeed, objTypeId, writer);
			ProtoWriter.EndSubItem(token, writer);
		}
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32((int)obj.overrideTechType, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.overrideTechUsed, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.isLootCube, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.isPickupable, writer);
		ProtoWriter.WriteFieldHeader(5, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.destroyOnDeath, writer);
		ProtoWriter.WriteFieldHeader(6, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj._attached, writer);
		ProtoWriter.WriteFieldHeader(7, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj._isInSub, writer);
		ProtoWriter.WriteFieldHeader(8, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(9, WireType.Variant, writer);
		ProtoWriter.WriteInt32((int)obj.isKinematic, writer);
	}

	private Pickupable Deserialize723629918(Pickupable obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1010)
			{
				IL_F8:
				while (i > 0)
				{
					switch (i)
					{
					case 1:
						obj.overrideTechType = (TechType)reader.ReadInt32();
						break;
					case 2:
						obj.overrideTechUsed = reader.ReadBoolean();
						break;
					case 3:
						obj.isLootCube = reader.ReadBoolean();
						break;
					case 4:
						obj.isPickupable = reader.ReadBoolean();
						break;
					case 5:
						obj.destroyOnDeath = reader.ReadBoolean();
						break;
					case 6:
						obj._attached = reader.ReadBoolean();
						break;
					case 7:
						obj._isInSub = reader.ReadBoolean();
						break;
					case 8:
						obj.version = reader.ReadInt32();
						break;
					case 9:
						obj.isKinematic = (PickupableKinematicState)reader.ReadInt32();
						break;
					default:
						reader.SkipField();
						break;
					}
					i = reader.ReadFieldHeader();
				}
				return obj;
			}
			SubItemToken token = ProtoReader.StartSubItem(reader);
			obj = this.Deserialize730995178(obj as CreepvineSeed, reader);
			ProtoReader.EndSubItem(token, reader);
		}
		goto IL_F8;
	}

	private void Serialize1527139359(PictureFrame obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		if (obj.fileName != null)
		{
			ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
			ProtoWriter.WriteString(obj.fileName, writer);
		}
	}

	private PictureFrame Deserialize1527139359(PictureFrame obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.fileName = reader.ReadString();
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize205484837(PingInstance obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.currentVersion, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.visible, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.colorIndex, writer);
		if (obj._id != null)
		{
			ProtoWriter.WriteFieldHeader(4, WireType.String, writer);
			ProtoWriter.WriteString(obj._id, writer);
		}
	}

	private PingInstance Deserialize205484837(PingInstance obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.currentVersion = reader.ReadInt32();
				break;
			case 2:
				obj.visible = reader.ReadBoolean();
				break;
			case 3:
				obj.colorIndex = reader.ReadInt32();
				break;
			case 4:
				obj._id = reader.ReadString();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize414351131(Pinnacarid obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Pinnacarid Deserialize414351131(Pinnacarid obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize837446894(Pipe obj, int objTypeId, ProtoWriter writer)
	{
		if (obj.parentPipeUID != null)
		{
			ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
			ProtoWriter.WriteString(obj.parentPipeUID, writer);
		}
	}

	private Pipe Deserialize837446894(Pipe obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				obj.parentPipeUID = reader.ReadString();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize955443574(PipeSurfaceFloater obj, int objTypeId, ProtoWriter writer)
	{
		if (obj.childPipeUID != null)
		{
			foreach (string text in obj.childPipeUID)
			{
				if (text != null)
				{
					ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
					ProtoWriter.WriteString(text, writer);
				}
			}
		}
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.deployed, writer);
	}

	private PipeSurfaceFloater Deserialize955443574(PipeSurfaceFloater obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.deployed = reader.ReadBoolean();
				}
			}
			else
			{
				List<string> list = new List<string>();
				int fieldNumber = reader.FieldNumber;
				do
				{
					string item = reader.ReadString();
					list.Add(item);
				}
				while (reader.TryReadFieldHeader(fieldNumber));
				obj.childPipeUID = list.ToArray();
			}
		}
		return obj;
	}

	private void Serialize542223321(Plantable obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.planterSlotId, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.plantAge, writer);
	}

	private Plantable Deserialize542223321(Plantable obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.planterSlotId = reader.ReadInt32();
				break;
			case 3:
				obj.plantAge = reader.ReadSingle();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1875862075(Player obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.serializedIsUnderwater, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.serializedDepthClass, writer);
		if (obj.knownTech != null)
		{
			foreach (int value in obj.knownTech)
			{
				ProtoWriter.WriteFieldHeader(5, WireType.Variant, writer);
				ProtoWriter.WriteInt32(value, writer);
			}
		}
		if (obj.currentSubUID != null)
		{
			ProtoWriter.WriteFieldHeader(6, WireType.String, writer);
			ProtoWriter.WriteString(obj.currentSubUID, writer);
		}
		if (obj.journal != null)
		{
			foreach (KeyValuePair<string, PDALog.Entry> obj2 in obj.journal)
			{
				ProtoWriter.WriteFieldHeader(7, WireType.String, writer);
				SubItemToken token = ProtoWriter.StartSubItem(null, writer);
				this.Serialize1062675616(obj2, objTypeId, writer);
				ProtoWriter.EndSubItem(token, writer);
			}
		}
		if (obj.encyclopedia != null)
		{
			foreach (KeyValuePair<string, PDAEncyclopedia.Entry> obj3 in obj.encyclopedia)
			{
				ProtoWriter.WriteFieldHeader(8, WireType.String, writer);
				SubItemToken token2 = ProtoWriter.StartSubItem(null, writer);
				this.Serialize121008834(obj3, objTypeId, writer);
				ProtoWriter.EndSubItem(token2, writer);
			}
		}
		if (obj.scanner != null)
		{
			ProtoWriter.WriteFieldHeader(9, WireType.String, writer);
			SubItemToken token3 = ProtoWriter.StartSubItem(obj.scanner, writer);
			this.Serialize2137760429(obj.scanner, objTypeId, writer);
			ProtoWriter.EndSubItem(token3, writer);
		}
		if (obj.currentWaterParkUID != null)
		{
			ProtoWriter.WriteFieldHeader(10, WireType.String, writer);
			ProtoWriter.WriteString(obj.currentWaterParkUID, writer);
		}
		if (obj.usedTools != null)
		{
			foreach (int value2 in obj.usedTools)
			{
				ProtoWriter.WriteFieldHeader(11, WireType.Variant, writer);
				ProtoWriter.WriteInt32(value2, writer);
			}
		}
		ProtoWriter.WriteFieldHeader(12, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.forceWalkMotorMode, writer);
		if (obj.analyzedTech != null)
		{
			foreach (int value3 in obj.analyzedTech)
			{
				ProtoWriter.WriteFieldHeader(13, WireType.Variant, writer);
				ProtoWriter.WriteInt32(value3, writer);
			}
		}
		ProtoWriter.WriteFieldHeader(14, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.isSick, writer);
		if (obj.notifications != null)
		{
			ProtoWriter.WriteFieldHeader(15, WireType.String, writer);
			SubItemToken token4 = ProtoWriter.StartSubItem(obj.notifications, writer);
			this.Serialize348559960(obj.notifications, objTypeId, writer);
			ProtoWriter.EndSubItem(token4, writer);
		}
		ProtoWriter.WriteFieldHeader(16, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj._displaySurfaceWater, writer);
		ProtoWriter.WriteFieldHeader(17, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.timeLastSleep, writer);
		if (obj.timeCapsules != null)
		{
			foreach (KeyValuePair<string, TimeCapsuleContent> obj4 in obj.timeCapsules)
			{
				ProtoWriter.WriteFieldHeader(19, WireType.String, writer);
				SubItemToken token5 = ProtoWriter.StartSubItem(null, writer);
				this.Serialize1249808124(obj4, objTypeId, writer);
				ProtoWriter.EndSubItem(token5, writer);
			}
		}
		if (obj.currentRespawnInteriorUID != null)
		{
			ProtoWriter.WriteFieldHeader(20, WireType.String, writer);
			ProtoWriter.WriteString(obj.currentRespawnInteriorUID, writer);
		}
		if (obj.currentInteriorUID != null)
		{
			ProtoWriter.WriteFieldHeader(21, WireType.String, writer);
			ProtoWriter.WriteString(obj.currentInteriorUID, writer);
		}
		if (obj.pins != null)
		{
			foreach (int value4 in obj.pins)
			{
				ProtoWriter.WriteFieldHeader(22, WireType.Variant, writer);
				ProtoWriter.WriteInt32(value4, writer);
			}
		}
		if (obj.unlockedTracks != null)
		{
			foreach (int value5 in obj.unlockedTracks)
			{
				ProtoWriter.WriteFieldHeader(23, WireType.Variant, writer);
				ProtoWriter.WriteInt32(value5, writer);
			}
		}
		ProtoWriter.WriteFieldHeader(24, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.hasUsedConsole, writer);
		if (obj.incomingCall != null)
		{
			ProtoWriter.WriteFieldHeader(25, WireType.String, writer);
			ProtoWriter.WriteString(obj.incomingCall, writer);
		}
		if (obj.fallbackRespawnInteriorUID != null)
		{
			ProtoWriter.WriteFieldHeader(26, WireType.String, writer);
			ProtoWriter.WriteString(obj.fallbackRespawnInteriorUID, writer);
		}
		ProtoWriter.WriteFieldHeader(27, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.rotationX, writer);
		ProtoWriter.WriteFieldHeader(28, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.rotationY, writer);
		ProtoWriter.WriteFieldHeader(29, WireType.Variant, writer);
		ProtoWriter.WriteInt32((int)obj.suffocationState, writer);
		ProtoWriter.WriteFieldHeader(30, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.suffocationProgress, writer);
	}

	private Player Deserialize1875862075(Player obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		while (i > 0)
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.serializedIsUnderwater = reader.ReadBoolean();
				break;
			case 3:
				obj.serializedDepthClass = reader.ReadInt32();
				break;
			case 4:
			case 18:
				goto IL_421;
			case 5:
			{
				List<TechType> list = new List<TechType>();
				int fieldNumber = reader.FieldNumber;
				do
				{
					TechType item = (TechType)reader.ReadInt32();
					list.Add(item);
				}
				while (reader.TryReadFieldHeader(fieldNumber));
				obj.knownTech = list;
				break;
			}
			case 6:
				obj.currentSubUID = reader.ReadString();
				break;
			case 7:
			{
				Dictionary<string, PDALog.Entry> dictionary = new Dictionary<string, PDALog.Entry>();
				int fieldNumber2 = reader.FieldNumber;
				do
				{
					KeyValuePair<string, PDALog.Entry> obj2 = default(KeyValuePair<string, PDALog.Entry>);
					SubItemToken token = ProtoReader.StartSubItem(reader);
					obj2 = this.Deserialize1062675616(obj2, reader);
					ProtoReader.EndSubItem(token, reader);
					dictionary[obj2.Key] = obj2.Value;
				}
				while (reader.TryReadFieldHeader(fieldNumber2));
				obj.journal = dictionary;
				break;
			}
			case 8:
			{
				Dictionary<string, PDAEncyclopedia.Entry> dictionary2 = new Dictionary<string, PDAEncyclopedia.Entry>();
				int fieldNumber3 = reader.FieldNumber;
				do
				{
					KeyValuePair<string, PDAEncyclopedia.Entry> obj3 = default(KeyValuePair<string, PDAEncyclopedia.Entry>);
					SubItemToken token2 = ProtoReader.StartSubItem(reader);
					obj3 = this.Deserialize121008834(obj3, reader);
					ProtoReader.EndSubItem(token2, reader);
					dictionary2[obj3.Key] = obj3.Value;
				}
				while (reader.TryReadFieldHeader(fieldNumber3));
				obj.encyclopedia = dictionary2;
				break;
			}
			case 9:
			{
				SubItemToken token3 = ProtoReader.StartSubItem(reader);
				obj.scanner = this.Deserialize2137760429(obj.scanner, reader);
				ProtoReader.EndSubItem(token3, reader);
				break;
			}
			case 10:
				obj.currentWaterParkUID = reader.ReadString();
				break;
			case 11:
			{
				HashSet<TechType> hashSet = obj.usedTools ?? new HashSet<TechType>();
				int fieldNumber4 = reader.FieldNumber;
				do
				{
					TechType item2 = (TechType)reader.ReadInt32();
					hashSet.Add(item2);
				}
				while (reader.TryReadFieldHeader(fieldNumber4));
				break;
			}
			case 12:
				obj.forceWalkMotorMode = reader.ReadBoolean();
				break;
			case 13:
			{
				HashSet<TechType> hashSet2 = new HashSet<TechType>();
				int fieldNumber5 = reader.FieldNumber;
				do
				{
					TechType item3 = (TechType)reader.ReadInt32();
					hashSet2.Add(item3);
				}
				while (reader.TryReadFieldHeader(fieldNumber5));
				obj.analyzedTech = hashSet2;
				break;
			}
			case 14:
				obj.isSick = reader.ReadBoolean();
				break;
			case 15:
			{
				SubItemToken token4 = ProtoReader.StartSubItem(reader);
				obj.notifications = this.Deserialize348559960(obj.notifications, reader);
				ProtoReader.EndSubItem(token4, reader);
				break;
			}
			case 16:
				obj._displaySurfaceWater = reader.ReadBoolean();
				break;
			case 17:
				obj.timeLastSleep = reader.ReadSingle();
				break;
			case 19:
			{
				Dictionary<string, TimeCapsuleContent> dictionary3 = new Dictionary<string, TimeCapsuleContent>();
				int fieldNumber6 = reader.FieldNumber;
				do
				{
					KeyValuePair<string, TimeCapsuleContent> obj4 = default(KeyValuePair<string, TimeCapsuleContent>);
					SubItemToken token5 = ProtoReader.StartSubItem(reader);
					obj4 = this.Deserialize1249808124(obj4, reader);
					ProtoReader.EndSubItem(token5, reader);
					dictionary3[obj4.Key] = obj4.Value;
				}
				while (reader.TryReadFieldHeader(fieldNumber6));
				obj.timeCapsules = dictionary3;
				break;
			}
			case 20:
				obj.currentRespawnInteriorUID = reader.ReadString();
				break;
			case 21:
				obj.currentInteriorUID = reader.ReadString();
				break;
			case 22:
			{
				List<TechType> list2 = new List<TechType>();
				int fieldNumber7 = reader.FieldNumber;
				do
				{
					TechType item4 = (TechType)reader.ReadInt32();
					list2.Add(item4);
				}
				while (reader.TryReadFieldHeader(fieldNumber7));
				obj.pins = list2;
				break;
			}
			case 23:
			{
				List<Jukebox.UnlockableTrack> list3 = obj.unlockedTracks ?? new List<Jukebox.UnlockableTrack>();
				int fieldNumber8 = reader.FieldNumber;
				do
				{
					Jukebox.UnlockableTrack item5 = (Jukebox.UnlockableTrack)reader.ReadInt32();
					list3.Add(item5);
				}
				while (reader.TryReadFieldHeader(fieldNumber8));
				break;
			}
			case 24:
				obj.hasUsedConsole = reader.ReadBoolean();
				break;
			case 25:
				obj.incomingCall = reader.ReadString();
				break;
			case 26:
				obj.fallbackRespawnInteriorUID = reader.ReadString();
				break;
			case 27:
				obj.rotationX = reader.ReadSingle();
				break;
			case 28:
				obj.rotationY = reader.ReadSingle();
				break;
			case 29:
				obj.suffocationState = (Player.SuffocationState)reader.ReadInt32();
				break;
			case 30:
				obj.suffocationProgress = reader.ReadSingle();
				break;
			default:
				goto IL_421;
			}
			IL_427:
			i = reader.ReadFieldHeader();
			continue;
			IL_421:
			reader.SkipField();
			goto IL_427;
		}
		return obj;
	}

	private void Serialize424968344(PlayerLilyPaddlerHypnosis obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.hypnotized, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Fixed64, writer);
		ProtoWriter.WriteDouble(obj.hypnosysStartTime, writer);
	}

	private PlayerLilyPaddlerHypnosis Deserialize424968344(PlayerLilyPaddlerHypnosis obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.hypnotized = reader.ReadBoolean();
				break;
			case 3:
				obj.hypnosysStartTime = reader.ReadDouble();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize10406022(PlayerSoundTrigger obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.triggered, writer);
	}

	private PlayerSoundTrigger Deserialize10406022(PlayerSoundTrigger obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				obj.triggered = reader.ReadBoolean();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize407275749(PlayerTimeCapsule obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj._serializedVersion, writer);
		if (obj._text != null)
		{
			ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
			ProtoWriter.WriteString(obj._text, writer);
		}
		if (obj._title != null)
		{
			ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
			ProtoWriter.WriteString(obj._title, writer);
		}
		if (obj._image != null)
		{
			byte[] image = obj._image;
			ProtoWriter.WriteFieldHeader(4, WireType.String, writer);
			ProtoWriter.WriteBytes(image, writer);
		}
		ProtoWriter.WriteFieldHeader(5, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj._submit, writer);
		if (obj._openQueue != null)
		{
			foreach (string text in obj._openQueue)
			{
				if (text != null)
				{
					ProtoWriter.WriteFieldHeader(6, WireType.String, writer);
					ProtoWriter.WriteString(text, writer);
				}
			}
		}
	}

	private PlayerTimeCapsule Deserialize407275749(PlayerTimeCapsule obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj._serializedVersion = reader.ReadInt32();
				break;
			case 2:
				obj._text = reader.ReadString();
				break;
			case 3:
				obj._title = reader.ReadString();
				break;
			case 4:
				obj._image = ProtoReader.AppendBytes(obj._image, reader);
				break;
			case 5:
				obj._submit = reader.ReadBoolean();
				break;
			case 6:
			{
				List<string> list = obj._openQueue ?? new List<string>();
				int fieldNumber = reader.FieldNumber;
				do
				{
					string item = reader.ReadString();
					list.Add(item);
				}
				while (reader.TryReadFieldHeader(fieldNumber));
				break;
			}
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1675048343(PlayerWorldArrows obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		if (obj.completedCustomGoals != null)
		{
			foreach (string text in obj.completedCustomGoals)
			{
				if (text != null)
				{
					ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
					ProtoWriter.WriteString(text, writer);
				}
			}
		}
	}

	private PlayerWorldArrows Deserialize1675048343(PlayerWorldArrows obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					HashSet<string> hashSet = obj.completedCustomGoals ?? new HashSet<string>();
					int fieldNumber = reader.FieldNumber;
					do
					{
						string item = reader.ReadString();
						hashSet.Add(item);
					}
					while (reader.TryReadFieldHeader(fieldNumber));
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize1386435207(PowerCellCharger obj, int objTypeId, ProtoWriter writer)
	{
	}

	private PowerCellCharger Deserialize1386435207(PowerCellCharger obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1800229096(PowerCrafter obj, int objTypeId, ProtoWriter writer)
	{
		if (objTypeId == 1011566978)
		{
			ProtoWriter.WriteFieldHeader(5110, WireType.String, writer);
			SubItemToken token = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1011566978(obj as Bioreactor, objTypeId, writer);
			ProtoWriter.EndSubItem(token, writer);
			return;
		}
		if (objTypeId == 802993602)
		{
			ProtoWriter.WriteFieldHeader(5120, WireType.String, writer);
			SubItemToken token2 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize802993602(obj as NuclearReactor, objTypeId, writer);
			ProtoWriter.EndSubItem(token2, writer);
		}
	}

	private PowerCrafter Deserialize1800229096(PowerCrafter obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 5110)
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1011566978(obj as Bioreactor, reader);
				ProtoReader.EndSubItem(token, reader);
			}
			else
			{
				if (i != 5120)
				{
					IL_6B:
					while (i > 0)
					{
						reader.SkipField();
						i = reader.ReadFieldHeader();
					}
					return obj;
				}
				SubItemToken token2 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize802993602(obj as NuclearReactor, reader);
				ProtoReader.EndSubItem(token2, reader);
			}
		}
		goto IL_6B;
	}

	private void Serialize797173896(PowerGenerator obj, int objTypeId, ProtoWriter writer)
	{
	}

	private PowerGenerator Deserialize797173896(PowerGenerator obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1522229446(PowerSource obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.power, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.maxPower, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
	}

	private PowerSource Deserialize1522229446(PowerSource obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.power = reader.ReadSingle();
				break;
			case 2:
				obj.maxPower = reader.ReadSingle();
				break;
			case 3:
				obj.version = reader.ReadInt32();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize356984973(PrecursorAquariumPlatformTrigger obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.triggered, writer);
	}

	private PrecursorAquariumPlatformTrigger Deserialize356984973(PrecursorAquariumPlatformTrigger obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.triggered = reader.ReadBoolean();
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize1541346828(PrecursorComputerTerminal obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.used, writer);
	}

	private PrecursorComputerTerminal Deserialize1541346828(PrecursorComputerTerminal obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.used = reader.ReadBoolean();
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize1457139245(PrecursorDisableGunTerminal obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.firstUse, writer);
	}

	private PrecursorDisableGunTerminal Deserialize1457139245(PrecursorDisableGunTerminal obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 2)
			{
				obj.firstUse = reader.ReadBoolean();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize1505210158(PrecursorDoorKeyColumn obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.unlocked, writer);
	}

	private PrecursorDoorKeyColumn Deserialize1505210158(PrecursorDoorKeyColumn obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.unlocked = reader.ReadBoolean();
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize185046565(PrecursorElevator obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.elevatorPointIndex, writer);
	}

	private PrecursorElevator Deserialize185046565(PrecursorElevator obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				obj.elevatorPointIndex = reader.ReadInt32();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize285680569(PrecursorGunStoryEvents obj, int objTypeId, ProtoWriter writer)
	{
	}

	private PrecursorGunStoryEvents Deserialize285680569(PrecursorGunStoryEvents obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize999481743(PrecursorIonCrystal obj, int objTypeId, ProtoWriter writer)
	{
	}

	private PrecursorIonCrystal Deserialize999481743(PrecursorIonCrystal obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize2051895012(PrecursorKeyTerminal obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.slotted, writer);
	}

	private PrecursorKeyTerminal Deserialize2051895012(PrecursorKeyTerminal obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.slotted = reader.ReadBoolean();
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize309711119(PrecursorPartFabricator obj, int objTypeId, ProtoWriter writer)
	{
	}

	private PrecursorPartFabricator Deserialize309711119(PrecursorPartFabricator obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize496960061(PrecursorPrisonVent obj, int objTypeId, ProtoWriter writer)
	{
	}

	private PrecursorPrisonVent Deserialize496960061(PrecursorPrisonVent obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1169611549(PrecursorSurfaceVent obj, int objTypeId, ProtoWriter writer)
	{
	}

	private PrecursorSurfaceVent Deserialize1169611549(PrecursorSurfaceVent obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1340645883(PrecursorTeleporter obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.isOpen, writer);
	}

	private PrecursorTeleporter Deserialize1340645883(PrecursorTeleporter obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				obj.isOpen = reader.ReadBoolean();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize1713660373(PrecursorTeleporterActivationTerminal obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.unlocked, writer);
	}

	private PrecursorTeleporterActivationTerminal Deserialize1713660373(PrecursorTeleporterActivationTerminal obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.unlocked = reader.ReadBoolean();
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize2111234577(PrefabPlaceholdersGroup obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.isInitialized, writer);
	}

	private PrefabPlaceholdersGroup Deserialize2111234577(PrefabPlaceholdersGroup obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.isInitialized = reader.ReadBoolean();
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize851981872(PrisonManager obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.numCreatures, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1181346079(obj.exitPoint, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.babiesHatched, writer);
	}

	private PrisonManager Deserialize851981872(PrisonManager obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.numCreatures = reader.ReadInt32();
				break;
			case 3:
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj.exitPoint = this.Deserialize1181346079(obj.exitPoint, reader);
				ProtoReader.EndSubItem(token, reader);
				break;
			}
			case 4:
				obj.babiesHatched = reader.ReadBoolean();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1677184373(PropulseCannonAmmoHandler obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.addedDamageOnImpact, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.behaviorWasEnabled, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.wasShot, writer);
		ProtoWriter.WriteFieldHeader(5, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.timeShot, writer);
		ProtoWriter.WriteFieldHeader(6, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.locomotionWasEnabled, writer);
		ProtoWriter.WriteFieldHeader(7, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1181346079(obj.velocity, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
	}

	private PropulseCannonAmmoHandler Deserialize1677184373(PropulseCannonAmmoHandler obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.addedDamageOnImpact = reader.ReadBoolean();
				break;
			case 3:
				obj.behaviorWasEnabled = reader.ReadBoolean();
				break;
			case 4:
				obj.wasShot = reader.ReadBoolean();
				break;
			case 5:
				obj.timeShot = reader.ReadSingle();
				break;
			case 6:
				obj.locomotionWasEnabled = reader.ReadBoolean();
				break;
			case 7:
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj.velocity = this.Deserialize1181346079(obj.velocity, reader);
				ProtoReader.EndSubItem(token, reader);
				break;
			}
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize313352173(ProtobufSerializer.ComponentHeader obj, int objTypeId, ProtoWriter writer)
	{
		if (obj.TypeName != null)
		{
			ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
			ProtoWriter.WriteString(obj.TypeName, writer);
		}
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.IsEnabled, writer);
	}

	private ProtobufSerializer.ComponentHeader Deserialize313352173(ProtobufSerializer.ComponentHeader obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		if (obj == null)
		{
			obj = new ProtobufSerializer.ComponentHeader();
			ProtoReader.NoteObject(obj, reader);
		}
		while (i > 0)
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.IsEnabled = reader.ReadBoolean();
				}
			}
			else
			{
				obj.TypeName = reader.ReadString();
			}
			i = reader.ReadFieldHeader();
		}
		return obj;
	}

	private void Serialize1159039820(ProtobufSerializer.GameObjectData obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.CreateEmptyObject, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.IsActive, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.Layer, writer);
		if (obj.Tag != null)
		{
			ProtoWriter.WriteFieldHeader(4, WireType.String, writer);
			ProtoWriter.WriteString(obj.Tag, writer);
		}
		if (obj.Id != null)
		{
			ProtoWriter.WriteFieldHeader(6, WireType.String, writer);
			ProtoWriter.WriteString(obj.Id, writer);
		}
		if (obj.ClassId != null)
		{
			ProtoWriter.WriteFieldHeader(7, WireType.String, writer);
			ProtoWriter.WriteString(obj.ClassId, writer);
		}
		if (obj.Parent != null)
		{
			ProtoWriter.WriteFieldHeader(8, WireType.String, writer);
			ProtoWriter.WriteString(obj.Parent, writer);
		}
		ProtoWriter.WriteFieldHeader(9, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.OverridePrefab, writer);
		ProtoWriter.WriteFieldHeader(10, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.MergeObject, writer);
	}

	private ProtobufSerializer.GameObjectData Deserialize1159039820(ProtobufSerializer.GameObjectData obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		if (obj == null)
		{
			obj = new ProtobufSerializer.GameObjectData();
			ProtoReader.NoteObject(obj, reader);
		}
		while (i > 0)
		{
			switch (i)
			{
			case 1:
				obj.CreateEmptyObject = reader.ReadBoolean();
				break;
			case 2:
				obj.IsActive = reader.ReadBoolean();
				break;
			case 3:
				obj.Layer = reader.ReadInt32();
				break;
			case 4:
				obj.Tag = reader.ReadString();
				break;
			case 5:
				goto IL_D0;
			case 6:
				obj.Id = reader.ReadString();
				break;
			case 7:
				obj.ClassId = reader.ReadString();
				break;
			case 8:
				obj.Parent = reader.ReadString();
				break;
			case 9:
				obj.OverridePrefab = reader.ReadBoolean();
				break;
			case 10:
				obj.MergeObject = reader.ReadBoolean();
				break;
			default:
				goto IL_D0;
			}
			IL_D6:
			i = reader.ReadFieldHeader();
			continue;
			IL_D0:
			reader.SkipField();
			goto IL_D6;
		}
		return obj;
	}

	private void Serialize69304398(ProtobufSerializer.LoopHeader obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.Count, writer);
	}

	private ProtobufSerializer.LoopHeader Deserialize69304398(ProtobufSerializer.LoopHeader obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		if (obj == null)
		{
			obj = new ProtobufSerializer.LoopHeader();
			ProtoReader.NoteObject(obj, reader);
		}
		while (i > 0)
		{
			if (i == 1)
			{
				obj.Count = reader.ReadInt32();
			}
			else
			{
				reader.SkipField();
			}
			i = reader.ReadFieldHeader();
		}
		return obj;
	}

	private void Serialize217879716(ProtobufSerializer.StreamHeader obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.Signature, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.Version, writer);
	}

	private ProtobufSerializer.StreamHeader Deserialize217879716(ProtobufSerializer.StreamHeader obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		if (obj == null)
		{
			obj = new ProtobufSerializer.StreamHeader();
			ProtoReader.NoteObject(obj, reader);
		}
		while (i > 0)
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.Version = reader.ReadInt32();
				}
			}
			else
			{
				obj.Signature = reader.ReadInt32();
			}
			i = reader.ReadFieldHeader();
		}
		return obj;
	}

	private void Serialize328142573(ProtobufSerializerCornerCases obj, int objTypeId, ProtoWriter writer)
	{
		if (obj.ListOfClassInstances != null)
		{
			foreach (SceneObjectData sceneObjectData in obj.ListOfClassInstances)
			{
				if (sceneObjectData != null)
				{
					ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
					SubItemToken token = ProtoWriter.StartSubItem(sceneObjectData, writer);
					this.Serialize1881457915(sceneObjectData, objTypeId, writer);
					ProtoWriter.EndSubItem(token, writer);
				}
			}
		}
		if (obj.DictionaryOfClassInstances != null)
		{
			foreach (KeyValuePair<int, SceneObjectData> obj2 in obj.DictionaryOfClassInstances)
			{
				ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
				SubItemToken token2 = ProtoWriter.StartSubItem(null, writer);
				this.Serialize1116754719(obj2, objTypeId, writer);
				ProtoWriter.EndSubItem(token2, writer);
			}
		}
		if (obj.NullableStruct != null)
		{
			ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
			SubItemToken token3 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1181346079(obj.NullableStruct.GetValueOrDefault(), objTypeId, writer);
			ProtoWriter.EndSubItem(token3, writer);
		}
		if (obj.NullableEnum != null)
		{
			ProtoWriter.WriteFieldHeader(4, WireType.Variant, writer);
			ProtoWriter.WriteInt32((int)obj.NullableEnum.GetValueOrDefault(), writer);
		}
		if (obj.FloatGrid != null)
		{
			ProtoWriter.WriteFieldHeader(5, WireType.String, writer);
			SubItemToken token4 = ProtoWriter.StartSubItem(obj.FloatGrid, writer);
			this.Serialize1182280616(obj.FloatGrid, objTypeId, writer);
			ProtoWriter.EndSubItem(token4, writer);
		}
		if (obj.Vector3Grid != null)
		{
			ProtoWriter.WriteFieldHeader(6, WireType.String, writer);
			SubItemToken token5 = ProtoWriter.StartSubItem(obj.Vector3Grid, writer);
			this.Serialize1765532648(obj.Vector3Grid, objTypeId, writer);
			ProtoWriter.EndSubItem(token5, writer);
		}
		if (obj.EmptyArray != null)
		{
			foreach (int value in obj.EmptyArray)
			{
				ProtoWriter.WriteFieldHeader(7, WireType.Variant, writer);
				ProtoWriter.WriteInt32(value, writer);
			}
		}
		if (obj.InitializedSet != null)
		{
			foreach (string text in obj.InitializedSet)
			{
				if (text != null)
				{
					ProtoWriter.WriteFieldHeader(8, WireType.String, writer);
					ProtoWriter.WriteString(text, writer);
				}
			}
		}
	}

	private ProtobufSerializerCornerCases Deserialize328142573(ProtobufSerializerCornerCases obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		if (obj == null)
		{
			obj = new ProtobufSerializerCornerCases();
			ProtoReader.NoteObject(obj, reader);
		}
		while (i > 0)
		{
			switch (i)
			{
			case 1:
			{
				List<SceneObjectData> list = new List<SceneObjectData>();
				int fieldNumber = reader.FieldNumber;
				do
				{
					SceneObjectData sceneObjectData = new SceneObjectData();
					SubItemToken token = ProtoReader.StartSubItem(reader);
					sceneObjectData = this.Deserialize1881457915(sceneObjectData, reader);
					ProtoReader.EndSubItem(token, reader);
					list.Add(sceneObjectData);
				}
				while (reader.TryReadFieldHeader(fieldNumber));
				obj.ListOfClassInstances = list;
				break;
			}
			case 2:
			{
				Dictionary<int, SceneObjectData> dictionary = new Dictionary<int, SceneObjectData>();
				int fieldNumber2 = reader.FieldNumber;
				do
				{
					KeyValuePair<int, SceneObjectData> obj2 = default(KeyValuePair<int, SceneObjectData>);
					SubItemToken token2 = ProtoReader.StartSubItem(reader);
					obj2 = this.Deserialize1116754719(obj2, reader);
					ProtoReader.EndSubItem(token2, reader);
					dictionary[obj2.Key] = obj2.Value;
				}
				while (reader.TryReadFieldHeader(fieldNumber2));
				obj.DictionaryOfClassInstances = dictionary;
				break;
			}
			case 3:
			{
				SubItemToken token3 = ProtoReader.StartSubItem(reader);
				obj.NullableStruct = new Vector3?(this.Deserialize1181346079(obj.NullableStruct.GetValueOrDefault(), reader));
				ProtoReader.EndSubItem(token3, reader);
				break;
			}
			case 4:
				obj.NullableEnum = new CubemapFace?((CubemapFace)reader.ReadInt32());
				break;
			case 5:
			{
				SubItemToken token4 = ProtoReader.StartSubItem(reader);
				obj.FloatGrid = this.Deserialize1182280616(obj.FloatGrid, reader);
				ProtoReader.EndSubItem(token4, reader);
				break;
			}
			case 6:
			{
				SubItemToken token5 = ProtoReader.StartSubItem(reader);
				obj.Vector3Grid = this.Deserialize1765532648(obj.Vector3Grid, reader);
				ProtoReader.EndSubItem(token5, reader);
				break;
			}
			case 7:
			{
				List<int> list2 = new List<int>();
				int fieldNumber3 = reader.FieldNumber;
				do
				{
					int item = reader.ReadInt32();
					list2.Add(item);
				}
				while (reader.TryReadFieldHeader(fieldNumber3));
				obj.EmptyArray = list2.ToArray();
				break;
			}
			case 8:
			{
				HashSet<string> hashSet = obj.InitializedSet ?? new HashSet<string>();
				int fieldNumber4 = reader.FieldNumber;
				do
				{
					string item2 = reader.ReadString();
					hashSet.Add(item2);
				}
				while (reader.TryReadFieldHeader(fieldNumber4));
				break;
			}
			default:
				reader.SkipField();
				break;
			}
			i = reader.ReadFieldHeader();
		}
		return obj;
	}

	private void Serialize1186708671(QuantumLocker obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.protoVersion, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.landDeployed, writer);
	}

	private QuantumLocker Deserialize1186708671(QuantumLocker obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 3)
				{
					reader.SkipField();
				}
				else
				{
					obj.landDeployed = reader.ReadBoolean();
				}
			}
			else
			{
				obj.protoVersion = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize1082285174(RabbitRay obj, int objTypeId, ProtoWriter writer)
	{
	}

	private RabbitRay Deserialize1082285174(RabbitRay obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1702762571(ReaperLeviathan obj, int objTypeId, ProtoWriter writer)
	{
	}

	private ReaperLeviathan Deserialize1702762571(ReaperLeviathan obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1651949009(Reefback obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Reefback Deserialize1651949009(Reefback obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize803494206(ReefbackCreature obj, int objTypeId, ProtoWriter writer)
	{
	}

	private ReefbackCreature Deserialize803494206(ReefbackCreature obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1077102969(ReefbackLife obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.initialized, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.hasCorals, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.grassIndex, writer);
	}

	private ReefbackLife Deserialize1077102969(ReefbackLife obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.initialized = reader.ReadBoolean();
				break;
			case 3:
				obj.hasCorals = reader.ReadBoolean();
				break;
			case 4:
				obj.grassIndex = reader.ReadInt32();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1948869956(ReefbackPlant obj, int objTypeId, ProtoWriter writer)
	{
	}

	private ReefbackPlant Deserialize1948869956(ReefbackPlant obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize924544622(Reginald obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Reginald Deserialize924544622(Reginald obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize2054867230(ResearchBase obj, int objTypeId, ProtoWriter writer)
	{
	}

	private ResearchBase Deserialize2054867230(ResearchBase obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize859052613(ResourceTrackerDatabase obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.serializedVersion, writer);
		if (obj.savedResources != null)
		{
			foreach (ResourceTrackerDatabase.ResourceInfo resourceInfo in obj.savedResources)
			{
				if (resourceInfo != null)
				{
					ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
					SubItemToken token = ProtoWriter.StartSubItem(resourceInfo, writer);
					this.Serialize161874211(resourceInfo, objTypeId, writer);
					ProtoWriter.EndSubItem(token, writer);
				}
			}
		}
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.storedChangeSet, writer);
	}

	private ResourceTrackerDatabase Deserialize859052613(ResourceTrackerDatabase obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.serializedVersion = reader.ReadInt32();
				break;
			case 2:
			{
				List<ResourceTrackerDatabase.ResourceInfo> list = obj.savedResources ?? new List<ResourceTrackerDatabase.ResourceInfo>();
				int fieldNumber = reader.FieldNumber;
				do
				{
					ResourceTrackerDatabase.ResourceInfo resourceInfo = new ResourceTrackerDatabase.ResourceInfo();
					SubItemToken token = ProtoReader.StartSubItem(reader);
					resourceInfo = this.Deserialize161874211(resourceInfo, reader);
					ProtoReader.EndSubItem(token, reader);
					list.Add(resourceInfo);
				}
				while (reader.TryReadFieldHeader(fieldNumber));
				break;
			}
			case 3:
				obj.storedChangeSet = reader.ReadInt32();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize161874211(ResourceTrackerDatabase.ResourceInfo obj, int objTypeId, ProtoWriter writer)
	{
		if (obj.uniqueId != null)
		{
			ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
			ProtoWriter.WriteString(obj.uniqueId, writer);
		}
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteInt32((int)obj.techType, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1181346079(obj.position, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
	}

	private ResourceTrackerDatabase.ResourceInfo Deserialize161874211(ResourceTrackerDatabase.ResourceInfo obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		if (obj == null)
		{
			obj = new ResourceTrackerDatabase.ResourceInfo();
			ProtoReader.NoteObject(obj, reader);
		}
		while (i > 0)
		{
			switch (i)
			{
			case 1:
				obj.uniqueId = reader.ReadString();
				break;
			case 2:
				obj.techType = (TechType)reader.ReadInt32();
				break;
			case 3:
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj.position = this.Deserialize1181346079(obj.position, reader);
				ProtoReader.EndSubItem(token, reader);
				break;
			}
			default:
				reader.SkipField();
				break;
			}
			i = reader.ReadFieldHeader();
		}
		return obj;
	}

	private void Serialize11492366(Respawn obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.spawnTime, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteInt32((int)obj.techType, writer);
		if (obj.addComponents != null)
		{
			foreach (string text in obj.addComponents)
			{
				if (text != null)
				{
					ProtoWriter.WriteFieldHeader(4, WireType.String, writer);
					ProtoWriter.WriteString(text, writer);
				}
			}
		}
	}

	private Respawn Deserialize11492366(Respawn obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.spawnTime = reader.ReadSingle();
				break;
			case 3:
				obj.techType = (TechType)reader.ReadInt32();
				break;
			case 4:
			{
				List<string> list = obj.addComponents ?? new List<string>();
				int fieldNumber = reader.FieldNumber;
				do
				{
					string item = reader.ReadString();
					list.Add(item);
				}
				while (reader.TryReadFieldHeader(fieldNumber));
				break;
			}
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize253947874(RestoreAnimatorState obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.stateNameHash, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.normalizedTime, writer);
		if (obj.parameterValues != null)
		{
			foreach (AnimatorParameterValue animatorParameterValue in obj.parameterValues)
			{
				if (animatorParameterValue != null)
				{
					ProtoWriter.WriteFieldHeader(4, WireType.String, writer);
					SubItemToken token = ProtoWriter.StartSubItem(animatorParameterValue, writer);
					this.Serialize880630407(animatorParameterValue, objTypeId, writer);
					ProtoWriter.EndSubItem(token, writer);
				}
			}
		}
	}

	private RestoreAnimatorState Deserialize253947874(RestoreAnimatorState obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.stateNameHash = reader.ReadInt32();
				break;
			case 3:
				obj.normalizedTime = reader.ReadSingle();
				break;
			case 4:
			{
				List<AnimatorParameterValue> list = obj.parameterValues ?? new List<AnimatorParameterValue>();
				int fieldNumber = reader.FieldNumber;
				do
				{
					AnimatorParameterValue animatorParameterValue = new AnimatorParameterValue();
					SubItemToken token = ProtoReader.StartSubItem(reader);
					animatorParameterValue = this.Deserialize880630407(animatorParameterValue, reader);
					ProtoReader.EndSubItem(token, reader);
					list.Add(animatorParameterValue);
				}
				while (reader.TryReadFieldHeader(fieldNumber));
				break;
			}
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize273953122(RestoreDayNightCycle obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.timePassed, writer);
	}

	private RestoreDayNightCycle Deserialize273953122(RestoreDayNightCycle obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				obj.timePassed = reader.ReadSingle();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize2024062491(RestoreInventoryStorage obj, int objTypeId, ProtoWriter writer)
	{
		if (obj.serialData != null)
		{
			byte[] serialData = obj.serialData;
			ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
			ProtoWriter.WriteBytes(serialData, writer);
		}
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.food, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.water, writer);
		if (obj.completedCustomGoals != null)
		{
			foreach (string text in obj.completedCustomGoals)
			{
				if (text != null)
				{
					ProtoWriter.WriteFieldHeader(4, WireType.String, writer);
					ProtoWriter.WriteString(text, writer);
				}
			}
		}
	}

	private RestoreInventoryStorage Deserialize2024062491(RestoreInventoryStorage obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.serialData = ProtoReader.AppendBytes(obj.serialData, reader);
				break;
			case 2:
				obj.food = reader.ReadSingle();
				break;
			case 3:
				obj.water = reader.ReadSingle();
				break;
			case 4:
			{
				List<string> list = new List<string>();
				int fieldNumber = reader.FieldNumber;
				do
				{
					string item = reader.ReadString();
					list.Add(item);
				}
				while (reader.TryReadFieldHeader(fieldNumber));
				obj.completedCustomGoals = list;
				break;
			}
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1273669126(Rocket obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.currentRocketStage, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteInt32((int)obj.elevatorState, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.elevatorPosition, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.currentVersion, writer);
		if (obj.rocketName != null)
		{
			ProtoWriter.WriteFieldHeader(5, WireType.String, writer);
			ProtoWriter.WriteString(obj.rocketName, writer);
		}
		if (obj.rocketColors != null)
		{
			foreach (Vector3 obj2 in obj.rocketColors)
			{
				ProtoWriter.WriteFieldHeader(6, WireType.String, writer);
				SubItemToken token = ProtoWriter.StartSubItem(null, writer);
				this.Serialize1181346079(obj2, objTypeId, writer);
				ProtoWriter.EndSubItem(token, writer);
			}
		}
	}

	private Rocket Deserialize1273669126(Rocket obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.currentRocketStage = reader.ReadInt32();
				break;
			case 2:
				obj.elevatorState = (Rocket.RocketElevatorStates)reader.ReadInt32();
				break;
			case 3:
				obj.elevatorPosition = reader.ReadSingle();
				break;
			case 4:
				obj.currentVersion = reader.ReadInt32();
				break;
			case 5:
				obj.rocketName = reader.ReadString();
				break;
			case 6:
			{
				List<Vector3> list = new List<Vector3>();
				int fieldNumber = reader.FieldNumber;
				do
				{
					Vector3 vector = default(Vector3);
					SubItemToken token = ProtoReader.StartSubItem(reader);
					vector = this.Deserialize1181346079(vector, reader);
					ProtoReader.EndSubItem(token, reader);
					list.Add(vector);
				}
				while (reader.TryReadFieldHeader(fieldNumber));
				obj.rocketColors = list.ToArray();
				break;
			}
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1170326782(RocketConstructorInput obj, int objTypeId, ProtoWriter writer)
	{
	}

	private RocketConstructorInput Deserialize1170326782(RocketConstructorInput obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize916327342(RocketPreflightCheckManager obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.currentVersion, writer);
		if (obj.preflightChecks != null)
		{
			foreach (int value in obj.preflightChecks)
			{
				ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
				ProtoWriter.WriteInt32(value, writer);
			}
		}
	}

	private RocketPreflightCheckManager Deserialize916327342(RocketPreflightCheckManager obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					HashSet<PreflightCheck> hashSet = obj.preflightChecks ?? new HashSet<PreflightCheck>();
					int fieldNumber = reader.FieldNumber;
					do
					{
						PreflightCheck item = (PreflightCheck)reader.ReadInt32();
						hashSet.Add(item);
					}
					while (reader.TryReadFieldHeader(fieldNumber));
				}
			}
			else
			{
				obj.currentVersion = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize1070978565(RockGrub obj, int objTypeId, ProtoWriter writer)
	{
	}

	private RockGrub Deserialize1070978565(RockGrub obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize842397654(RockPuncher obj, int objTypeId, ProtoWriter writer)
	{
	}

	private RockPuncher Deserialize842397654(RockPuncher obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize82819465(Roost obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Roost Deserialize82819465(Roost obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize81014147(SandShark obj, int objTypeId, ProtoWriter writer)
	{
	}

	private SandShark Deserialize81014147(SandShark obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize846562516(SaveLoadManager.OptionsCache obj, int objTypeId, ProtoWriter writer)
	{
		if (obj._floats != null)
		{
			foreach (KeyValuePair<string, float> obj2 in obj._floats)
			{
				ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
				SubItemToken token = ProtoWriter.StartSubItem(null, writer);
				this.Serialize714689774(obj2, objTypeId, writer);
				ProtoWriter.EndSubItem(token, writer);
			}
		}
		if (obj._strings != null)
		{
			foreach (KeyValuePair<string, string> obj3 in obj._strings)
			{
				ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
				SubItemToken token2 = ProtoWriter.StartSubItem(null, writer);
				this.Serialize524780017(obj3, objTypeId, writer);
				ProtoWriter.EndSubItem(token2, writer);
			}
		}
		if (obj._bools != null)
		{
			foreach (KeyValuePair<string, bool> obj4 in obj._bools)
			{
				ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
				SubItemToken token3 = ProtoWriter.StartSubItem(null, writer);
				this.Serialize1489031418(obj4, objTypeId, writer);
				ProtoWriter.EndSubItem(token3, writer);
			}
		}
		if (obj._ints != null)
		{
			foreach (KeyValuePair<string, int> obj5 in obj._ints)
			{
				ProtoWriter.WriteFieldHeader(4, WireType.String, writer);
				SubItemToken token4 = ProtoWriter.StartSubItem(null, writer);
				this.Serialize224877162(obj5, objTypeId, writer);
				ProtoWriter.EndSubItem(token4, writer);
			}
		}
	}

	private SaveLoadManager.OptionsCache Deserialize846562516(SaveLoadManager.OptionsCache obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		if (obj == null)
		{
			obj = new SaveLoadManager.OptionsCache();
			ProtoReader.NoteObject(obj, reader);
		}
		while (i > 0)
		{
			switch (i)
			{
			case 1:
			{
				Dictionary<string, float> dictionary = obj._floats ?? new Dictionary<string, float>();
				int fieldNumber = reader.FieldNumber;
				do
				{
					KeyValuePair<string, float> obj2 = default(KeyValuePair<string, float>);
					SubItemToken token = ProtoReader.StartSubItem(reader);
					obj2 = this.Deserialize714689774(obj2, reader);
					ProtoReader.EndSubItem(token, reader);
					dictionary[obj2.Key] = obj2.Value;
				}
				while (reader.TryReadFieldHeader(fieldNumber));
				break;
			}
			case 2:
			{
				Dictionary<string, string> dictionary2 = obj._strings ?? new Dictionary<string, string>();
				int fieldNumber2 = reader.FieldNumber;
				do
				{
					KeyValuePair<string, string> obj3 = default(KeyValuePair<string, string>);
					SubItemToken token2 = ProtoReader.StartSubItem(reader);
					obj3 = this.Deserialize524780017(obj3, reader);
					ProtoReader.EndSubItem(token2, reader);
					dictionary2[obj3.Key] = obj3.Value;
				}
				while (reader.TryReadFieldHeader(fieldNumber2));
				break;
			}
			case 3:
			{
				Dictionary<string, bool> dictionary3 = obj._bools ?? new Dictionary<string, bool>();
				int fieldNumber3 = reader.FieldNumber;
				do
				{
					KeyValuePair<string, bool> obj4 = default(KeyValuePair<string, bool>);
					SubItemToken token3 = ProtoReader.StartSubItem(reader);
					obj4 = this.Deserialize1489031418(obj4, reader);
					ProtoReader.EndSubItem(token3, reader);
					dictionary3[obj4.Key] = obj4.Value;
				}
				while (reader.TryReadFieldHeader(fieldNumber3));
				break;
			}
			case 4:
			{
				Dictionary<string, int> dictionary4 = obj._ints ?? new Dictionary<string, int>();
				int fieldNumber4 = reader.FieldNumber;
				do
				{
					KeyValuePair<string, int> obj5 = default(KeyValuePair<string, int>);
					SubItemToken token4 = ProtoReader.StartSubItem(reader);
					obj5 = this.Deserialize224877162(obj5, reader);
					ProtoReader.EndSubItem(token4, reader);
					dictionary4[obj5.Key] = obj5.Value;
				}
				while (reader.TryReadFieldHeader(fieldNumber4));
				break;
			}
			default:
				reader.SkipField();
				break;
			}
			i = reader.ReadFieldHeader();
		}
		return obj;
	}

	private void Serialize1881457915(SceneObjectData obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		if (obj.uniqueName != null)
		{
			ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
			ProtoWriter.WriteString(obj.uniqueName, writer);
		}
		if (obj.serialData != null)
		{
			byte[] serialData = obj.serialData;
			ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
			ProtoWriter.WriteBytes(serialData, writer);
		}
		ProtoWriter.WriteFieldHeader(4, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.isObjectTree, writer);
	}

	private SceneObjectData Deserialize1881457915(SceneObjectData obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		if (obj == null)
		{
			obj = new SceneObjectData();
			ProtoReader.NoteObject(obj, reader);
		}
		while (i > 0)
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.uniqueName = reader.ReadString();
				break;
			case 3:
				obj.serialData = ProtoReader.AppendBytes(obj.serialData, reader);
				break;
			case 4:
				obj.isObjectTree = reader.ReadBoolean();
				break;
			default:
				reader.SkipField();
				break;
			}
			i = reader.ReadFieldHeader();
		}
		return obj;
	}

	private void Serialize2013353155(SceneObjectDataSet obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		if (obj.items != null)
		{
			foreach (KeyValuePair<string, SceneObjectData> obj2 in obj.items)
			{
				ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
				SubItemToken token = ProtoWriter.StartSubItem(null, writer);
				this.Serialize890247896(obj2, objTypeId, writer);
				ProtoWriter.EndSubItem(token, writer);
			}
		}
	}

	private SceneObjectDataSet Deserialize2013353155(SceneObjectDataSet obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		if (obj == null)
		{
			obj = new SceneObjectDataSet();
			ProtoReader.NoteObject(obj, reader);
		}
		while (i > 0)
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					Dictionary<string, SceneObjectData> dictionary = obj.items ?? new Dictionary<string, SceneObjectData>();
					int fieldNumber = reader.FieldNumber;
					do
					{
						KeyValuePair<string, SceneObjectData> obj2 = default(KeyValuePair<string, SceneObjectData>);
						SubItemToken token = ProtoReader.StartSubItem(reader);
						obj2 = this.Deserialize890247896(obj2, reader);
						ProtoReader.EndSubItem(token, reader);
						dictionary[obj2.Key] = obj2.Value;
					}
					while (reader.TryReadFieldHeader(fieldNumber));
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
			i = reader.ReadFieldHeader();
		}
		return obj;
	}

	private void Serialize1606650114(SeaDragon obj, int objTypeId, ProtoWriter writer)
	{
	}

	private SeaDragon Deserialize1606650114(SeaDragon obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1327055215(SeaEmperorBaby obj, int objTypeId, ProtoWriter writer)
	{
	}

	private SeaEmperorBaby Deserialize1327055215(SeaEmperorBaby obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1921909083(SeaEmperorJuvenile obj, int objTypeId, ProtoWriter writer)
	{
	}

	private SeaEmperorJuvenile Deserialize1921909083(SeaEmperorJuvenile obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1086395194(Sealed obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.openedAmount, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.maxOpenedAmount, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj._sealed, writer);
	}

	private Sealed Deserialize1086395194(Sealed obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.openedAmount = reader.ReadSingle();
				break;
			case 3:
				obj.maxOpenedAmount = reader.ReadSingle();
				break;
			case 4:
				obj._sealed = reader.ReadBoolean();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize615648120(SeaMonkey obj, int objTypeId, ProtoWriter writer)
	{
	}

	private SeaMonkey Deserialize615648120(SeaMonkey obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1640880(SeaMonkeyBaby obj, int objTypeId, ProtoWriter writer)
	{
	}

	private SeaMonkeyBaby Deserialize1640880(SeaMonkeyBaby obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1277798743(SeaMonkeySpawnRandomItem obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed64, writer);
		ProtoWriter.WriteDouble(obj.timeLastSpawn, writer);
	}

	private SeaMonkeySpawnRandomItem Deserialize1277798743(SeaMonkeySpawnRandomItem obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.timeLastSpawn = reader.ReadDouble();
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize2106147891(SeaMoth obj, int objTypeId, ProtoWriter writer)
	{
	}

	private SeaMoth Deserialize2106147891(SeaMoth obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1319564559(SeamothStorageContainer obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		if (obj.serializedStorage != null)
		{
			byte[] serializedStorage = obj.serializedStorage;
			ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
			ProtoWriter.WriteBytes(serializedStorage, writer);
		}
	}

	private SeamothStorageContainer Deserialize1319564559(SeamothStorageContainer obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.serializedStorage = ProtoReader.AppendBytes(obj.serializedStorage, reader);
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize574222852(SeaTreader obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.treader_version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.grazingTimeLeft, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.reverseDirection, writer);
	}

	private SeaTreader Deserialize574222852(SeaTreader obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.treader_version = reader.ReadInt32();
				break;
			case 2:
				obj.grazingTimeLeft = reader.ReadSingle();
				break;
			case 3:
				obj.reverseDirection = reader.ReadBoolean();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1716108768(SeaTruckConnection obj, int objTypeId, ProtoWriter writer)
	{
		if (obj.connectionUID != null)
		{
			ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
			ProtoWriter.WriteString(obj.connectionUID, writer);
		}
	}

	private SeaTruckConnection Deserialize1716108768(SeaTruckConnection obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				obj.connectionUID = reader.ReadString();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize1624342325(SeaTruckDockingBay obj, int objTypeId, ProtoWriter writer)
	{
		if (obj.dockedUID != null)
		{
			ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
			ProtoWriter.WriteString(obj.dockedUID, writer);
		}
	}

	private SeaTruckDockingBay Deserialize1624342325(SeaTruckDockingBay obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				obj.dockedUID = reader.ReadString();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize944362993(SeaTruckLights obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.lightsActive, writer);
	}

	private SeaTruckLights Deserialize944362993(SeaTruckLights obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				obj.lightsActive = reader.ReadBoolean();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize294226815(SeaTruckMotor obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj._piloting, writer);
	}

	private SeaTruckMotor Deserialize294226815(SeaTruckMotor obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				obj._piloting = reader.ReadBoolean();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize728043624(SeaTruckTeleporter obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.spawnedtool, writer);
	}

	private SeaTruckTeleporter Deserialize728043624(SeaTruckTeleporter obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				obj.spawnedtool = reader.ReadBoolean();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize514291595(SeaTruckUpgrades obj, int objTypeId, ProtoWriter writer)
	{
		if (obj.serializedModuleSlots != null)
		{
			foreach (KeyValuePair<string, string> obj2 in obj.serializedModuleSlots)
			{
				ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
				SubItemToken token = ProtoWriter.StartSubItem(null, writer);
				this.Serialize524780017(obj2, objTypeId, writer);
				ProtoWriter.EndSubItem(token, writer);
			}
		}
	}

	private SeaTruckUpgrades Deserialize514291595(SeaTruckUpgrades obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				int fieldNumber = reader.FieldNumber;
				do
				{
					KeyValuePair<string, string> obj2 = default(KeyValuePair<string, string>);
					SubItemToken token = ProtoReader.StartSubItem(reader);
					obj2 = this.Deserialize524780017(obj2, reader);
					ProtoReader.EndSubItem(token, reader);
					dictionary[obj2.Key] = obj2.Value;
				}
				while (reader.TryReadFieldHeader(fieldNumber));
				obj.serializedModuleSlots = dictionary;
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize1191484888(ShadowLeviathan obj, int objTypeId, ProtoWriter writer)
	{
	}

	private ShadowLeviathan Deserialize1191484888(ShadowLeviathan obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1535225367(Shocker obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Shocker Deserialize1535225367(Shocker obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1084867387(Sign obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		if (obj.text != null)
		{
			ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
			ProtoWriter.WriteString(obj.text, writer);
		}
		if (obj.elements != null)
		{
			foreach (bool value in obj.elements)
			{
				ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
				ProtoWriter.WriteBoolean(value, writer);
			}
		}
		ProtoWriter.WriteFieldHeader(4, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.scaleIndex, writer);
		ProtoWriter.WriteFieldHeader(5, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.colorIndex, writer);
		ProtoWriter.WriteFieldHeader(6, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.backgroundEnabled, writer);
	}

	private Sign Deserialize1084867387(Sign obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.text = reader.ReadString();
				break;
			case 3:
			{
				List<bool> list = new List<bool>();
				int fieldNumber = reader.FieldNumber;
				do
				{
					bool item = reader.ReadBoolean();
					list.Add(item);
				}
				while (reader.TryReadFieldHeader(fieldNumber));
				obj.elements = list.ToArray();
				break;
			}
			case 4:
				obj.scaleIndex = reader.ReadInt32();
				break;
			case 5:
				obj.colorIndex = reader.ReadInt32();
				break;
			case 6:
				obj.backgroundEnabled = reader.ReadBoolean();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1732754958(SignalPing obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.currentVersion, writer);
		if (obj.descriptionKey != null)
		{
			ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
			ProtoWriter.WriteString(obj.descriptionKey, writer);
		}
		ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1181346079(obj.pos, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
	}

	private SignalPing Deserialize1732754958(SignalPing obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.currentVersion = reader.ReadInt32();
				break;
			case 2:
				obj.descriptionKey = reader.ReadString();
				break;
			case 3:
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj.pos = this.Deserialize1181346079(obj.pos, reader);
				ProtoReader.EndSubItem(token, reader);
				break;
			}
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize469144263(Skyray obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Skyray Deserialize469144263(Skyray obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1355655442(Slime obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Slime Deserialize1355655442(Slime obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1008105993(SnowStalker obj, int objTypeId, ProtoWriter writer)
	{
	}

	private SnowStalker Deserialize1008105993(SnowStalker obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1630308817(SnowStalkerBaby obj, int objTypeId, ProtoWriter writer)
	{
	}

	private SnowStalkerBaby Deserialize1630308817(SnowStalkerBaby obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize524984727(SolarPanel obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.biomeSunlightScale, writer);
	}

	private SolarPanel Deserialize524984727(SolarPanel obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.biomeSunlightScale = reader.ReadSingle();
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize350666384(SoundQueue obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		if (obj.queue != null)
		{
			foreach (SoundQueue.Entry obj2 in obj.queue)
			{
				ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
				SubItemToken token = ProtoWriter.StartSubItem(null, writer);
				this.Serialize682374214(obj2, objTypeId, writer);
				ProtoWriter.EndSubItem(token, writer);
			}
		}
		if (obj._current != null)
		{
			ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
			SubItemToken token2 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize682374214(obj._current.GetValueOrDefault(), objTypeId, writer);
			ProtoWriter.EndSubItem(token2, writer);
		}
	}

	private SoundQueue Deserialize350666384(SoundQueue obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		if (obj == null)
		{
			obj = new SoundQueue();
			ProtoReader.NoteObject(obj, reader);
		}
		while (i > 0)
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
			{
				List<SoundQueue.Entry> list = obj.queue ?? new List<SoundQueue.Entry>();
				int fieldNumber = reader.FieldNumber;
				do
				{
					SoundQueue.Entry entry = default(SoundQueue.Entry);
					SubItemToken token = ProtoReader.StartSubItem(reader);
					entry = this.Deserialize682374214(entry, reader);
					ProtoReader.EndSubItem(token, reader);
					list.Add(entry);
				}
				while (reader.TryReadFieldHeader(fieldNumber));
				break;
			}
			case 3:
			{
				SubItemToken token2 = ProtoReader.StartSubItem(reader);
				obj._current = new SoundQueue.Entry?(this.Deserialize682374214(obj._current.GetValueOrDefault(), reader));
				ProtoReader.EndSubItem(token2, reader);
				break;
			}
			default:
				reader.SkipField();
				break;
			}
			i = reader.ReadFieldHeader();
		}
		return obj;
	}

	private void Serialize682374214(SoundQueue.Entry obj, int objTypeId, ProtoWriter writer)
	{
		if (obj.sound != null)
		{
			ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
			ProtoWriter.WriteString(obj.sound, writer);
		}
		if (obj.subtitles != null)
		{
			ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
			ProtoWriter.WriteString(obj.subtitles, writer);
		}
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.subtitleLine, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.Variant, writer);
		ProtoWriter.WriteInt32((int)obj.host, writer);
		ProtoWriter.WriteFieldHeader(5, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.position, writer);
	}

	private SoundQueue.Entry Deserialize682374214(SoundQueue.Entry obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.sound = reader.ReadString();
				break;
			case 2:
				obj.subtitles = reader.ReadString();
				break;
			case 3:
				obj.subtitleLine = reader.ReadInt32();
				break;
			case 4:
				obj.host = (SoundHost)reader.ReadInt32();
				break;
			case 5:
				obj.position = reader.ReadInt32();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize647827065(Spadefish obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Spadefish Deserialize647827065(Spadefish obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1993981848(SpawnStoredLoot obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.lootSpawned, writer);
	}

	private SpawnStoredLoot Deserialize1993981848(SpawnStoredLoot obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.lootSpawned = reader.ReadBoolean();
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize1058623975(SpineEel obj, int objTypeId, ProtoWriter writer)
	{
	}

	private SpineEel Deserialize1058623975(SpineEel obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1711042137(SpinnerFish obj, int objTypeId, ProtoWriter writer)
	{
	}

	private SpinnerFish Deserialize1711042137(SpinnerFish obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1305740789(SpyPenguinName obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		if (obj.savedName != null)
		{
			ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
			ProtoWriter.WriteString(obj.savedName, writer);
		}
	}

	private SpyPenguinName Deserialize1305740789(SpyPenguinName obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.savedName = reader.ReadString();
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize861708591(SquidShark obj, int objTypeId, ProtoWriter writer)
	{
	}

	private SquidShark Deserialize861708591(SquidShark obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1440414490(Stalker obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Stalker Deserialize1440414490(Stalker obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize737691900(StarshipDoor obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.doorOpen, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.doorLocked, writer);
	}

	private StarshipDoor Deserialize737691900(StarshipDoor obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.doorLocked = reader.ReadBoolean();
				}
			}
			else
			{
				obj.doorOpen = reader.ReadBoolean();
			}
		}
		return obj;
	}

	private void Serialize242125589(Stillsuit obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.waterCaptured, writer);
	}

	private Stillsuit Deserialize242125589(Stillsuit obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				obj.waterCaptured = reader.ReadSingle();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize366077262(StorageContainer obj, int objTypeId, ProtoWriter writer)
	{
		if (objTypeId == 787786344)
		{
			ProtoWriter.WriteFieldHeader(1000, WireType.String, writer);
			SubItemToken token = ProtoWriter.StartSubItem(null, writer);
			this.Serialize787786344(obj as SupplyDrop, objTypeId, writer);
			ProtoWriter.EndSubItem(token, writer);
		}
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
	}

	private StorageContainer Deserialize366077262(StorageContainer obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1000)
			{
				IL_58:
				while (i > 0)
				{
					if (i == 1)
					{
						obj.version = reader.ReadInt32();
					}
					else
					{
						reader.SkipField();
					}
					i = reader.ReadFieldHeader();
				}
				return obj;
			}
			SubItemToken token = ProtoReader.StartSubItem(reader);
			obj = this.Deserialize787786344(obj as SupplyDrop, reader);
			ProtoReader.EndSubItem(token, reader);
		}
		goto IL_58;
	}

	private void Serialize704466011(ScheduledGoal obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.timeExecute, writer);
		if (obj.goalKey != null)
		{
			ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
			ProtoWriter.WriteString(obj.goalKey, writer);
		}
		ProtoWriter.WriteFieldHeader(4, WireType.Variant, writer);
		ProtoWriter.WriteInt32((int)obj.goalType, writer);
		ProtoWriter.WriteFieldHeader(5, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.checkPlayerSafety, writer);
		ProtoWriter.WriteFieldHeader(6, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.playInCinematics, writer);
		ProtoWriter.WriteFieldHeader(7, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.checkInBase, writer);
	}

	private ScheduledGoal Deserialize704466011(ScheduledGoal obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		if (obj == null)
		{
			obj = new ScheduledGoal();
			ProtoReader.NoteObject(obj, reader);
		}
		while (i > 0)
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.timeExecute = reader.ReadSingle();
				break;
			case 3:
				obj.goalKey = reader.ReadString();
				break;
			case 4:
				obj.goalType = (Story.GoalType)reader.ReadInt32();
				break;
			case 5:
				obj.checkPlayerSafety = reader.ReadBoolean();
				break;
			case 6:
				obj.playInCinematics = reader.ReadBoolean();
				break;
			case 7:
				obj.checkInBase = reader.ReadBoolean();
				break;
			default:
				reader.SkipField();
				break;
			}
			i = reader.ReadFieldHeader();
		}
		return obj;
	}

	private void Serialize1982063882(StoryGoalManager obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		if (obj.completedGoals != null)
		{
			foreach (string text in obj.completedGoals)
			{
				if (text != null)
				{
					ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
					ProtoWriter.WriteString(text, writer);
				}
			}
		}
		if (obj.pendingRadioMessages != null)
		{
			foreach (string text2 in obj.pendingRadioMessages)
			{
				if (text2 != null)
				{
					ProtoWriter.WriteFieldHeader(4, WireType.String, writer);
					ProtoWriter.WriteString(text2, writer);
				}
			}
		}
		if (obj.canceledRadioMessages != null)
		{
			foreach (string text3 in obj.canceledRadioMessages)
			{
				if (text3 != null)
				{
					ProtoWriter.WriteFieldHeader(5, WireType.String, writer);
					ProtoWriter.WriteString(text3, writer);
				}
			}
		}
		if (obj.mutedStoryGoals != null)
		{
			foreach (string text4 in obj.mutedStoryGoals)
			{
				if (text4 != null)
				{
					ProtoWriter.WriteFieldHeader(6, WireType.String, writer);
					ProtoWriter.WriteString(text4, writer);
				}
			}
		}
		ProtoWriter.WriteFieldHeader(7, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.precursorScanCount, writer);
	}

	private StoryGoalManager Deserialize1982063882(StoryGoalManager obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		while (i > 0)
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
			{
				HashSet<string> hashSet = obj.completedGoals ?? new HashSet<string>();
				int fieldNumber = reader.FieldNumber;
				do
				{
					string item = reader.ReadString();
					hashSet.Add(item);
				}
				while (reader.TryReadFieldHeader(fieldNumber));
				break;
			}
			case 3:
				goto IL_13A;
			case 4:
			{
				List<string> list = obj.pendingRadioMessages ?? new List<string>();
				int fieldNumber2 = reader.FieldNumber;
				do
				{
					string item2 = reader.ReadString();
					list.Add(item2);
				}
				while (reader.TryReadFieldHeader(fieldNumber2));
				break;
			}
			case 5:
			{
				HashSet<string> hashSet2 = obj.canceledRadioMessages ?? new HashSet<string>();
				int fieldNumber3 = reader.FieldNumber;
				do
				{
					string item3 = reader.ReadString();
					hashSet2.Add(item3);
				}
				while (reader.TryReadFieldHeader(fieldNumber3));
				break;
			}
			case 6:
			{
				HashSet<string> hashSet3 = obj.mutedStoryGoals ?? new HashSet<string>();
				int fieldNumber4 = reader.FieldNumber;
				do
				{
					string item4 = reader.ReadString();
					hashSet3.Add(item4);
				}
				while (reader.TryReadFieldHeader(fieldNumber4));
				break;
			}
			case 7:
				obj.precursorScanCount = reader.ReadInt32();
				break;
			default:
				goto IL_13A;
			}
			IL_140:
			i = reader.ReadFieldHeader();
			continue;
			IL_13A:
			reader.SkipField();
			goto IL_140;
		}
		return obj;
	}

	private void Serialize1506278612(StoryGoalScheduler obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		if (obj.schedule != null)
		{
			foreach (ScheduledGoal scheduledGoal in obj.schedule)
			{
				if (scheduledGoal != null)
				{
					ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
					SubItemToken token = ProtoWriter.StartSubItem(scheduledGoal, writer);
					this.Serialize704466011(scheduledGoal, objTypeId, writer);
					ProtoWriter.EndSubItem(token, writer);
				}
			}
		}
	}

	private StoryGoalScheduler Deserialize1506278612(StoryGoalScheduler obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					List<ScheduledGoal> list = obj.schedule ?? new List<ScheduledGoal>();
					int fieldNumber = reader.FieldNumber;
					do
					{
						ScheduledGoal scheduledGoal = new ScheduledGoal();
						SubItemToken token = ProtoReader.StartSubItem(reader);
						scheduledGoal = this.Deserialize704466011(scheduledGoal, reader);
						ProtoReader.EndSubItem(token, reader);
						list.Add(scheduledGoal);
					}
					while (reader.TryReadFieldHeader(fieldNumber));
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize502247445(StoryGoalCustomEventHandler obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.countdownActive, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.countdownStartingTime, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.gunDisabled, writer);
	}

	private StoryGoalCustomEventHandler Deserialize502247445(StoryGoalCustomEventHandler obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.countdownActive = reader.ReadBoolean();
				break;
			case 2:
				obj.countdownStartingTime = reader.ReadSingle();
				break;
			case 3:
				obj.gunDisabled = reader.ReadBoolean();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1537030892(SubFire obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.fireCount, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.curSmokeVal, writer);
	}

	private SubFire Deserialize1537030892(SubFire obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.fireCount = reader.ReadInt32();
				break;
			case 3:
				obj.curSmokeVal = reader.ReadSingle();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1180542256(SubRoot obj, int objTypeId, ProtoWriter writer)
	{
		if (objTypeId == 311542795)
		{
			ProtoWriter.WriteFieldHeader(100, WireType.String, writer);
			SubItemToken token = ProtoWriter.StartSubItem(null, writer);
			this.Serialize311542795(obj as BaseRoot, objTypeId, writer);
			ProtoWriter.EndSubItem(token, writer);
		}
		ProtoWriter.WriteFieldHeader(1, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.floodFraction, writer);
		if (obj.subName != null)
		{
			ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
			ProtoWriter.WriteString(obj.subName, writer);
		}
		ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
		SubItemToken token2 = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1181346079(obj.subColor, objTypeId, writer);
		ProtoWriter.EndSubItem(token2, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		if (obj.subColors != null)
		{
			foreach (Vector3 obj2 in obj.subColors)
			{
				ProtoWriter.WriteFieldHeader(5, WireType.String, writer);
				SubItemToken token3 = ProtoWriter.StartSubItem(null, writer);
				this.Serialize1181346079(obj2, objTypeId, writer);
				ProtoWriter.EndSubItem(token3, writer);
			}
		}
	}

	private SubRoot Deserialize1180542256(SubRoot obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 100)
			{
				IL_100:
				while (i > 0)
				{
					switch (i)
					{
					case 1:
						obj.floodFraction = reader.ReadSingle();
						break;
					case 2:
						obj.subName = reader.ReadString();
						break;
					case 3:
					{
						SubItemToken token = ProtoReader.StartSubItem(reader);
						obj.subColor = this.Deserialize1181346079(obj.subColor, reader);
						ProtoReader.EndSubItem(token, reader);
						break;
					}
					case 4:
						obj.version = reader.ReadInt32();
						break;
					case 5:
					{
						List<Vector3> list = new List<Vector3>();
						int fieldNumber = reader.FieldNumber;
						do
						{
							Vector3 vector = default(Vector3);
							SubItemToken token2 = ProtoReader.StartSubItem(reader);
							vector = this.Deserialize1181346079(vector, reader);
							ProtoReader.EndSubItem(token2, reader);
							list.Add(vector);
						}
						while (reader.TryReadFieldHeader(fieldNumber));
						obj.subColors = list.ToArray();
						break;
					}
					default:
						reader.SkipField();
						break;
					}
					i = reader.ReadFieldHeader();
				}
				return obj;
			}
			SubItemToken token3 = ProtoReader.StartSubItem(reader);
			obj = this.Deserialize311542795(obj as BaseRoot, reader);
			ProtoReader.EndSubItem(token3, reader);
		}
		goto IL_100;
	}

	private void Serialize1603999327(SunlightSettings obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.enabled, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.fade, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1404661584(obj.color, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.replaceFraction, writer);
		ProtoWriter.WriteFieldHeader(5, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.shadowed, writer);
	}

	private SunlightSettings Deserialize1603999327(SunlightSettings obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		if (obj == null)
		{
			obj = new SunlightSettings();
			ProtoReader.NoteObject(obj, reader);
		}
		while (i > 0)
		{
			switch (i)
			{
			case 1:
				obj.enabled = reader.ReadBoolean();
				break;
			case 2:
				obj.fade = reader.ReadSingle();
				break;
			case 3:
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj.color = this.Deserialize1404661584(obj.color, reader);
				ProtoReader.EndSubItem(token, reader);
				break;
			}
			case 4:
				obj.replaceFraction = reader.ReadSingle();
				break;
			case 5:
				obj.shadowed = reader.ReadBoolean();
				break;
			default:
				reader.SkipField();
				break;
			}
			i = reader.ReadFieldHeader();
		}
		return obj;
	}

	private void Serialize1555952712(SupplyCrate obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.open, writer);
	}

	private SupplyCrate Deserialize1555952712(SupplyCrate obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				obj.open = reader.ReadBoolean();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize787786344(SupplyDrop obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.dropComplete, writer);
		if (obj.dropStoryGoal != null)
		{
			ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
			ProtoWriter.WriteString(obj.dropStoryGoal, writer);
		}
		ProtoWriter.WriteFieldHeader(4, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.createOpened, writer);
		ProtoWriter.WriteFieldHeader(5, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.hasTechUnlock, writer);
		ProtoWriter.WriteFieldHeader(6, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.hasPDAEntry, writer);
	}

	private SupplyDrop Deserialize787786344(SupplyDrop obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.dropComplete = reader.ReadBoolean();
				break;
			case 3:
				obj.dropStoryGoal = reader.ReadString();
				break;
			case 4:
				obj.createOpened = reader.ReadBoolean();
				break;
			case 5:
				obj.hasTechUnlock = reader.ReadBoolean();
				break;
			case 6:
				obj.hasPDAEntry = reader.ReadBoolean();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize888605288(Survival obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.food, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.water, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.stomach, writer);
	}

	private Survival Deserialize888605288(Survival obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.food = reader.ReadSingle();
				break;
			case 3:
				obj.water = reader.ReadSingle();
				break;
			case 4:
				obj.stomach = reader.ReadSingle();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize225324449(SwimRandom obj, int objTypeId, ProtoWriter writer)
	{
	}

	private SwimRandom Deserialize225324449(SwimRandom obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1157251956(SwimToMeat obj, int objTypeId, ProtoWriter writer)
	{
	}

	private SwimToMeat Deserialize1157251956(SwimToMeat obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize3219972(SymbioteFish obj, int objTypeId, ProtoWriter writer)
	{
	}

	private SymbioteFish Deserialize3219972(SymbioteFish obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1852174394(KeyValuePair<NotificationManager.NotificationId, NotificationManager.NotificationData> obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1731663660(obj.Key, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
		if (obj.Value != null)
		{
			ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
			SubItemToken token2 = ProtoWriter.StartSubItem(obj.Value, writer);
			this.Serialize1874975849(obj.Value, objTypeId, writer);
			ProtoWriter.EndSubItem(token2, writer);
		}
	}

	private KeyValuePair<NotificationManager.NotificationId, NotificationManager.NotificationData> Deserialize1852174394(KeyValuePair<NotificationManager.NotificationId, NotificationManager.NotificationData> obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		NotificationManager.NotificationId notificationId = obj.Key;
		NotificationManager.NotificationData notificationData = obj.Value;
		while (i > 0)
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					SubItemToken token = ProtoReader.StartSubItem(reader);
					notificationData = this.Deserialize1874975849(notificationData, reader);
					ProtoReader.EndSubItem(token, reader);
				}
			}
			else
			{
				SubItemToken token2 = ProtoReader.StartSubItem(reader);
				notificationId = this.Deserialize1731663660(notificationId, reader);
				ProtoReader.EndSubItem(token2, reader);
			}
			i = reader.ReadFieldHeader();
		}
		obj = new KeyValuePair<NotificationManager.NotificationId, NotificationManager.NotificationData>(notificationId, notificationData);
		return obj;
	}

	private void Serialize1116754719(KeyValuePair<int, SceneObjectData> obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.Key, writer);
		if (obj.Value != null)
		{
			ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
			SubItemToken token = ProtoWriter.StartSubItem(obj.Value, writer);
			this.Serialize1881457915(obj.Value, objTypeId, writer);
			ProtoWriter.EndSubItem(token, writer);
		}
	}

	private KeyValuePair<int, SceneObjectData> Deserialize1116754719(KeyValuePair<int, SceneObjectData> obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		int key = obj.Key;
		SceneObjectData sceneObjectData = obj.Value;
		while (i > 0)
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					SubItemToken token = ProtoReader.StartSubItem(reader);
					sceneObjectData = this.Deserialize1881457915(sceneObjectData, reader);
					ProtoReader.EndSubItem(token, reader);
				}
			}
			else
			{
				key = reader.ReadInt32();
			}
			i = reader.ReadFieldHeader();
		}
		obj = new KeyValuePair<int, SceneObjectData>(key, sceneObjectData);
		return obj;
	}

	private void Serialize121008834(KeyValuePair<string, PDAEncyclopedia.Entry> obj, int objTypeId, ProtoWriter writer)
	{
		if (obj.Key != null)
		{
			ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
			ProtoWriter.WriteString(obj.Key, writer);
		}
		if (obj.Value != null)
		{
			ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
			SubItemToken token = ProtoWriter.StartSubItem(obj.Value, writer);
			this.Serialize1244614203(obj.Value, objTypeId, writer);
			ProtoWriter.EndSubItem(token, writer);
		}
	}

	private KeyValuePair<string, PDAEncyclopedia.Entry> Deserialize121008834(KeyValuePair<string, PDAEncyclopedia.Entry> obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		string key = obj.Key;
		PDAEncyclopedia.Entry entry = obj.Value;
		while (i > 0)
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					SubItemToken token = ProtoReader.StartSubItem(reader);
					entry = this.Deserialize1244614203(entry, reader);
					ProtoReader.EndSubItem(token, reader);
				}
			}
			else
			{
				key = reader.ReadString();
			}
			i = reader.ReadFieldHeader();
		}
		obj = new KeyValuePair<string, PDAEncyclopedia.Entry>(key, entry);
		return obj;
	}

	private void Serialize1062675616(KeyValuePair<string, PDALog.Entry> obj, int objTypeId, ProtoWriter writer)
	{
		if (obj.Key != null)
		{
			ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
			ProtoWriter.WriteString(obj.Key, writer);
		}
		if (obj.Value != null)
		{
			ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
			SubItemToken token = ProtoWriter.StartSubItem(obj.Value, writer);
			this.Serialize1329426611(obj.Value, objTypeId, writer);
			ProtoWriter.EndSubItem(token, writer);
		}
	}

	private KeyValuePair<string, PDALog.Entry> Deserialize1062675616(KeyValuePair<string, PDALog.Entry> obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		string key = obj.Key;
		PDALog.Entry entry = obj.Value;
		while (i > 0)
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					SubItemToken token = ProtoReader.StartSubItem(reader);
					entry = this.Deserialize1329426611(entry, reader);
					ProtoReader.EndSubItem(token, reader);
				}
			}
			else
			{
				key = reader.ReadString();
			}
			i = reader.ReadFieldHeader();
		}
		obj = new KeyValuePair<string, PDALog.Entry>(key, entry);
		return obj;
	}

	private void Serialize890247896(KeyValuePair<string, SceneObjectData> obj, int objTypeId, ProtoWriter writer)
	{
		if (obj.Key != null)
		{
			ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
			ProtoWriter.WriteString(obj.Key, writer);
		}
		if (obj.Value != null)
		{
			ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
			SubItemToken token = ProtoWriter.StartSubItem(obj.Value, writer);
			this.Serialize1881457915(obj.Value, objTypeId, writer);
			ProtoWriter.EndSubItem(token, writer);
		}
	}

	private KeyValuePair<string, SceneObjectData> Deserialize890247896(KeyValuePair<string, SceneObjectData> obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		string key = obj.Key;
		SceneObjectData sceneObjectData = obj.Value;
		while (i > 0)
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					SubItemToken token = ProtoReader.StartSubItem(reader);
					sceneObjectData = this.Deserialize1881457915(sceneObjectData, reader);
					ProtoReader.EndSubItem(token, reader);
				}
			}
			else
			{
				key = reader.ReadString();
			}
			i = reader.ReadFieldHeader();
		}
		obj = new KeyValuePair<string, SceneObjectData>(key, sceneObjectData);
		return obj;
	}

	private void Serialize1489031418(KeyValuePair<string, bool> obj, int objTypeId, ProtoWriter writer)
	{
		if (obj.Key != null)
		{
			ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
			ProtoWriter.WriteString(obj.Key, writer);
		}
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.Value, writer);
	}

	private KeyValuePair<string, bool> Deserialize1489031418(KeyValuePair<string, bool> obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		string key = obj.Key;
		bool value = obj.Value;
		while (i > 0)
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					value = reader.ReadBoolean();
				}
			}
			else
			{
				key = reader.ReadString();
			}
			i = reader.ReadFieldHeader();
		}
		obj = new KeyValuePair<string, bool>(key, value);
		return obj;
	}

	private void Serialize224877162(KeyValuePair<string, int> obj, int objTypeId, ProtoWriter writer)
	{
		if (obj.Key != null)
		{
			ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
			ProtoWriter.WriteString(obj.Key, writer);
		}
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.Value, writer);
	}

	private KeyValuePair<string, int> Deserialize224877162(KeyValuePair<string, int> obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		string key = obj.Key;
		int value = obj.Value;
		while (i > 0)
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					value = reader.ReadInt32();
				}
			}
			else
			{
				key = reader.ReadString();
			}
			i = reader.ReadFieldHeader();
		}
		obj = new KeyValuePair<string, int>(key, value);
		return obj;
	}

	private void Serialize714689774(KeyValuePair<string, float> obj, int objTypeId, ProtoWriter writer)
	{
		if (obj.Key != null)
		{
			ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
			ProtoWriter.WriteString(obj.Key, writer);
		}
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.Value, writer);
	}

	private KeyValuePair<string, float> Deserialize714689774(KeyValuePair<string, float> obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		string key = obj.Key;
		float value = obj.Value;
		while (i > 0)
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					value = reader.ReadSingle();
				}
			}
			else
			{
				key = reader.ReadString();
			}
			i = reader.ReadFieldHeader();
		}
		obj = new KeyValuePair<string, float>(key, value);
		return obj;
	}

	private void Serialize524780017(KeyValuePair<string, string> obj, int objTypeId, ProtoWriter writer)
	{
		if (obj.Key != null)
		{
			ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
			ProtoWriter.WriteString(obj.Key, writer);
		}
		if (obj.Value != null)
		{
			ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
			ProtoWriter.WriteString(obj.Value, writer);
		}
	}

	private KeyValuePair<string, string> Deserialize524780017(KeyValuePair<string, string> obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		string key = obj.Key;
		string value = obj.Value;
		while (i > 0)
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					value = reader.ReadString();
				}
			}
			else
			{
				key = reader.ReadString();
			}
			i = reader.ReadFieldHeader();
		}
		obj = new KeyValuePair<string, string>(key, value);
		return obj;
	}

	private void Serialize1249808124(KeyValuePair<string, TimeCapsuleContent> obj, int objTypeId, ProtoWriter writer)
	{
		if (obj.Key != null)
		{
			ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
			ProtoWriter.WriteString(obj.Key, writer);
		}
		if (obj.Value != null)
		{
			ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
			SubItemToken token = ProtoWriter.StartSubItem(obj.Value, writer);
			this.Serialize1111417537(obj.Value, objTypeId, writer);
			ProtoWriter.EndSubItem(token, writer);
		}
	}

	private KeyValuePair<string, TimeCapsuleContent> Deserialize1249808124(KeyValuePair<string, TimeCapsuleContent> obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		string key = obj.Key;
		TimeCapsuleContent timeCapsuleContent = obj.Value;
		while (i > 0)
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					SubItemToken token = ProtoReader.StartSubItem(reader);
					timeCapsuleContent = this.Deserialize1111417537(timeCapsuleContent, reader);
					ProtoReader.EndSubItem(token, reader);
				}
			}
			else
			{
				key = reader.ReadString();
			}
			i = reader.ReadFieldHeader();
		}
		obj = new KeyValuePair<string, TimeCapsuleContent>(key, timeCapsuleContent);
		return obj;
	}

	private void Serialize1158933531(KeyValuePair<TechType, CraftingAnalytics.EntryData> obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32((int)obj.Key, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1103056798(obj.Value, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
	}

	private KeyValuePair<TechType, CraftingAnalytics.EntryData> Deserialize1158933531(KeyValuePair<TechType, CraftingAnalytics.EntryData> obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		TechType key = obj.Key;
		CraftingAnalytics.EntryData entryData = obj.Value;
		while (i > 0)
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					SubItemToken token = ProtoReader.StartSubItem(reader);
					entryData = this.Deserialize1103056798(entryData, reader);
					ProtoReader.EndSubItem(token, reader);
				}
			}
			else
			{
				key = (TechType)reader.ReadInt32();
			}
			i = reader.ReadFieldHeader();
		}
		obj = new KeyValuePair<TechType, CraftingAnalytics.EntryData>(key, entryData);
		return obj;
	}

	private void Serialize212928398(TechFragment obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.techTypeChosen, writer);
	}

	private TechFragment Deserialize212928398(TechFragment obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				obj.techTypeChosen = reader.ReadBoolean();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize1671198874(TechLight obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.placedByPlayer, writer);
	}

	private TechLight Deserialize1671198874(TechLight obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.placedByPlayer = reader.ReadBoolean();
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize2104816441(TeleporterManager obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		if (obj.activeTeleporters != null)
		{
			foreach (string text in obj.activeTeleporters)
			{
				if (text != null)
				{
					ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
					ProtoWriter.WriteString(text, writer);
				}
			}
		}
	}

	private TeleporterManager Deserialize2104816441(TeleporterManager obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					HashSet<string> hashSet = obj.activeTeleporters ?? new HashSet<string>();
					int fieldNumber = reader.FieldNumber;
					do
					{
						string item = reader.ReadString();
						hashSet.Add(item);
					}
					while (reader.TryReadFieldHeader(fieldNumber));
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize645269343(Terraformer obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.ammo, writer);
	}

	private Terraformer Deserialize645269343(Terraformer obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				obj.ammo = reader.ReadInt32();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize1983352738(ThermalPlant obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.temperature, writer);
	}

	private ThermalPlant Deserialize1983352738(ThermalPlant obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.temperature = reader.ReadSingle();
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize2092842303(Thumper obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.deployed, writer);
	}

	private Thumper Deserialize2092842303(Thumper obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.deployed = reader.ReadBoolean();
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize746584541(TileInstance obj, int objTypeId, ProtoWriter writer)
	{
		if (obj.resourcePath != null)
		{
			ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
			ProtoWriter.WriteString(obj.resourcePath, writer);
		}
		ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1691070576(obj.origin, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
		SubItemToken token2 = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1691070576(obj.gridOffset, objTypeId, writer);
		ProtoWriter.EndSubItem(token2, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.gridSize, writer);
		ProtoWriter.WriteFieldHeader(5, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.turns, writer);
		ProtoWriter.WriteFieldHeader(6, WireType.Variant, writer);
		ProtoWriter.WriteInt32((int)obj.blendMode, writer);
		ProtoWriter.WriteFieldHeader(7, WireType.Variant, writer);
		ProtoWriter.WriteByte(obj.multiplyPassiveType, writer);
		ProtoWriter.WriteFieldHeader(8, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.layer, writer);
		ProtoWriter.WriteFieldHeader(9, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.clearHeightmap, writer);
	}

	private TileInstance Deserialize746584541(TileInstance obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.resourcePath = reader.ReadString();
				break;
			case 2:
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj.origin = this.Deserialize1691070576(obj.origin, reader);
				ProtoReader.EndSubItem(token, reader);
				break;
			}
			case 3:
			{
				SubItemToken token2 = ProtoReader.StartSubItem(reader);
				obj.gridOffset = this.Deserialize1691070576(obj.gridOffset, reader);
				ProtoReader.EndSubItem(token2, reader);
				break;
			}
			case 4:
				obj.gridSize = reader.ReadInt32();
				break;
			case 5:
				obj.turns = reader.ReadInt32();
				break;
			case 6:
				obj.blendMode = (VoxelBlendMode)reader.ReadInt32();
				break;
			case 7:
				obj.multiplyPassiveType = reader.ReadByte();
				break;
			case 8:
				obj.layer = reader.ReadInt32();
				break;
			case 9:
				obj.clearHeightmap = reader.ReadBoolean();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1386031502(TimeCapsule obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.protoVersion, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.spawned, writer);
		if (obj.instanceId != null)
		{
			ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
			ProtoWriter.WriteString(obj.instanceId, writer);
		}
		if (obj.id != null)
		{
			ProtoWriter.WriteFieldHeader(4, WireType.String, writer);
			ProtoWriter.WriteString(obj.id, writer);
		}
	}

	private TimeCapsule Deserialize1386031502(TimeCapsule obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.protoVersion = reader.ReadInt32();
				break;
			case 2:
				obj.spawned = reader.ReadBoolean();
				break;
			case 3:
				obj.instanceId = reader.ReadString();
				break;
			case 4:
				obj.id = reader.ReadString();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1111417537(TimeCapsuleContent obj, int objTypeId, ProtoWriter writer)
	{
		if (obj.title != null)
		{
			ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
			ProtoWriter.WriteString(obj.title, writer);
		}
		if (obj.text != null)
		{
			ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
			ProtoWriter.WriteString(obj.text, writer);
		}
		if (obj.imageUrl != null)
		{
			ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
			ProtoWriter.WriteString(obj.imageUrl, writer);
		}
		if (obj.items != null)
		{
			foreach (TimeCapsuleItem timeCapsuleItem in obj.items)
			{
				if (timeCapsuleItem != null)
				{
					ProtoWriter.WriteFieldHeader(4, WireType.String, writer);
					SubItemToken token = ProtoWriter.StartSubItem(timeCapsuleItem, writer);
					this.Serialize2044575597(timeCapsuleItem, objTypeId, writer);
					ProtoWriter.EndSubItem(token, writer);
				}
			}
		}
		if (obj.updatedAt != null)
		{
			ProtoWriter.WriteFieldHeader(5, WireType.String, writer);
			ProtoWriter.WriteString(obj.updatedAt, writer);
		}
		ProtoWriter.WriteFieldHeader(6, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.isActive, writer);
		ProtoWriter.WriteFieldHeader(7, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.copiesFound, writer);
	}

	private TimeCapsuleContent Deserialize1111417537(TimeCapsuleContent obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		if (obj == null)
		{
			obj = new TimeCapsuleContent();
			ProtoReader.NoteObject(obj, reader);
		}
		while (i > 0)
		{
			switch (i)
			{
			case 1:
				obj.title = reader.ReadString();
				break;
			case 2:
				obj.text = reader.ReadString();
				break;
			case 3:
				obj.imageUrl = reader.ReadString();
				break;
			case 4:
			{
				List<TimeCapsuleItem> list = new List<TimeCapsuleItem>();
				int fieldNumber = reader.FieldNumber;
				do
				{
					TimeCapsuleItem timeCapsuleItem = new TimeCapsuleItem();
					SubItemToken token = ProtoReader.StartSubItem(reader);
					timeCapsuleItem = this.Deserialize2044575597(timeCapsuleItem, reader);
					ProtoReader.EndSubItem(token, reader);
					list.Add(timeCapsuleItem);
				}
				while (reader.TryReadFieldHeader(fieldNumber));
				obj.items = list;
				break;
			}
			case 5:
				obj.updatedAt = reader.ReadString();
				break;
			case 6:
				obj.isActive = reader.ReadBoolean();
				break;
			case 7:
				obj.copiesFound = reader.ReadInt32();
				break;
			default:
				reader.SkipField();
				break;
			}
			i = reader.ReadFieldHeader();
		}
		return obj;
	}

	private void Serialize2044575597(TimeCapsuleItem obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32((int)obj.techType, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.hasBattery, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteInt32((int)obj.batteryType, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.batteryCharge, writer);
	}

	private TimeCapsuleItem Deserialize2044575597(TimeCapsuleItem obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		if (obj == null)
		{
			obj = new TimeCapsuleItem();
			ProtoReader.NoteObject(obj, reader);
		}
		while (i > 0)
		{
			switch (i)
			{
			case 1:
				obj.techType = (TechType)reader.ReadInt32();
				break;
			case 2:
				obj.hasBattery = reader.ReadBoolean();
				break;
			case 3:
				obj.batteryType = (TechType)reader.ReadInt32();
				break;
			case 4:
				obj.batteryCharge = reader.ReadSingle();
				break;
			default:
				reader.SkipField();
				break;
			}
			i = reader.ReadFieldHeader();
		}
		return obj;
	}

	private void Serialize1888807148(TitanHolefish obj, int objTypeId, ProtoWriter writer)
	{
	}

	private TitanHolefish Deserialize1888807148(TitanHolefish obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1877364825(ToggleLights obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.lightsActive, writer);
	}

	private ToggleLights Deserialize1877364825(ToggleLights obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				obj.lightsActive = reader.ReadBoolean();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize1386215039(Triops obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Triops Deserialize1386215039(Triops obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize1151491255(Trivalve obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj._followingPlayer, writer);
	}

	private Trivalve Deserialize1151491255(Trivalve obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj._followingPlayer = reader.ReadBoolean();
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize118512508(AnimationCurve obj, int objTypeId, ProtoWriter writer)
	{
		if (obj.keys != null)
		{
			foreach (Keyframe obj2 in obj.keys)
			{
				ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
				SubItemToken token = ProtoWriter.StartSubItem(null, writer);
				this.Serialize1975582319(obj2, objTypeId, writer);
				ProtoWriter.EndSubItem(token, writer);
			}
		}
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteInt32((int)obj.postWrapMode, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteInt32((int)obj.preWrapMode, writer);
	}

	private AnimationCurve Deserialize118512508(AnimationCurve obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		if (obj == null)
		{
			obj = new AnimationCurve();
			ProtoReader.NoteObject(obj, reader);
		}
		while (i > 0)
		{
			switch (i)
			{
			case 1:
			{
				List<Keyframe> list = new List<Keyframe>();
				int fieldNumber = reader.FieldNumber;
				do
				{
					Keyframe keyframe = default(Keyframe);
					SubItemToken token = ProtoReader.StartSubItem(reader);
					keyframe = this.Deserialize1975582319(keyframe, reader);
					ProtoReader.EndSubItem(token, reader);
					list.Add(keyframe);
				}
				while (reader.TryReadFieldHeader(fieldNumber));
				obj.keys = list.ToArray();
				break;
			}
			case 2:
				obj.postWrapMode = (WrapMode)reader.ReadInt32();
				break;
			case 3:
				obj.preWrapMode = (WrapMode)reader.ReadInt32();
				break;
			default:
				reader.SkipField();
				break;
			}
			i = reader.ReadFieldHeader();
		}
		return obj;
	}

	private void Serialize1825589276(Behaviour obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.enabled, writer);
	}

	private Behaviour Deserialize1825589276(Behaviour obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				obj.enabled = reader.ReadBoolean();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize391689956(Bounds obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1181346079(obj.center, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
		SubItemToken token2 = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1181346079(obj.extents, objTypeId, writer);
		ProtoWriter.EndSubItem(token2, writer);
	}

	private Bounds Deserialize391689956(Bounds obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					SubItemToken token = ProtoReader.StartSubItem(reader);
					obj.extents = this.Deserialize1181346079(obj.extents, reader);
					ProtoReader.EndSubItem(token, reader);
				}
			}
			else
			{
				SubItemToken token2 = ProtoReader.StartSubItem(reader);
				obj.center = this.Deserialize1181346079(obj.center, reader);
				ProtoReader.EndSubItem(token2, reader);
			}
		}
		return obj;
	}

	private void Serialize892833698(BoxCollider obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.enabled, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.isTrigger, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1181346079(obj.center, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.String, writer);
		SubItemToken token2 = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1181346079(obj.size, objTypeId, writer);
		ProtoWriter.EndSubItem(token2, writer);
	}

	private BoxCollider Deserialize892833698(BoxCollider obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.enabled = reader.ReadBoolean();
				break;
			case 2:
				obj.isTrigger = reader.ReadBoolean();
				break;
			case 3:
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj.center = this.Deserialize1181346079(obj.center, reader);
				ProtoReader.EndSubItem(token, reader);
				break;
			}
			case 4:
			{
				SubItemToken token2 = ProtoReader.StartSubItem(reader);
				obj.size = this.Deserialize1181346079(obj.size, reader);
				ProtoReader.EndSubItem(token2, reader);
				break;
			}
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1590521044(CapsuleCollider obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.enabled, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.isTrigger, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1181346079(obj.center, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.radius, writer);
		ProtoWriter.WriteFieldHeader(5, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.height, writer);
	}

	private CapsuleCollider Deserialize1590521044(CapsuleCollider obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.enabled = reader.ReadBoolean();
				break;
			case 2:
				obj.isTrigger = reader.ReadBoolean();
				break;
			case 3:
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj.center = this.Deserialize1181346079(obj.center, reader);
				ProtoReader.EndSubItem(token, reader);
				break;
			}
			case 4:
				obj.radius = reader.ReadSingle();
				break;
			case 5:
				obj.height = reader.ReadSingle();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize72619689(Collider obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.enabled, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.isTrigger, writer);
	}

	private Collider Deserialize72619689(Collider obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.isTrigger = reader.ReadBoolean();
				}
			}
			else
			{
				obj.enabled = reader.ReadBoolean();
			}
		}
		return obj;
	}

	private void Serialize1404661584(Color obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.r, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.g, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.b, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.a, writer);
	}

	private Color Deserialize1404661584(Color obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.r = reader.ReadSingle();
				break;
			case 2:
				obj.g = reader.ReadSingle();
				break;
			case 3:
				obj.b = reader.ReadSingle();
				break;
			case 4:
				obj.a = reader.ReadSingle();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize394322812(Component obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Component Deserialize394322812(Component obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize175529349(Gradient obj, int objTypeId, ProtoWriter writer)
	{
		if (obj.colorKeys != null)
		{
			foreach (GradientColorKey obj2 in obj.colorKeys)
			{
				ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
				SubItemToken token = ProtoWriter.StartSubItem(null, writer);
				this.Serialize1747546845(obj2, objTypeId, writer);
				ProtoWriter.EndSubItem(token, writer);
			}
		}
		if (obj.alphaKeys != null)
		{
			foreach (GradientAlphaKey obj3 in obj.alphaKeys)
			{
				ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
				SubItemToken token2 = ProtoWriter.StartSubItem(null, writer);
				this.Serialize1518696882(obj3, objTypeId, writer);
				ProtoWriter.EndSubItem(token2, writer);
			}
		}
	}

	private Gradient Deserialize175529349(Gradient obj, ProtoReader reader)
	{
		int i = reader.ReadFieldHeader();
		if (obj == null)
		{
			obj = new Gradient();
			ProtoReader.NoteObject(obj, reader);
		}
		while (i > 0)
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					List<GradientAlphaKey> list = new List<GradientAlphaKey>();
					int fieldNumber = reader.FieldNumber;
					do
					{
						GradientAlphaKey gradientAlphaKey = default(GradientAlphaKey);
						SubItemToken token = ProtoReader.StartSubItem(reader);
						gradientAlphaKey = this.Deserialize1518696882(gradientAlphaKey, reader);
						ProtoReader.EndSubItem(token, reader);
						list.Add(gradientAlphaKey);
					}
					while (reader.TryReadFieldHeader(fieldNumber));
					obj.alphaKeys = list.ToArray();
				}
			}
			else
			{
				List<GradientColorKey> list2 = new List<GradientColorKey>();
				int fieldNumber2 = reader.FieldNumber;
				do
				{
					GradientColorKey gradientColorKey = default(GradientColorKey);
					SubItemToken token2 = ProtoReader.StartSubItem(reader);
					gradientColorKey = this.Deserialize1747546845(gradientColorKey, reader);
					ProtoReader.EndSubItem(token2, reader);
					list2.Add(gradientColorKey);
				}
				while (reader.TryReadFieldHeader(fieldNumber2));
				obj.colorKeys = list2.ToArray();
			}
			i = reader.ReadFieldHeader();
		}
		return obj;
	}

	private void Serialize1518696882(GradientAlphaKey obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.time, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.alpha, writer);
	}

	private GradientAlphaKey Deserialize1518696882(GradientAlphaKey obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.alpha = reader.ReadSingle();
				}
			}
			else
			{
				obj.time = reader.ReadSingle();
			}
		}
		return obj;
	}

	private void Serialize1747546845(GradientColorKey obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.time, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1404661584(obj.color, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
	}

	private GradientColorKey Deserialize1747546845(GradientColorKey obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					SubItemToken token = ProtoReader.StartSubItem(reader);
					obj.color = this.Deserialize1404661584(obj.color, reader);
					ProtoReader.EndSubItem(token, reader);
				}
			}
			else
			{
				obj.time = reader.ReadSingle();
			}
		}
		return obj;
	}

	private void Serialize1975582319(Keyframe obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.inTangent, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.outTangent, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.tangentMode, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.time, writer);
		ProtoWriter.WriteFieldHeader(5, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.value, writer);
	}

	private Keyframe Deserialize1975582319(Keyframe obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.inTangent = reader.ReadSingle();
				break;
			case 2:
				obj.outTangent = reader.ReadSingle();
				break;
			case 3:
				obj.tangentMode = reader.ReadInt32();
				break;
			case 4:
				obj.time = reader.ReadSingle();
				break;
			case 5:
				obj.value = reader.ReadSingle();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1364639273(Light obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32((int)obj.type, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.range, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.spotAngle, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1404661584(obj.color, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
		ProtoWriter.WriteFieldHeader(5, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.intensity, writer);
		ProtoWriter.WriteFieldHeader(6, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.cookieSize, writer);
		ProtoWriter.WriteFieldHeader(7, WireType.Variant, writer);
		ProtoWriter.WriteInt32((int)obj.shadows, writer);
		ProtoWriter.WriteFieldHeader(8, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.shadowStrength, writer);
		ProtoWriter.WriteFieldHeader(9, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.shadowBias, writer);
	}

	private Light Deserialize1364639273(Light obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.type = (LightType)reader.ReadInt32();
				break;
			case 2:
				obj.range = reader.ReadSingle();
				break;
			case 3:
				obj.spotAngle = reader.ReadSingle();
				break;
			case 4:
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj.color = this.Deserialize1404661584(obj.color, reader);
				ProtoReader.EndSubItem(token, reader);
				break;
			}
			case 5:
				obj.intensity = reader.ReadSingle();
				break;
			case 6:
				obj.cookieSize = reader.ReadSingle();
				break;
			case 7:
				obj.shadows = (LightShadows)reader.ReadInt32();
				break;
			case 8:
				obj.shadowStrength = reader.ReadSingle();
				break;
			case 9:
				obj.shadowBias = reader.ReadSingle();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize2028243609(MonoBehaviour obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.useGUILayout, writer);
	}

	private MonoBehaviour Deserialize2028243609(MonoBehaviour obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				obj.useGUILayout = reader.ReadBoolean();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize1891515754(UnityEngine.Object obj, int objTypeId, ProtoWriter writer)
	{
	}

	private UnityEngine.Object Deserialize1891515754(UnityEngine.Object obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize605020259(Quaternion obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.x, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.y, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.z, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.w, writer);
	}

	private Quaternion Deserialize605020259(Quaternion obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.x = reader.ReadSingle();
				break;
			case 2:
				obj.y = reader.ReadSingle();
				break;
			case 3:
				obj.z = reader.ReadSingle();
				break;
			case 4:
				obj.w = reader.ReadSingle();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1762542304(SphereCollider obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.enabled, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.isTrigger, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1181346079(obj.center, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.radius, writer);
	}

	private SphereCollider Deserialize1762542304(SphereCollider obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.enabled = reader.ReadBoolean();
				break;
			case 2:
				obj.isTrigger = reader.ReadBoolean();
				break;
			case 3:
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj.center = this.Deserialize1181346079(obj.center, reader);
				ProtoReader.EndSubItem(token, reader);
				break;
			}
			case 4:
				obj.radius = reader.ReadSingle();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize149935601(Transform obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.String, writer);
		SubItemToken token = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1181346079(obj.localPosition, objTypeId, writer);
		ProtoWriter.EndSubItem(token, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
		SubItemToken token2 = ProtoWriter.StartSubItem(null, writer);
		this.Serialize605020259(obj.localRotation, objTypeId, writer);
		ProtoWriter.EndSubItem(token2, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
		SubItemToken token3 = ProtoWriter.StartSubItem(null, writer);
		this.Serialize1181346079(obj.localScale, objTypeId, writer);
		ProtoWriter.EndSubItem(token3, writer);
	}

	private Transform Deserialize149935601(Transform obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj.localPosition = this.Deserialize1181346079(obj.localPosition, reader);
				ProtoReader.EndSubItem(token, reader);
				break;
			}
			case 2:
			{
				SubItemToken token2 = ProtoReader.StartSubItem(reader);
				obj.localRotation = this.Deserialize605020259(obj.localRotation, reader);
				ProtoReader.EndSubItem(token2, reader);
				break;
			}
			case 3:
			{
				SubItemToken token3 = ProtoReader.StartSubItem(reader);
				obj.localScale = this.Deserialize1181346079(obj.localScale, reader);
				ProtoReader.EndSubItem(token3, reader);
				break;
			}
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1181346080(Vector2 obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.x, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.y, writer);
	}

	private Vector2 Deserialize1181346080(Vector2 obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.y = reader.ReadSingle();
				}
			}
			else
			{
				obj.x = reader.ReadSingle();
			}
		}
		return obj;
	}

	private void Serialize1181346079(Vector3 obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.x, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.y, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.z, writer);
	}

	private Vector3 Deserialize1181346079(Vector3 obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.x = reader.ReadSingle();
				break;
			case 2:
				obj.y = reader.ReadSingle();
				break;
			case 3:
				obj.z = reader.ReadSingle();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize1181346078(Vector4 obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.x, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.y, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.z, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.w, writer);
	}

	private Vector4 Deserialize1181346078(Vector4 obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.x = reader.ReadSingle();
				break;
			case 2:
				obj.y = reader.ReadSingle();
				break;
			case 3:
				obj.z = reader.ReadSingle();
				break;
			case 4:
				obj.w = reader.ReadSingle();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize438265826(UnstuckPlayer obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		if (obj.previousPositions != null)
		{
			foreach (Vector3 obj2 in obj.previousPositions)
			{
				ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
				SubItemToken token = ProtoWriter.StartSubItem(null, writer);
				this.Serialize1181346079(obj2, objTypeId, writer);
				ProtoWriter.EndSubItem(token, writer);
			}
		}
	}

	private UnstuckPlayer Deserialize438265826(UnstuckPlayer obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					List<Vector3> list = obj.previousPositions ?? new List<Vector3>();
					int fieldNumber = reader.FieldNumber;
					do
					{
						Vector3 vector = default(Vector3);
						SubItemToken token = ProtoReader.StartSubItem(reader);
						vector = this.Deserialize1181346079(vector, reader);
						ProtoReader.EndSubItem(token, reader);
						list.Add(vector);
					}
					while (reader.TryReadFieldHeader(fieldNumber));
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize1297003913(UpgradeConsole obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		if (obj.serializedModuleSlots != null)
		{
			foreach (KeyValuePair<string, string> obj2 in obj.serializedModuleSlots)
			{
				ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
				SubItemToken token = ProtoWriter.StartSubItem(null, writer);
				this.Serialize524780017(obj2, objTypeId, writer);
				ProtoWriter.EndSubItem(token, writer);
			}
		}
	}

	private UpgradeConsole Deserialize1297003913(UpgradeConsole obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 3)
				{
					reader.SkipField();
				}
				else
				{
					Dictionary<string, string> dictionary = new Dictionary<string, string>();
					int fieldNumber = reader.FieldNumber;
					do
					{
						KeyValuePair<string, string> obj2 = default(KeyValuePair<string, string>);
						SubItemToken token = ProtoReader.StartSubItem(reader);
						obj2 = this.Deserialize524780017(obj2, reader);
						ProtoReader.EndSubItem(token, reader);
						dictionary[obj2.Key] = obj2.Value;
					}
					while (reader.TryReadFieldHeader(fieldNumber));
					obj.serializedModuleSlots = dictionary;
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize1113570486(Vehicle obj, int objTypeId, ProtoWriter writer)
	{
		if (objTypeId == 2106147891)
		{
			ProtoWriter.WriteFieldHeader(2100, WireType.String, writer);
			SubItemToken token = ProtoWriter.StartSubItem(null, writer);
			this.Serialize2106147891(obj as SeaMoth, objTypeId, writer);
			ProtoWriter.EndSubItem(token, writer);
		}
		else if (objTypeId == 1174302959)
		{
			ProtoWriter.WriteFieldHeader(2200, WireType.String, writer);
			SubItemToken token2 = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1174302959(obj as Exosuit, objTypeId, writer);
			ProtoWriter.EndSubItem(token2, writer);
		}
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		if (obj.vehicleName != null)
		{
			ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
			ProtoWriter.WriteString(obj.vehicleName, writer);
		}
		if (obj.vehicleColors != null)
		{
			foreach (Vector3 obj2 in obj.vehicleColors)
			{
				ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
				SubItemToken token3 = ProtoWriter.StartSubItem(null, writer);
				this.Serialize1181346079(obj2, objTypeId, writer);
				ProtoWriter.EndSubItem(token3, writer);
			}
		}
		if (obj.serializedModules != null)
		{
			byte[] serializedModules = obj.serializedModules;
			ProtoWriter.WriteFieldHeader(4, WireType.String, writer);
			ProtoWriter.WriteBytes(serializedModules, writer);
		}
		if (obj.serializedModuleSlots != null)
		{
			foreach (KeyValuePair<string, string> obj3 in obj.serializedModuleSlots)
			{
				ProtoWriter.WriteFieldHeader(5, WireType.String, writer);
				SubItemToken token4 = ProtoWriter.StartSubItem(null, writer);
				this.Serialize524780017(obj3, objTypeId, writer);
				ProtoWriter.EndSubItem(token4, writer);
			}
		}
		ProtoWriter.WriteFieldHeader(6, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.forceWalkMotorMode, writer);
		if (obj.pilotId != null)
		{
			ProtoWriter.WriteFieldHeader(7, WireType.String, writer);
			ProtoWriter.WriteString(obj.pilotId, writer);
		}
	}

	private Vehicle Deserialize1113570486(Vehicle obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 2100)
			{
				SubItemToken token = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize2106147891(obj as SeaMoth, reader);
				ProtoReader.EndSubItem(token, reader);
			}
			else
			{
				if (i != 2200)
				{
					IL_18E:
					while (i > 0)
					{
						switch (i)
						{
						case 1:
							obj.version = reader.ReadInt32();
							break;
						case 2:
							obj.vehicleName = reader.ReadString();
							break;
						case 3:
						{
							List<Vector3> list = new List<Vector3>();
							int fieldNumber = reader.FieldNumber;
							do
							{
								Vector3 vector = default(Vector3);
								SubItemToken token2 = ProtoReader.StartSubItem(reader);
								vector = this.Deserialize1181346079(vector, reader);
								ProtoReader.EndSubItem(token2, reader);
								list.Add(vector);
							}
							while (reader.TryReadFieldHeader(fieldNumber));
							obj.vehicleColors = list.ToArray();
							break;
						}
						case 4:
							obj.serializedModules = ProtoReader.AppendBytes(obj.serializedModules, reader);
							break;
						case 5:
						{
							Dictionary<string, string> dictionary = new Dictionary<string, string>();
							int fieldNumber2 = reader.FieldNumber;
							do
							{
								KeyValuePair<string, string> obj2 = default(KeyValuePair<string, string>);
								SubItemToken token3 = ProtoReader.StartSubItem(reader);
								obj2 = this.Deserialize524780017(obj2, reader);
								ProtoReader.EndSubItem(token3, reader);
								dictionary[obj2.Key] = obj2.Value;
							}
							while (reader.TryReadFieldHeader(fieldNumber2));
							obj.serializedModuleSlots = dictionary;
							break;
						}
						case 6:
							obj.forceWalkMotorMode = reader.ReadBoolean();
							break;
						case 7:
							obj.pilotId = reader.ReadString();
							break;
						default:
							reader.SkipField();
							break;
						}
						i = reader.ReadFieldHeader();
					}
					return obj;
				}
				SubItemToken token4 = ProtoReader.StartSubItem(reader);
				obj = this.Deserialize1174302959(obj as Exosuit, reader);
				ProtoReader.EndSubItem(token4, reader);
			}
		}
		goto IL_18E;
	}

	private void Serialize509097267(VentGardenLarge obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.playerInside, writer);
	}

	private VentGardenLarge Deserialize509097267(VentGardenLarge obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1)
			{
				if (i != 2)
				{
					reader.SkipField();
				}
				else
				{
					obj.playerInside = reader.ReadBoolean();
				}
			}
			else
			{
				obj.version = reader.ReadInt32();
			}
		}
		return obj;
	}

	private void Serialize2124310223(VFXConstructing obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.constructed, writer);
	}

	private VFXConstructing Deserialize2124310223(VFXConstructing obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				obj.constructed = reader.ReadSingle();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize252526906(VoidLeviathan obj, int objTypeId, ProtoWriter writer)
	{
	}

	private VoidLeviathan Deserialize252526906(VoidLeviathan obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize532876397(WalkingWaterParkCreature obj, int objTypeId, ProtoWriter writer)
	{
	}

	private WalkingWaterParkCreature Deserialize532876397(WalkingWaterParkCreature obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize328683587(Warper obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Warper Deserialize328683587(Warper obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	private void Serialize522953267(WaterPark obj, int objTypeId, ProtoWriter writer)
	{
		if (objTypeId == 1793440205)
		{
			ProtoWriter.WriteFieldHeader(1000, WireType.String, writer);
			SubItemToken token = ProtoWriter.StartSubItem(null, writer);
			this.Serialize1793440205(obj as LargeRoomWaterPark, objTypeId, writer);
			ProtoWriter.EndSubItem(token, writer);
		}
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj._constructed, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
		SubItemToken token2 = ProtoWriter.StartSubItem(null, writer);
		this.Serialize497398254(obj._moduleFace, objTypeId, writer);
		ProtoWriter.EndSubItem(token2, writer);
	}

	private WaterPark Deserialize522953267(WaterPark obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1000)
			{
				IL_9C:
				while (i > 0)
				{
					switch (i)
					{
					case 1:
						obj.version = reader.ReadInt32();
						break;
					case 2:
						obj._constructed = reader.ReadSingle();
						break;
					case 3:
					{
						SubItemToken token = ProtoReader.StartSubItem(reader);
						obj._moduleFace = this.Deserialize497398254(obj._moduleFace, reader);
						ProtoReader.EndSubItem(token, reader);
						break;
					}
					default:
						reader.SkipField();
						break;
					}
					i = reader.ReadFieldHeader();
				}
				return obj;
			}
			SubItemToken token2 = ProtoReader.StartSubItem(reader);
			obj = this.Deserialize1793440205(obj as LargeRoomWaterPark, reader);
			ProtoReader.EndSubItem(token2, reader);
		}
		goto IL_9C;
	}

	private void Serialize1054395028(WaterParkCreature obj, int objTypeId, ProtoWriter writer)
	{
		if (objTypeId == 532876397)
		{
			ProtoWriter.WriteFieldHeader(1000, WireType.String, writer);
			SubItemToken token = ProtoWriter.StartSubItem(null, writer);
			this.Serialize532876397(obj as WalkingWaterParkCreature, objTypeId, writer);
			ProtoWriter.EndSubItem(token, writer);
		}
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		ProtoWriter.WriteFieldHeader(2, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.age, writer);
		ProtoWriter.WriteFieldHeader(3, WireType.Fixed32, writer);
		ProtoWriter.WriteSingle(obj.timeNextBreed, writer);
		ProtoWriter.WriteFieldHeader(4, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.bornInside, writer);
	}

	private WaterParkCreature Deserialize1054395028(WaterParkCreature obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i != 1000)
			{
				IL_9B:
				while (i > 0)
				{
					switch (i)
					{
					case 1:
						obj.version = reader.ReadInt32();
						break;
					case 2:
						obj.age = reader.ReadSingle();
						break;
					case 3:
						obj.timeNextBreed = reader.ReadSingle();
						break;
					case 4:
						obj.bornInside = reader.ReadBoolean();
						break;
					default:
						reader.SkipField();
						break;
					}
					i = reader.ReadFieldHeader();
				}
				return obj;
			}
			SubItemToken token = ProtoReader.StartSubItem(reader);
			obj = this.Deserialize532876397(obj as WalkingWaterParkCreature, reader);
			ProtoReader.EndSubItem(token, reader);
		}
		goto IL_9B;
	}

	private void Serialize160169329(WeatherManager obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteInt32(obj.version, writer);
		if (obj.savedWeatherEventId != null)
		{
			ProtoWriter.WriteFieldHeader(2, WireType.String, writer);
			ProtoWriter.WriteString(obj.savedWeatherEventId, writer);
		}
		if (obj.savedWeatherProfileId != null)
		{
			ProtoWriter.WriteFieldHeader(3, WireType.String, writer);
			ProtoWriter.WriteString(obj.savedWeatherProfileId, writer);
		}
	}

	private WeatherManager Deserialize160169329(WeatherManager obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			switch (i)
			{
			case 1:
				obj.version = reader.ReadInt32();
				break;
			case 2:
				obj.savedWeatherEventId = reader.ReadString();
				break;
			case 3:
				obj.savedWeatherProfileId = reader.ReadString();
				break;
			default:
				reader.SkipField();
				break;
			}
		}
		return obj;
	}

	private void Serialize840818195(WeldableWallPanelGeneric obj, int objTypeId, ProtoWriter writer)
	{
		ProtoWriter.WriteFieldHeader(1, WireType.Variant, writer);
		ProtoWriter.WriteBoolean(obj.repaired, writer);
	}

	private WeldableWallPanelGeneric Deserialize840818195(WeldableWallPanelGeneric obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			if (i == 1)
			{
				obj.repaired = reader.ReadBoolean();
			}
			else
			{
				reader.SkipField();
			}
		}
		return obj;
	}

	private void Serialize1333430695(Workbench obj, int objTypeId, ProtoWriter writer)
	{
	}

	private Workbench Deserialize1333430695(Workbench obj, ProtoReader reader)
	{
		for (int i = reader.ReadFieldHeader(); i > 0; i = reader.ReadFieldHeader())
		{
			reader.SkipField();
		}
		return obj;
	}

	public const ulong version = 5UL;

	private static readonly Dictionary<Type, int> knownTypes = new Dictionary<Type, int>
	{
		{
			typeof(AmbientLightSettings),
			1804294731
		},
		{
			typeof(AmbientSettings),
			2000594119
		},
		{
			typeof(AnalyticsController),
			7443242
		},
		{
			typeof(AnimatorParameterValue),
			880630407
		},
		{
			typeof(AnteChamber),
			624729416
		},
		{
			typeof(ArcticPeeper),
			1238042655
		},
		{
			typeof(ArcticRay),
			1872669462
		},
		{
			typeof(ArrowRay),
			771173439
		},
		{
			typeof(AtmosphereVolume),
			239375628
		},
		{
			typeof(AttackLargeTarget),
			773384208
		},
		{
			typeof(AttractedByLargeTarget),
			1117396675
		},
		{
			typeof(Base),
			1966747463
		},
		{
			typeof(Base.Face),
			497398254
		},
		{
			typeof(BaseAddBulkheadGhost),
			1896640149
		},
		{
			typeof(BaseAddCellGhost),
			383673295
		},
		{
			typeof(BaseAddConnectorGhost),
			633495696
		},
		{
			typeof(BaseAddCorridorGhost),
			1506893401
		},
		{
			typeof(BaseAddFaceGhost),
			1090472122
		},
		{
			typeof(BaseAddFaceModuleGhost),
			1761765682
		},
		{
			typeof(BaseAddLadderGhost),
			2060501761
		},
		{
			typeof(BaseAddMapRoomGhost),
			1422648694
		},
		{
			typeof(BaseAddModuleGhost),
			862251519
		},
		{
			typeof(BaseAddPartitionDoorGhost),
			1406047219
		},
		{
			typeof(BaseAddPartitionGhost),
			490474621
		},
		{
			typeof(BaseAddWallFoundationGhost),
			1857674086
		},
		{
			typeof(BaseAddWaterPark),
			1127946067
		},
		{
			typeof(BaseBioReactor),
			1584912799
		},
		{
			typeof(BaseCell),
			2146397475
		},
		{
			typeof(BaseControlRoomModule),
			2039446747
		},
		{
			typeof(BaseDeconstructable),
			1469570205
		},
		{
			typeof(BaseExplicitFace),
			371084514
		},
		{
			typeof(BaseFloodSim),
			1725266300
		},
		{
			typeof(BaseGhost),
			1585678550
		},
		{
			typeof(BaseName),
			1147135728
		},
		{
			typeof(BaseNuclearReactor),
			1384707171
		},
		{
			typeof(BasePipeConnector),
			882866214
		},
		{
			typeof(BaseRoot),
			311542795
		},
		{
			typeof(BaseSpotLight),
			1045809045
		},
		{
			typeof(BaseUpgradeConsole),
			1537880658
		},
		{
			typeof(Battery),
			1659399257
		},
		{
			typeof(BatteryCharger),
			788408569
		},
		{
			typeof(BatterySource),
			929691462
		},
		{
			typeof(Beacon),
			1711377162
		},
		{
			typeof(Bioreactor),
			1011566978
		},
		{
			typeof(BirdBehaviour),
			40841636
		},
		{
			typeof(Biter),
			649861234
		},
		{
			typeof(Bladderfish),
			953017598
		},
		{
			typeof(Bleeder),
			1041366111
		},
		{
			typeof(BloomCreature),
			829906308
		},
		{
			typeof(BlueprintHandTarget),
			1012963343
		},
		{
			typeof(BodyTemperature),
			535540024
		},
		{
			typeof(BoneShark),
			242904679
		},
		{
			typeof(Boomerang),
			1716510642
		},
		{
			typeof(Breach),
			1772819529
		},
		{
			typeof(Brinewing),
			2093360837
		},
		{
			typeof(BruteShark),
			42492657
		},
		{
			typeof(CaveCrawler),
			1176920975
		},
		{
			typeof(CellManager.CellHeader),
			1956492848
		},
		{
			typeof(CellManager.CellHeaderEx),
			949139443
		},
		{
			typeof(CellManager.CellsFileHeader),
			153467737
		},
		{
			typeof(Charger),
			642877324
		},
		{
			typeof(Chelicerate),
			836898529
		},
		{
			typeof(CoffeeMachineLegacy),
			237257528
		},
		{
			typeof(CollectShiny),
			812739867
		},
		{
			typeof(ColoredLabel),
			515927774
		},
		{
			typeof(ColorNameControl),
			483523761
		},
		{
			typeof(Constructable),
			396637907
		},
		{
			typeof(ConstructableBase),
			817046334
		},
		{
			typeof(Constructor),
			326697518
		},
		{
			typeof(ConstructorInput),
			257036954
		},
		{
			typeof(CrabSnake),
			1998792992
		},
		{
			typeof(CrabSquid),
			49368518
		},
		{
			typeof(Crafter),
			135876261
		},
		{
			typeof(CrafterLogic),
			2100222829
		},
		{
			typeof(CraftingAnalytics),
			1703576080
		},
		{
			typeof(CraftingAnalytics.EntryData),
			1103056798
		},
		{
			typeof(Crash),
			1234455261
		},
		{
			typeof(CrashedShipExploder),
			1711422107
		},
		{
			typeof(CrashHome),
			660968298
		},
		{
			typeof(Creature),
			356643005
		},
		{
			typeof(CreatureBehaviour),
			406373562
		},
		{
			typeof(CreatureDeath),
			801838245
		},
		{
			typeof(CreatureEgg),
			59821228
		},
		{
			typeof(CreatureFriend),
			2001815917
		},
		{
			typeof(CreepvineSeed),
			730995178
		},
		{
			typeof(Cryptosuchus),
			1287561620
		},
		{
			typeof(CurrentGenerator),
			860890656
		},
		{
			typeof(CuteFish),
			1880729675
		},
		{
			typeof(CyclopsDecoyLoadingTube),
			1489909791
		},
		{
			typeof(CyclopsLightingPanel),
			2083308735
		},
		{
			typeof(CyclopsMotorMode),
			2062152363
		},
		{
			typeof(DayNightCycle),
			315488296
		},
		{
			typeof(DayNightLight),
			26260290
		},
		{
			typeof(DeployableDrill),
			658541966
		},
		{
			typeof(DisableBeforeExplosion),
			898747676
		},
		{
			typeof(DiscusFish),
			236473635
		},
		{
			typeof(DiveReel),
			10881664
		},
		{
			typeof(DiveReelAnchor),
			1954617231
		},
		{
			typeof(Dockable),
			205226061
		},
		{
			typeof(Drillable),
			2100518191
		},
		{
			typeof(DropEnzymes),
			662718200
		},
		{
			typeof(Durable),
			790665541
		},
		{
			typeof(Eatable),
			1080881920
		},
		{
			typeof(EnergyMixin),
			1427962681
		},
		{
			typeof(EntitySlot),
			1922274571
		},
		{
			typeof(EntitySlotData),
			1404549125
		},
		{
			typeof(EntitySlotsPlaceholder),
			1971823303
		},
		{
			typeof(ExchangerRocketConstructor),
			387767963
		},
		{
			typeof(ExecutionOrderTest),
			1433797848
		},
		{
			typeof(Exosuit),
			1174302959
		},
		{
			typeof(Eyeye),
			351821017
		},
		{
			typeof(Fabricator),
			606619525
		},
		{
			typeof(FairRandomizer),
			776720259
		},
		{
			typeof(FeatherFish),
			1794521971
		},
		{
			typeof(FiltrationMachine),
			1004993247
		},
		{
			typeof(FireExtinguisher),
			325421431
		},
		{
			typeof(FireExtinguisherHolder),
			1618351061
		},
		{
			typeof(FixedBase),
			331658349
		},
		{
			typeof(global::Flare),
			304513582
		},
		{
			typeof(FogSettings),
			108625815
		},
		{
			typeof(FrozenResource),
			478713964
		},
		{
			typeof(FruitPlant),
			41335609
		},
		{
			typeof(Garryfish),
			1816388137
		},
		{
			typeof(GasoPod),
			476284185
		},
		{
			typeof(GenericConsole),
			459225532
		},
		{
			typeof(GhostCrafter),
			630473610
		},
		{
			typeof(GhostLeviatanVoid),
			1817260405
		},
		{
			typeof(GhostLeviathan),
			35332337
		},
		{
			typeof(GhostPickupable),
			530216075
		},
		{
			typeof(GhostRay),
			1389926401
		},
		{
			typeof(GlacialBasinBridgeController),
			1396620629
		},
		{
			typeof(GlowWhale),
			1702754208
		},
		{
			typeof(Grabcrab),
			2033371878
		},
		{
			typeof(Grid3<float>),
			1182280616
		},
		{
			typeof(Grid3<Vector3>),
			1765532648
		},
		{
			typeof(Grid3Shape),
			997267884
		},
		{
			typeof(Grower),
			697741374
		},
		{
			typeof(GrowingPlant),
			792963384
		},
		{
			typeof(GrownPlant),
			113236186
		},
		{
			typeof(HandTarget),
			2066256250
		},
		{
			typeof(Holefish),
			646820922
		},
		{
			typeof(Hoopfish),
			328727906
		},
		{
			typeof(Hoverbike),
			802059837
		},
		{
			typeof(Hoverfish),
			1859566378
		},
		{
			typeof(Incubator),
			1024693509
		},
		{
			typeof(InfectedMixin),
			2004070125
		},
		{
			typeof(Int3),
			1691070576
		},
		{
			typeof(Int3.Bounds),
			1164389947
		},
		{
			typeof(Int3Class),
			289177516
		},
		{
			typeof(IntroDropshipExplode),
			1160243952
		},
		{
			typeof(Inventory),
			51037994
		},
		{
			typeof(ItemExchanger),
			474388930
		},
		{
			typeof(Jellyfish),
			1941291928
		},
		{
			typeof(Jellyray),
			1338410882
		},
		{
			typeof(JointHelper),
			1430634702
		},
		{
			typeof(JukeboxInstance),
			1662769415
		},
		{
			typeof(Jumper),
			1252700319
		},
		{
			typeof(KeypadDoorConsole),
			1032585975
		},
		{
			typeof(KeypadDoorConsoleUnlock),
			1059166753
		},
		{
			typeof(LandCreatureGravity),
			805312304
		},
		{
			typeof(LargeRoomWaterPark),
			1793440205
		},
		{
			typeof(LargeWorldBatchRoot),
			1878920823
		},
		{
			typeof(LargeWorldEntity),
			577496260
		},
		{
			typeof(LargeWorldEntityCell),
			122249312
		},
		{
			typeof(LaserCutObject),
			769725772
		},
		{
			typeof(LavaLarva),
			353579366
		},
		{
			typeof(LavaLizard),
			1882829928
		},
		{
			typeof(LavaShell),
			1703248490
		},
		{
			typeof(LeakingRadiation),
			656832482
		},
		{
			typeof(LEDLight),
			200911463
		},
		{
			typeof(Leviathan),
			1332964068
		},
		{
			typeof(LifepodDrop),
			1372467290
		},
		{
			typeof(LilyPaddler),
			1271521784
		},
		{
			typeof(LiveMixin),
			729882159
		},
		{
			typeof(MapRoomCamera),
			1855998104
		},
		{
			typeof(MapRoomCameraDocking),
			1304741297
		},
		{
			typeof(MapRoomFunctionality),
			503490010
		},
		{
			typeof(MapRoomScreen),
			1343493277
		},
		{
			typeof(MedicalCabinet),
			670501331
		},
		{
			typeof(Mesmer),
			123477383
		},
		{
			typeof(MobileExtractorMachine),
			2078931521
		},
		{
			typeof(NitrogenLevel),
			1761034218
		},
		{
			typeof(NootFish),
			1124647116
		},
		{
			typeof(NotificationManager.NotificationData),
			1874975849
		},
		{
			typeof(NotificationManager.NotificationId),
			1731663660
		},
		{
			typeof(NotificationManager.SerializedData),
			348559960
		},
		{
			typeof(NuclearReactor),
			802993602
		},
		{
			typeof(OculusFish),
			1829844631
		},
		{
			typeof(Oxygen),
			190681690
		},
		{
			typeof(OxygenPipe),
			569028242
		},
		{
			typeof(OxygenPlant),
			1056558719
		},
		{
			typeof(PDAEncyclopedia.Entry),
			1244614203
		},
		{
			typeof(PDALog.Entry),
			1329426611
		},
		{
			typeof(PDAScanner.Data),
			2137760429
		},
		{
			typeof(PDAScanner.Entry),
			248259089
		},
		{
			typeof(PDASounds),
			1488630837
		},
		{
			typeof(Peeper),
			1124891617
		},
		{
			typeof(Penguin),
			526214298
		},
		{
			typeof(PenguinBaby),
			1457388542
		},
		{
			typeof(PickPrefab),
			1289092887
		},
		{
			typeof(Pickupable),
			723629918
		},
		{
			typeof(PictureFrame),
			1527139359
		},
		{
			typeof(PingInstance),
			205484837
		},
		{
			typeof(Pinnacarid),
			414351131
		},
		{
			typeof(Pipe),
			837446894
		},
		{
			typeof(PipeSurfaceFloater),
			955443574
		},
		{
			typeof(Plantable),
			542223321
		},
		{
			typeof(Player),
			1875862075
		},
		{
			typeof(PlayerLilyPaddlerHypnosis),
			424968344
		},
		{
			typeof(PlayerSoundTrigger),
			10406022
		},
		{
			typeof(PlayerTimeCapsule),
			407275749
		},
		{
			typeof(PlayerWorldArrows),
			1675048343
		},
		{
			typeof(PowerCellCharger),
			1386435207
		},
		{
			typeof(PowerCrafter),
			1800229096
		},
		{
			typeof(PowerGenerator),
			797173896
		},
		{
			typeof(PowerSource),
			1522229446
		},
		{
			typeof(PrecursorAquariumPlatformTrigger),
			356984973
		},
		{
			typeof(PrecursorComputerTerminal),
			1541346828
		},
		{
			typeof(PrecursorDisableGunTerminal),
			1457139245
		},
		{
			typeof(PrecursorDoorKeyColumn),
			1505210158
		},
		{
			typeof(PrecursorElevator),
			185046565
		},
		{
			typeof(PrecursorGunStoryEvents),
			285680569
		},
		{
			typeof(PrecursorIonCrystal),
			999481743
		},
		{
			typeof(PrecursorKeyTerminal),
			2051895012
		},
		{
			typeof(PrecursorPartFabricator),
			309711119
		},
		{
			typeof(PrecursorPrisonVent),
			496960061
		},
		{
			typeof(PrecursorSurfaceVent),
			1169611549
		},
		{
			typeof(PrecursorTeleporter),
			1340645883
		},
		{
			typeof(PrecursorTeleporterActivationTerminal),
			1713660373
		},
		{
			typeof(PrefabPlaceholdersGroup),
			2111234577
		},
		{
			typeof(PrisonManager),
			851981872
		},
		{
			typeof(PropulseCannonAmmoHandler),
			1677184373
		},
		{
			typeof(ProtobufSerializer.ComponentHeader),
			313352173
		},
		{
			typeof(ProtobufSerializer.GameObjectData),
			1159039820
		},
		{
			typeof(ProtobufSerializer.LoopHeader),
			69304398
		},
		{
			typeof(ProtobufSerializer.StreamHeader),
			217879716
		},
		{
			typeof(ProtobufSerializerCornerCases),
			328142573
		},
		{
			typeof(QuantumLocker),
			1186708671
		},
		{
			typeof(RabbitRay),
			1082285174
		},
		{
			typeof(ReaperLeviathan),
			1702762571
		},
		{
			typeof(Reefback),
			1651949009
		},
		{
			typeof(ReefbackCreature),
			803494206
		},
		{
			typeof(ReefbackLife),
			1077102969
		},
		{
			typeof(ReefbackPlant),
			1948869956
		},
		{
			typeof(Reginald),
			924544622
		},
		{
			typeof(ResearchBase),
			2054867230
		},
		{
			typeof(ResourceTrackerDatabase),
			859052613
		},
		{
			typeof(ResourceTrackerDatabase.ResourceInfo),
			161874211
		},
		{
			typeof(Respawn),
			11492366
		},
		{
			typeof(RestoreAnimatorState),
			253947874
		},
		{
			typeof(RestoreDayNightCycle),
			273953122
		},
		{
			typeof(RestoreInventoryStorage),
			2024062491
		},
		{
			typeof(Rocket),
			1273669126
		},
		{
			typeof(RocketConstructorInput),
			1170326782
		},
		{
			typeof(RocketPreflightCheckManager),
			916327342
		},
		{
			typeof(RockGrub),
			1070978565
		},
		{
			typeof(RockPuncher),
			842397654
		},
		{
			typeof(Roost),
			82819465
		},
		{
			typeof(SandShark),
			81014147
		},
		{
			typeof(SaveLoadManager.OptionsCache),
			846562516
		},
		{
			typeof(SceneObjectData),
			1881457915
		},
		{
			typeof(SceneObjectDataSet),
			2013353155
		},
		{
			typeof(SeaDragon),
			1606650114
		},
		{
			typeof(SeaEmperorBaby),
			1327055215
		},
		{
			typeof(SeaEmperorJuvenile),
			1921909083
		},
		{
			typeof(Sealed),
			1086395194
		},
		{
			typeof(SeaMonkey),
			615648120
		},
		{
			typeof(SeaMonkeyBaby),
			1640880
		},
		{
			typeof(SeaMonkeySpawnRandomItem),
			1277798743
		},
		{
			typeof(SeaMoth),
			2106147891
		},
		{
			typeof(SeamothStorageContainer),
			1319564559
		},
		{
			typeof(SeaTreader),
			574222852
		},
		{
			typeof(SeaTruckConnection),
			1716108768
		},
		{
			typeof(SeaTruckDockingBay),
			1624342325
		},
		{
			typeof(SeaTruckLights),
			944362993
		},
		{
			typeof(SeaTruckMotor),
			294226815
		},
		{
			typeof(SeaTruckTeleporter),
			728043624
		},
		{
			typeof(SeaTruckUpgrades),
			514291595
		},
		{
			typeof(ShadowLeviathan),
			1191484888
		},
		{
			typeof(Shocker),
			1535225367
		},
		{
			typeof(Sign),
			1084867387
		},
		{
			typeof(SignalPing),
			1732754958
		},
		{
			typeof(Skyray),
			469144263
		},
		{
			typeof(Slime),
			1355655442
		},
		{
			typeof(SnowStalker),
			1008105993
		},
		{
			typeof(SnowStalkerBaby),
			1630308817
		},
		{
			typeof(SolarPanel),
			524984727
		},
		{
			typeof(SoundQueue),
			350666384
		},
		{
			typeof(SoundQueue.Entry),
			682374214
		},
		{
			typeof(Spadefish),
			647827065
		},
		{
			typeof(SpawnStoredLoot),
			1993981848
		},
		{
			typeof(SpineEel),
			1058623975
		},
		{
			typeof(SpinnerFish),
			1711042137
		},
		{
			typeof(SpyPenguinName),
			1305740789
		},
		{
			typeof(SquidShark),
			861708591
		},
		{
			typeof(Stalker),
			1440414490
		},
		{
			typeof(StarshipDoor),
			737691900
		},
		{
			typeof(Stillsuit),
			242125589
		},
		{
			typeof(StorageContainer),
			366077262
		},
		{
			typeof(ScheduledGoal),
			704466011
		},
		{
			typeof(StoryGoalManager),
			1982063882
		},
		{
			typeof(StoryGoalScheduler),
			1506278612
		},
		{
			typeof(StoryGoalCustomEventHandler),
			502247445
		},
		{
			typeof(SubFire),
			1537030892
		},
		{
			typeof(SubRoot),
			1180542256
		},
		{
			typeof(SunlightSettings),
			1603999327
		},
		{
			typeof(SupplyCrate),
			1555952712
		},
		{
			typeof(SupplyDrop),
			787786344
		},
		{
			typeof(Survival),
			888605288
		},
		{
			typeof(SwimRandom),
			225324449
		},
		{
			typeof(SwimToMeat),
			1157251956
		},
		{
			typeof(SymbioteFish),
			3219972
		},
		{
			typeof(KeyValuePair<NotificationManager.NotificationId, NotificationManager.NotificationData>),
			1852174394
		},
		{
			typeof(KeyValuePair<int, SceneObjectData>),
			1116754719
		},
		{
			typeof(KeyValuePair<string, PDAEncyclopedia.Entry>),
			121008834
		},
		{
			typeof(KeyValuePair<string, PDALog.Entry>),
			1062675616
		},
		{
			typeof(KeyValuePair<string, SceneObjectData>),
			890247896
		},
		{
			typeof(KeyValuePair<string, bool>),
			1489031418
		},
		{
			typeof(KeyValuePair<string, int>),
			224877162
		},
		{
			typeof(KeyValuePair<string, float>),
			714689774
		},
		{
			typeof(KeyValuePair<string, string>),
			524780017
		},
		{
			typeof(KeyValuePair<string, TimeCapsuleContent>),
			1249808124
		},
		{
			typeof(KeyValuePair<TechType, CraftingAnalytics.EntryData>),
			1158933531
		},
		{
			typeof(TechFragment),
			212928398
		},
		{
			typeof(TechLight),
			1671198874
		},
		{
			typeof(TeleporterManager),
			2104816441
		},
		{
			typeof(Terraformer),
			645269343
		},
		{
			typeof(ThermalPlant),
			1983352738
		},
		{
			typeof(Thumper),
			2092842303
		},
		{
			typeof(TileInstance),
			746584541
		},
		{
			typeof(TimeCapsule),
			1386031502
		},
		{
			typeof(TimeCapsuleContent),
			1111417537
		},
		{
			typeof(TimeCapsuleItem),
			2044575597
		},
		{
			typeof(TitanHolefish),
			1888807148
		},
		{
			typeof(ToggleLights),
			1877364825
		},
		{
			typeof(Triops),
			1386215039
		},
		{
			typeof(Trivalve),
			1151491255
		},
		{
			typeof(AnimationCurve),
			118512508
		},
		{
			typeof(Behaviour),
			1825589276
		},
		{
			typeof(Bounds),
			391689956
		},
		{
			typeof(BoxCollider),
			892833698
		},
		{
			typeof(CapsuleCollider),
			1590521044
		},
		{
			typeof(Collider),
			72619689
		},
		{
			typeof(Color),
			1404661584
		},
		{
			typeof(Component),
			394322812
		},
		{
			typeof(Gradient),
			175529349
		},
		{
			typeof(GradientAlphaKey),
			1518696882
		},
		{
			typeof(GradientColorKey),
			1747546845
		},
		{
			typeof(Keyframe),
			1975582319
		},
		{
			typeof(Light),
			1364639273
		},
		{
			typeof(MonoBehaviour),
			2028243609
		},
		{
			typeof(UnityEngine.Object),
			1891515754
		},
		{
			typeof(Quaternion),
			605020259
		},
		{
			typeof(SphereCollider),
			1762542304
		},
		{
			typeof(Transform),
			149935601
		},
		{
			typeof(Vector2),
			1181346080
		},
		{
			typeof(Vector3),
			1181346079
		},
		{
			typeof(Vector4),
			1181346078
		},
		{
			typeof(UnstuckPlayer),
			438265826
		},
		{
			typeof(UpgradeConsole),
			1297003913
		},
		{
			typeof(Vehicle),
			1113570486
		},
		{
			typeof(VentGardenLarge),
			509097267
		},
		{
			typeof(VFXConstructing),
			2124310223
		},
		{
			typeof(VoidLeviathan),
			252526906
		},
		{
			typeof(WalkingWaterParkCreature),
			532876397
		},
		{
			typeof(Warper),
			328683587
		},
		{
			typeof(WaterPark),
			522953267
		},
		{
			typeof(WaterParkCreature),
			1054395028
		},
		{
			typeof(WeatherManager),
			160169329
		},
		{
			typeof(WeldableWallPanelGeneric),
			840818195
		},
		{
			typeof(Workbench),
			1333430695
		}
	};

	private static readonly HashSet<Type> emptyContracts = new HashSet<Type>
	{
		typeof(AttackLargeTarget),
		typeof(AttractedByLargeTarget),
		typeof(BaseCell),
		typeof(Bioreactor),
		typeof(Breach),
		typeof(CollectShiny),
		typeof(ConstructorInput),
		typeof(Crafter),
		typeof(DisableBeforeExplosion),
		typeof(Durable),
		typeof(ExecutionOrderTest),
		typeof(Fabricator),
		typeof(GhostCrafter),
		typeof(GhostPickupable),
		typeof(GrowingPlant),
		typeof(HandTarget),
		typeof(InfectedMixin),
		typeof(ItemExchanger),
		typeof(LargeWorldEntityCell),
		typeof(MapRoomScreen),
		typeof(NuclearReactor),
		typeof(PowerCrafter),
		typeof(PowerGenerator),
		typeof(PrecursorGunStoryEvents),
		typeof(PrecursorIonCrystal),
		typeof(PrecursorPartFabricator),
		typeof(PrecursorPrisonVent),
		typeof(PrecursorSurfaceVent),
		typeof(ReefbackCreature),
		typeof(ReefbackPlant),
		typeof(ResearchBase),
		typeof(RocketConstructorInput),
		typeof(Roost),
		typeof(SwimRandom),
		typeof(SwimToMeat),
		typeof(KeyValuePair<NotificationManager.NotificationId, NotificationManager.NotificationData>),
		typeof(KeyValuePair<int, SceneObjectData>),
		typeof(KeyValuePair<string, PDAEncyclopedia.Entry>),
		typeof(KeyValuePair<string, PDALog.Entry>),
		typeof(KeyValuePair<string, SceneObjectData>),
		typeof(KeyValuePair<string, bool>),
		typeof(KeyValuePair<string, int>),
		typeof(KeyValuePair<string, float>),
		typeof(KeyValuePair<string, string>),
		typeof(KeyValuePair<string, TimeCapsuleContent>),
		typeof(KeyValuePair<TechType, CraftingAnalytics.EntryData>),
		typeof(Component),
		typeof(UnityEngine.Object),
		typeof(Workbench)
	};
}