using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using System.Collections.Generic;
using NHapi.Model.V271.Segment;
using NHapi.Model.V271.Datatype;
using NHapi.Base.Model;

namespace NHapi.Model.V271.Group
{
///<summary>
///Represents the RRA_O18_ADMINISTRATION Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: RRA_O18_TREATMENT (a Group object) repeating</li>
///<li>1: RXR (Pharmacy/Treatment Route) </li>
///</ol>
///</summary>
[Serializable]
public class RRA_O18_ADMINISTRATION : AbstractGroup {

	///<summary> 
	/// Creates a new RRA_O18_ADMINISTRATION Group.
	///</summary>
	public RRA_O18_ADMINISTRATION(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(RRA_O18_TREATMENT), true, true);
	      this.add(typeof(RXR), true, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating RRA_O18_ADMINISTRATION - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns  first repetition of RRA_O18_TREATMENT (a Group object) - creates it if necessary
	///</summary>
	public RRA_O18_TREATMENT GetTREATMENT() {
	   RRA_O18_TREATMENT ret = null;
	   try {
	      ret = (RRA_O18_TREATMENT)this.GetStructure("TREATMENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of RRA_O18_TREATMENT
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public RRA_O18_TREATMENT GetTREATMENT(int rep) { 
	   return (RRA_O18_TREATMENT)this.GetStructure("TREATMENT", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RRA_O18_TREATMENT 
	 */ 
	public int TREATMENTRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("TREATMENT").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the RRA_O18_TREATMENT results 
	 */ 
	public IEnumerable<RRA_O18_TREATMENT> TREATMENTs 
	{ 
		get
		{
			for (int rep = 0; rep < TREATMENTRepetitionsUsed; rep++)
			{
				yield return (RRA_O18_TREATMENT)this.GetStructure("TREATMENT", rep);
			}
		}
	}

	///<summary>
	///Adds a new RRA_O18_TREATMENT
	///</summary>
	public RRA_O18_TREATMENT AddTREATMENT()
	{
		return this.AddStructure("TREATMENT") as RRA_O18_TREATMENT;
	}

	///<summary>
	///Removes the given RRA_O18_TREATMENT
	///</summary>
	public void RemoveTREATMENT(RRA_O18_TREATMENT toRemove)
	{
		this.RemoveStructure("TREATMENT", toRemove);
	}

	///<summary>
	///Removes the RRA_O18_TREATMENT at the given index
	///</summary>
	public void RemoveTREATMENTAt(int index)
	{
		this.RemoveRepetition("TREATMENT", index);
	}

	///<summary>
	/// Returns RXR (Pharmacy/Treatment Route) - creates it if necessary
	///</summary>
	public RXR RXR { 
get{
	   RXR ret = null;
	   try {
	      ret = (RXR)this.GetStructure("RXR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
