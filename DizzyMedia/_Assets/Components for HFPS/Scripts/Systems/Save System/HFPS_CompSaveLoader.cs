using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DizzyMedia.HFPS_Components {

    [AddComponentMenu("Dizzy Media/Components for HFPS/Components/Systems/Save System/Components Save Loader")]
    public class HFPS_CompSaveLoader : MonoBehaviour {


    //////////////////////////////////////
    ///
    ///     VALUES
    ///
    ///////////////////////////////////////


        public bool useStartDelay;
        public float startDelay;


    //////////////////////////////////////
    ///
    ///     START ACTIONS
    ///
    ///////////////////////////////////////


        void Start() {

            StartInit();

        }//start

        public void StartInit(){

            if(useStartDelay){

                StartCoroutine("Start_Buff");

            //useStartDelay
            } else {
            
                if(!IsCurLevel_Check()){

                    Items_Update();
                    Objectives_Update();
                
                }//!is cur level

            }//useStartDelay

        }//StartInit

        private IEnumerator Start_Buff(){

            yield return new WaitForSeconds(startDelay);

            if(!IsCurLevel_Check()){

                Items_Update();
                Objectives_Update();
                
            }//!is cur level

        }//Start_Buff
        
        
    //////////////////////////////////////
    ///
    ///     LEVEL ACTIONS
    ///
    ///////////////////////////////////////
        
        
        public bool IsCurLevel_Check(){
        
            if(HFPS_CompSave.instance != null){

                return HFPS_CompSave.instance.IsCurLevel_Check();

            }//instance != null
            
            return false;
        
        }//IsCurLevel_Check


    //////////////////////////////////////
    ///
    ///     INVENTORY ACTIONS
    ///
    ///////////////////////////////////////


        private void Items_Update(){

            if(HFPS_CompSave.instance != null){

                HFPS_CompSave.instance.Items_Update();

            }//instance != null

        }//Items_Update


    //////////////////////////////////////
    ///
    ///     OBJECTIVE ACTIONS
    ///
    ///////////////////////////////////////


        private void Objectives_Update(){

            if(HFPS_CompSave.instance != null){

                HFPS_CompSave.instance.Objectives_Update();

            }//instance != null

        }//Objectives_Update


    }//HFPS_CompSaveLoader


}//namespace