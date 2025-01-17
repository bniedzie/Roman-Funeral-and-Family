﻿// ----------------------------------------------------------------------------
// This source code is provided only under the Creative Commons licensing terms stated below.
// HVWC Multiplayer Platform alpha v1 by Institute for Digital Intermedia Arts at Ball State University \is licensed under a Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International License.
// Based on a work at https://github.com/HVWC/HVWC.
// Work URL: http://idialab.org/mellon-foundation-humanities-virtual-world-consortium/
// Permissions beyond the scope of this license may be available at http://idialab.org/info/.
// To view a copy of this license, visit http://creativecommons.org/licenses/by-nc-sa/4.0/deed.en_US.
// ----------------------------------------------------------------------------
using UnityEngine;

/// <summary>
/// This class allows for hyperlinking clicks on structures to the correct placard.
/// </summary>
public class WebLinkCitation : MonoBehaviour {

	#region Fields
	/// <summary>
	/// The URL.
	/// </summary>
	public string url;
	#endregion

	#region Unity Messages
	/// <summary>
	/// A message called when the object is clicked.
	/// </summary>
	void OnMouseDown(){
		Application.OpenURL((Application.absoluteURL.Split('#'))[0] + url); //Just open the URL in the browser
	}
	#endregion
	
}
