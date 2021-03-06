﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public abstract class Gun_Base : NetworkBehaviour {

	public abstract void Reload();

	[Command]
	public abstract void CmdShoot(bool firstDown);	

	public abstract void Drop();

	/// <summary>
	/// Aligns the alignObject to point at the center of the players screen.
	/// Requires that the gun be equipped.
	/// </summary>
    public abstract void Align(Transform alignObject, Vector3 additionalRotation);

	public abstract void AlignGun();

	public abstract GunType GunType{get;}

	public abstract int ClipSize{get;}
	public abstract int BulletsInClip{get;}

}
