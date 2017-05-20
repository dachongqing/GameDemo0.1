﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LobbyRoom : MonoBehaviour, RoomInterface
{

	private String roomName;

	[SerializeField]private int[] xyz;

	private RoomConstant rc;

	public GameObject northDoor;
	public GameObject southDoor;
	public GameObject westDoor;
	public GameObject eastDoor;

    private Dictionary<String, EventInterface> eventsList = new Dictionary<string, EventInterface>();


    string RoomInterface.getRoomName ()
	{
		return "大厅"; 
	}

	string RoomInterface.getRoomType ()
	{
		return rc.ROOM_TYPE_LOBBY;
	}



	int[] RoomInterface.getXYZ ()
	{
		return xyz;
	}

	void RoomInterface.setXYZ (int[] xyz)
	{
		this.xyz = xyz;
	}
		
	public void northDoorEnable ()
	{
		//		northDoor.GetComponent<DoorInterface>().enabled = true;
		northDoor.GetComponent<DoorInterface> ().setShowFlag (true);//门的图片要替换
	}

	public void southDoorEnable ()
	{
		//		southDoor.GetComponent<DoorInterface>().enabled = true;
		southDoor.GetComponent<DoorInterface> ().setShowFlag (true);//门的图片要替换

	}

	public void westDoorEnable ()
	{
		//           westDoor.GetComponent<MonoBehaviour>().enabled = true;

		westDoor.GetComponent<DoorInterface> ().setShowFlag (true);//门的图片要替换
	}

	public void eastDoorEnable ()
	{
		//           eastDoor.GetComponent<MonoBehaviour>().enabled = true;
		eastDoor.GetComponent<DoorInterface> ().setShowFlag (true);//门的图片要替换
	}
		
	GameObject RoomInterface.getNorthDoor()
	{
		return northDoor;
	}
	GameObject RoomInterface.getSouthDoor()
	{
		return southDoor;
	}
	GameObject RoomInterface.getEastDoor()
	{
		return eastDoor;
	}
	GameObject RoomInterface.getWestDoor()
	{
		return westDoor;
	}


    public EventInterface getEvent(string eventType)
    {
        return eventsList[eventType];
    }

    public void setEvent(EventInterface ei)
    {
        eventsList.Add(ei.getEventType(), ei);

    }
}

