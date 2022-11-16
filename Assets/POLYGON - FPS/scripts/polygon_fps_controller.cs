using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore;

public class polygon_fps_controller : MonoBehaviour
{

    // 
    public GameObject vehicle_camera;
    public GameObject FPS_camera;

    public GameObject aim_point;
    public GameObject shoot_handle;

    // Key input

    public bool Key_w;
    public bool Key_s;
    public bool Key_d;
    public bool Key_a;
    public bool key_reload;
    public bool key_duck;
    public bool key_jump;
    public bool key_run;
   

    // Status
    public bool idle;

    public bool forward;
    public bool back;
    public bool right;
    public bool left;

    public bool forward_right;
    public bool back_right;

    public bool forward_left;
    public bool back_left;

    public bool duck;
    public bool duck_walk;
    public bool reload;

    public bool jump;
    public bool run;
    public bool cam_toggled;



    private void Start()
    {
        saved_roation_X= vertical_aim_bone_default.transform.eulerAngles.x;

    

        Cursor.visible = false;



        GameObject target_add = GameObject.FindGameObjectWithTag("targets");

        target_add.GetComponent<targets_for_bunny>().Add_Target(gameObject);








        if (active_assault57.activeSelf)
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;



            assault57_bool = true;


            exit_weapons();

            active_assault57.SetActive(true);
            Icon_assault57.SetActive(true);
            active_assault57.GetComponent<assault57>().Start();

            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);





        }
        if (active_auge.activeSelf)
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


            auge_bool = true;
 

            exit_weapons();
            active_auge.SetActive(true);
            active_auge.GetComponent<auge>().Start();
            Icon_auge.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }

        if (active_blastset.activeSelf)
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;



            auge_bool = true;
   

            exit_weapons();
            active_blastset.SetActive(true);
            active_blastset.GetComponent<blast_set>().Start();
            Icon_blastset.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }
        if (active_buzzsub.activeSelf)
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;



            buzzsub_bool = true;


            // leaving all weapons
            exit_weapons();

            active_buzzsub.SetActive(true);
            active_buzzsub.GetComponent<buzzsub>().Start();
            Icon_buzzsub.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }

        if (active_clusterShotgun.activeSelf)
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;



            // leaving all weapons
            exit_weapons();

            active_clusterShotgun.SetActive(true);
            active_clusterShotgun.GetComponent<clusterShotgun>().Start();
            Icon_clusterShotgun.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }
        if (active_clustersub.activeSelf)
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;



            clusterSub_bool = true;


            // leaving all weapons
            exit_weapons();

            active_clustersub.SetActive(true);
            active_clustersub.GetComponent<clustersub>().Start();
            Icon_clustersub.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }

        if (active_crowbar.activeSelf)
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;



            // leaving all weapons
            exit_weapons();

            active_crowbar.SetActive(true);
            active_crowbar.GetComponent<crossbar>().Start();
            Icon_crowbar.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }
        if (active_fireaxe.activeSelf)
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;



            // leaving all weapons
            exit_weapons();

            active_fireaxe.SetActive(true);
            active_fireaxe.GetComponent<axe>().Start();
            Icon_fireaxe.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }

        if (active_flamethrower.activeSelf)
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;



            exit_weapons();

            active_flamethrower.SetActive(true);
            Icon_flamethrower.SetActive(true);
            active_flamethrower.GetComponent<flamethrower>().Start();

            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);





        }
        if (active_grenade.activeSelf)
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


 

            exit_weapons();
            active_grenade.SetActive(true);
            active_grenade.GetComponent<grenade>().Start();
            Icon_grenade.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }


        if (active_grenade.activeSelf)
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;





            exit_weapons();

            active_grenade_launcher.SetActive(true);
            Icon_grenade_launcher.SetActive(true);
            active_grenade_launcher.GetComponent<grenade_launcher>().Start();

            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);





        }
        if (active_hunterrifle.activeSelf)
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


            exit_weapons();
            active_hunterrifle.SetActive(true);
            active_hunterrifle.GetComponent<hunter_rifle>().Start();
            Icon_hunterrifle.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }

        if (active_lock.activeSelf)
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


            lock_bool = true;


            exit_weapons();
            active_lock.SetActive(true);
            active_lock.GetComponent<lock_>().Start();
            Icon_lock.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }
        if (active_machine_gun.activeSelf)
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


            machineGun_bool = true;
    

            exit_weapons();
            active_machine_gun.SetActive(true);
            active_machine_gun.GetComponent<machine_gun>().Start();
            Icon_machine_gun.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }

        if (active_mkb16.activeSelf)
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


            mkb16_bool = true;


            exit_weapons();
            active_mkb16.SetActive(true);
            active_mkb16.GetComponent<mkb16>().Start();
            Icon_mkb16.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }
        if (active_nsp.activeSelf)
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


            nsp_bool = true;
      

            exit_weapons();
            active_nsp.SetActive(true);
            active_nsp.GetComponent<nsp>().Start();
            Icon_nsp.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }

        if (active_old_pistol.activeSelf)
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


            old_pistol_bool = true;
  

            exit_weapons();
            active_old_pistol.SetActive(true);
            active_old_pistol.GetComponent<old_pistol>().Start();
            Icon_old_pistol.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }
        if (active_pistol9.activeSelf)
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


            pistol9_bool = true;


            exit_weapons();
            active_pistol9.SetActive(true);
            active_pistol9.GetComponent<pistol9>().Start();
            Icon_pistol9.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }

        if (active_pumpgun_a.activeSelf)
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


            pumpgun_a_bool = true;
   

            exit_weapons();
            active_pumpgun_a.SetActive(true);
            active_pumpgun_a.GetComponent<pumpgun_a>().Start();
            Icon_pumpgun_a.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }
        if (active_revolver.activeSelf)
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


            exit_weapons();
            active_revolver.SetActive(true);
            active_revolver.GetComponent<revolver>().Start();
            Icon_revolver.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }

        if (active_rocket_launcher.activeSelf)
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;




            exit_weapons();
            active_rocket_launcher.SetActive(true);
            active_rocket_launcher.GetComponent<rocket_launcher>().Start();
            Icon_rocket_launcher.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }
        if (active_rp9.activeSelf)
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


            rp9_bool = true;
      

            exit_weapons();
            active_rp9.SetActive(true);
            active_rp9.GetComponent<rp9>().Start();
            Icon_rp9.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }

        if (active_russian_sniper.activeSelf)
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;



            exit_weapons();
            active_russian_sniper.SetActive(true);
            active_russian_sniper.GetComponent<russian_sniper>().Start();
            Icon_russian_sniper.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }
        if (active_sce5.activeSelf)
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


            sce5_bool = true;
   

            exit_weapons();
            active_sce5.SetActive(true);
            active_sce5.GetComponent<sce5>().Start();
            Icon_sce5.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }

        if (active_scorp6.activeSelf)
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


            scorp6_bool = true;
  

            exit_weapons();
            active_scorp6.SetActive(true);
            active_scorp6.GetComponent<scorp6>().Start();
            Icon_scorp6.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }
        if (active_shotgun3.activeSelf)
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


            exit_weapons();
            active_shotgun3.SetActive(true);
            active_shotgun3.GetComponent<shotgun3>().Start();
            Icon_shotgun3.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }

        if (active_streetsub.activeSelf)
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


            streetsub_bool = true;
    

            exit_weapons();
            active_streetsub.SetActive(true);
            active_streetsub.GetComponent<streetsub>().Start();
            Icon_streetsub.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }
        if (active_sturmgewehr46.activeSelf)
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


            sturmgewehr46_bool = true;
        

            exit_weapons();
            active_sturmgewehr46.SetActive(true);
            active_sturmgewehr46.GetComponent<sturmgewehr46>().Start();
            Icon_sturmgewehr46.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }

        if (active_submachine5.activeSelf)
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


            submachine_bool = true;
        


            exit_weapons();
            active_submachine5.SetActive(true);
            active_submachine5.GetComponent<submachine5>().Start();
            Icon_submachine5.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }
        if (active_tarusk.activeSelf)
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


            tarusk_bool = true;
        

         

            exit_weapons();
            active_tarusk.SetActive(true);
            active_tarusk.GetComponent<tarusk>().Start();
            Icon_tarusk.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }






    }


    public float vertical_float_spread;
    public float horizontal_float_spread;

    public int player_health;


    public TextMesh ammo_gui;
    public TextMesh health_gui;

    

    void FixedUpdate()
    {

        walk_status();
        walk_execute();
        jumping();
        

        if (Input.GetKeyDown(KeyCode.E))
        {
            action_execute();
        }

        if (Input.GetButton("Fire2"))
        {
            aim_point.SetActive(false);
        }
        else
        {
            aim_point.SetActive(true);
        }

        health_gui.text = "HP : " + player_health;


        // showing magazine count, checking, if weapon OBJ, where the script is contained is active

        if (active_assault57.activeSelf)
        {
            ammo_gui.text = active_assault57.GetComponent<assault57>().magazine_current + " / " + active_assault57.GetComponent<assault57>().stored_bullets;
        }
        if (active_auge.activeSelf)
        {
            ammo_gui.text = active_auge.GetComponent<auge>().magazine_current + " / " + active_auge.GetComponent<auge>().stored_bullets;
        }
        if (active_blastset.activeSelf)
        {
            ammo_gui.text = active_blastset.GetComponent<blast_set>().magazine_current + " / " + active_blastset.GetComponent<blast_set>().magazine_current;
        }
        if (active_buzzsub.activeSelf)
        {
            ammo_gui.text = active_buzzsub.GetComponent<buzzsub>().magazine_current + " / " + active_buzzsub.GetComponent<buzzsub>().stored_bullets;
        }
        if (active_clusterShotgun.activeSelf)
        {
            ammo_gui.text = active_clusterShotgun.GetComponent<clusterShotgun>().magazine_current + " / " + active_clusterShotgun.GetComponent<clusterShotgun>().stored_bullets;
        }
        if (active_clustersub.activeSelf)
        {
            ammo_gui.text = active_clustersub.GetComponent<clustersub>().magazine_current + " / " + active_clustersub.GetComponent<clustersub>().stored_bullets;
        }
        if (active_crowbar.activeSelf)
        {
            ammo_gui.text = " & ";
        }
        if (active_fireaxe.activeSelf)
        {
            ammo_gui.text = " & ";
        }
        if (active_flamethrower.activeSelf)
        {
            ammo_gui.text = active_flamethrower.GetComponent<flamethrower>().magazine_current + " / " + active_flamethrower.GetComponent<flamethrower>().stored_bullets;
        }
        if (active_grenade.activeSelf)
        {
            ammo_gui.text = active_grenade.GetComponent<grenade>().magazine_current + " / " + active_grenade.GetComponent<grenade>().magazine_current;
        }
        if (active_grenade_launcher.activeSelf)
        {
            ammo_gui.text = active_grenade_launcher.GetComponent<grenade_launcher>().magazine_current + " / " + active_grenade_launcher.GetComponent<grenade_launcher>().stored_bullets;
        }
        if (active_hunterrifle.activeSelf)
        {
            ammo_gui.text = active_hunterrifle.GetComponent<hunter_rifle>().magazine_current + " / " + active_hunterrifle.GetComponent<hunter_rifle>().stored_bullets;
        }
        if (active_lock.activeSelf)
        {
            ammo_gui.text = active_lock.GetComponent<lock_>().magazine_current + " / " + active_lock.GetComponent<lock_>().stored_bullets;
        }
        if (active_machine_gun.activeSelf)
        {
            ammo_gui.text = active_machine_gun.GetComponent<machine_gun>().magazine_current + " / " + active_machine_gun.GetComponent<machine_gun>().stored_bullets;
        }

        if (active_mkb16.activeSelf)
        {
            ammo_gui.text = active_mkb16.GetComponent<mkb16>().magazine_current + " / " + active_mkb16.GetComponent<mkb16>().stored_bullets;
        }
        if (active_nsp.activeSelf)
        {
            ammo_gui.text = active_nsp.GetComponent<nsp>().magazine_current + " / " + active_nsp.GetComponent<nsp>().stored_bullets;
        }
        if (active_old_pistol.activeSelf)
        {
            ammo_gui.text = active_old_pistol.GetComponent<old_pistol>().magazine_current + " / " + active_old_pistol.GetComponent<old_pistol>().stored_bullets;
        }
        if (active_pistol9.activeSelf)
        {
            ammo_gui.text = active_pistol9.GetComponent<pistol9>().magazine_current + " / " + active_pistol9.GetComponent<pistol9>().stored_bullets;
        }
        if (active_pumpgun_a.activeSelf)
        {
            ammo_gui.text = active_pumpgun_a.GetComponent<pumpgun_a>().magazine_current + " / " + active_pumpgun_a.GetComponent<pumpgun_a>().stored_bullets;
        }
        if (active_revolver.activeSelf)
        {
            ammo_gui.text = active_revolver.GetComponent<revolver>().magazine_current + " / " + active_revolver.GetComponent<revolver>().stored_bullets;
        }
        if (active_rocket_launcher.activeSelf)
        {
            ammo_gui.text = active_rocket_launcher.GetComponent<rocket_launcher>().magazine_current + " / " + active_rocket_launcher.GetComponent<rocket_launcher>().stored_bullets;
        }
        if (active_rp9.activeSelf)
        {
            ammo_gui.text = active_rp9.GetComponent<rp9>().magazine_current + " / " + active_rp9.GetComponent<rp9>().stored_bullets;
        }
        if (active_russian_sniper.activeSelf)
        {
            ammo_gui.text = active_russian_sniper.GetComponent<russian_sniper>().magazine_current + " / " + active_russian_sniper.GetComponent<russian_sniper>().stored_bullets;
        }
        if (active_sce5.activeSelf)
        {
            ammo_gui.text = active_sce5.GetComponent<sce5>().magazine_current + " / " + active_sce5.GetComponent<sce5>().stored_bullets;
        }
        if (active_scorp6.activeSelf)
        {
            ammo_gui.text = active_scorp6.GetComponent<scorp6>().magazine_current + " / " + active_scorp6.GetComponent<scorp6>().stored_bullets;
        }
        if (active_shotgun3.activeSelf)
        {
            ammo_gui.text = active_shotgun3.GetComponent<shotgun3>().magazine_current + " / " + active_shotgun3.GetComponent<shotgun3>().stored_bullets;
        }
        if (active_streetsub.activeSelf)
        {
            ammo_gui.text = active_streetsub.GetComponent<streetsub>().magazine_current + " / " + active_streetsub.GetComponent<streetsub>().stored_bullets;
        }
        if (active_sturmgewehr46.activeSelf)
        {
            ammo_gui.text = active_sturmgewehr46.GetComponent<sturmgewehr46>().magazine_current + " / " + active_sturmgewehr46.GetComponent<sturmgewehr46>().stored_bullets;
        }
        if (active_submachine5.activeSelf)
        {
            ammo_gui.text = active_submachine5.GetComponent<submachine5>().magazine_current + " / " + active_submachine5.GetComponent<submachine5>().stored_bullets;
        }
        if (active_tarusk.activeSelf)
        {
            ammo_gui.text = active_tarusk.GetComponent<tarusk>().magazine_current + " / " + active_tarusk.GetComponent<tarusk>().stored_bullets;
        }



        if (Input.GetKeyDown(KeyCode.L))
        {
            Cursor.lockState = CursorLockMode.Locked;
           
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
          
            Cursor.lockState = CursorLockMode.None;
        }





    }






    private void LateUpdate()
    {
    
        aimming();
    }


   

    public GameObject vertical_aim_bone_default;

    public float min_angle;
    public float max_angle;

    public float vertical_speed;
    public float horizontal_speed;

    public float saved_roation_X;

    public void aimming()
    {


        float add_speed_aim;

        if (Input.GetButton("Fire2"))
        {

            // multiply this with the aimming speed, while aimming, the sensitiy is slower
            add_speed_aim = 0.5f;
        }
        else
        {

            add_speed_aim = 1f;
        }



        // adding recoil movement to the aimming
        float add_hor = horizontal_float_spread;
        horizontal_float_spread = 0;


        float add_ver = vertical_float_spread;
        vertical_float_spread = 0;




        transform.eulerAngles = new Vector3(transform.eulerAngles.x, (transform.eulerAngles.y + add_hor) + (Input.GetAxis("Mouse X") * add_speed_aim) * Time.deltaTime * horizontal_speed, transform.eulerAngles.z);


     
        Vector3 rot = new Vector3((saved_roation_X + add_ver) - (Input.GetAxis("Mouse Y")* add_speed_aim) * Time.deltaTime * vertical_speed, vertical_aim_bone_default.transform.eulerAngles.y, vertical_aim_bone_default.transform.eulerAngles.z);
        
        // limit of rotation at aimming
        rot.x = Mathf.Clamp(rot.x, min_angle,max_angle);
        // saving current value to stay at position and not beginning from zero
        saved_roation_X = rot.x;



        vertical_aim_bone_default.transform.eulerAngles = rot;
        
 


    }





    bool is_toggled;
    



    public Animator ani;
    public float walk_speed;
    public float run_speed;
    public float Duck_walk_speed;

    public CharacterController controller;

    float forward_back;
    float right_left;

    Vector3 moveDirection;



    public bool in_jump;


    public float jump_speed;

    public bool walking;
    public bool running;
    public bool walking_side;

    bool changed_state;
    public string state;
    public string old_state;


    public AudioSource walk_sound;

    public AudioClip walk_clip;
    public AudioClip run_clip;
    public AudioClip walk_side_clip;
    public AudioClip walk_duck_clip;


    public void walk_execute()
    {
        walking = false;
        running = false;
        walking_side = false;

        if (idle)
        {
            state = "idle";

            ani.SetInteger("legs", 0);
            walk_speed = 0;
            forward_back = 0;
            right_left = 0;

            walking = false;
            running = false;
        }
        

        if (forward)
        {
            state = "walk";

            ani.SetFloat("legs_speed", 1);
            ani.SetInteger("legs", 1);
            walk_speed = 250f;

            forward_back = 1.2f;
            right_left = 0;

            walking = true;
            running = false;
        }
        if (back)
        {
            state = "walk";

            ani.SetFloat("legs_speed", -1);
            ani.SetInteger("legs", 1);
            walk_speed = 250f;

            forward_back = -1.2f;
            right_left = 0;

            walking = true;
            running = false;
        }





        if (right )
        {
            state = "side_walk";

            ani.SetFloat("legs_speed", 1);// Animation speed of the legs, walking to side slow it down
            ani.SetInteger("legs", 2);
            walk_speed = 150f;
  
            right_left = 1;

            walking_side = true;
            walking = true;
            running = false;
        }
        if (left )
        {
            state = "side_walk";

            ani.SetFloat("legs_speed", -1);
            ani.SetInteger("legs", 2);
            walk_speed = 150f;
            right_left = -1;

            walking_side = true;
            walking = true;
            running = false;
        }





        if (forward_right)
        {
            state = "walk";

            ani.SetFloat("legs_speed", 2);
            ani.SetInteger("legs", 2);
            walk_speed = 150f;

            forward_back = 1;
            right_left = 1;

            walking = true;
            running = false;
        }
        if (forward_left)
        {
            state = "walk";

            ani.SetFloat("legs_speed", 2);
            ani.SetInteger("legs", 2);
            walk_speed = 150f;

            forward_back = 1;
            right_left = -1;

            walking = true;
            running = false;
        }





        if (back_right)
        {
            state = "walk";

            ani.SetFloat("legs_speed", 2);
            ani.SetInteger("legs", 2);
            walk_speed = 150f;

            forward_back = -1;
            right_left = 1;

            walking = true;
            running = false;
        }
        if (back_left)
        {
            state = "walk";

            ani.SetFloat("legs_speed", 2);
            ani.SetInteger("legs", 2);
            walk_speed = 150f;

            forward_back = -1;
            right_left = -1;

            walking = true;
            running = false;
        }

        if(run)
        {
            state = "run";

            ani.SetInteger("legs", 3);
            walk_speed = 400f;

            forward_back = 1.2f;
            right_left = 0;

            walking = false;
            running = true;
        }

        if(duck)
        {
            state = "idle";

            ani.SetInteger("legs", 5);
            ani.SetFloat("legs_speed", 0);
            walk_speed = 100;

            forward_back = 0;
            right_left = 0;

            walking = false;
            running = false;
        }

        if (duck_walk)
        {
            state = "duck_walk";

            ani.SetInteger("legs", 5);
            ani.SetFloat("legs_speed", 1);
            walk_speed = 100;

            forward_back = 1;
            right_left = 0;

            walking = true;
            running = false;
        }



         // Checking for state, if the state is not setted as the old state, will it change

        if (state == "idle" && old_state != "idle")
        {
            old_state = "idle";


           
            walk_sound.time = 0;
            walk_sound.Stop();
        }

        if (state == "walk" && old_state != "walk")
        {
            old_state = "walk";

           
                walk_sound.clip = walk_clip;

                walk_sound.time = 0;
                walk_sound.Play();
            

        }

        if (state == "run" && old_state != "run")
        {
            old_state = "run";
            
            
               
                walk_sound.clip = run_clip;
                walk_sound.time = 0;
                walk_sound.Play();
            

           
        }

        if (state == "side_walk" && old_state != "side_walk")
        {
            old_state = "side_walk";



            walk_sound.clip = walk_side_clip;
            walk_sound.time = 0;
            walk_sound.Play();



        }

        if (state == "duck_walk" && old_state != "duck_walk")
        {
            old_state = "duck_walk";



            walk_sound.clip = walk_duck_clip;
            walk_sound.time = 0;
            walk_sound.Play();



        }

        moveDirection = new Vector3(Vector3.forward.x * Time.deltaTime* forward_back* walk_speed, 0, Vector3.right.z * Time.deltaTime * forward_back * walk_speed);

        Vector3 FB = transform.TransformDirection(Vector3.forward *forward_back*walk_speed * Time.deltaTime);
        Vector3 RL = transform.TransformDirection(Vector3.right * right_left * walk_speed * Time.deltaTime);
        



        controller.SimpleMove(FB + RL);

      

        

       


    }

    public void jumping()
    {
        if (jump && controller.isGrounded)
        {
            // pressing space and adding jump speed to jump up, the force to push down is always


            jump_speed = 0.3f;

            transform.position = transform.position + new Vector3(0, 0.1f, 0);


        }

        if (!controller.isGrounded && jump)
        {


            jump_speed -= 0.01f;

            transform.Translate(new Vector3(0, jump_speed, 0));


            if (jump_speed < -0.5f)
            {
                jump_speed = -0.5f;
            }
        }
    }



    bool already_toggles_cam;
    public void walk_status()
    {
      

        // turing off all key status, to get a clear new one
        right = false;
        left = false;
        forward = false;
        forward_right = false;
        forward = false;
        forward_left = false;
        back = false;
        back_right = false;
        back = false;
        back_left = false;
        duck = false;
        duck_walk = false;
        jump = false;
        reload = false;
        run = false;


        if(Input.GetKeyDown(KeyCode.Q))
        {
            
            if (!cam_toggled  && !already_toggles_cam)
            {
                cam_toggled = true; already_toggles_cam = true; 
            }

            if (cam_toggled && !already_toggles_cam)
            {
                cam_toggled = false; already_toggles_cam = true;
            }

         
        }
        already_toggles_cam = false;



        // determine input from keys
        if (Input.GetKey(KeyCode.W))
        {
            Key_w = true;
        }
        else
        {
            Key_w = false;
        }

        if (Input.GetKey(KeyCode.S))
        {
            Key_s = true;
        }
        else
        {
            Key_s = false;
        }

        if (Input.GetKey(KeyCode.D))
        {
            Key_d = true;
        }
        else
        {
            Key_d = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            Key_a = true;
        }
        else
        {
            Key_a = false;
        }

        if (Input.GetKey(KeyCode.R))
        {
            key_reload = true;
        }
        else
        {
            key_reload = false;
        }

        if (Input.GetKey(KeyCode.C))
        {
            key_duck = true;
        }
        else
        {
            key_duck = false;
        }
        if(Input.GetKey(KeyCode.Space))
        {
            key_jump = true;
        }
        else
        {
            key_jump = false;
        }

        if(Input.GetKey(KeyCode.LeftShift))
        {
            key_run = true;
        }
        else
        {
            key_run = false;
        }

        // determine walk status to get one clear one to walk to
        if (Key_w)
        {
            forward = true;
        }
        if (Key_s)
        {
            back = true;
        }
        if (Key_d)
        {
            right = true;
        }
        if (Key_a)
        {
            left = true;
        }
        if(key_jump)
        {
            jump = true;
        }


        if (key_reload)
        {
            reload = true;
        }
        if (key_duck)
        {
            duck = true;
        }


        if (Key_w && Key_d)
        {
            forward = false;
            forward_right = true;
        }
        if (Key_w && Key_a)
        {
            forward = false;
            forward_left = true;
        }

       

        if (Key_s && Key_d)
        {
            back = false;
           
            back_right = true;
        }
        if (Key_s && Key_a)
        {
            back = false;
            back_left = true;
        }

    

        if (key_duck && !Key_w && !key_run)
        {
            right = false;
            left = false;


            forward = false;
            forward_right = false;

            forward = false;
            forward_left = false;

            back = false;
            back_right = false;

            back = false;
            back_left = false;
            key_run = false;

            duck = true;
            duck_walk = false;
        }
        if(key_duck && Key_w && !key_run)
        {
            right = false;
            left = false;


            forward = false;
            forward_right = false;

            forward = false;
            forward_left = false;

            back = false;
            back_right = false;

            back = false;
            back_left = false;

            duck = false;
            key_run = false;

            duck_walk = true;

        }
        if (!key_duck && !duck && !forward && !back && !right && !left && !forward_right && !forward_left && !back_right && !back_left)
        {
            right = false;
            left = false;


            forward = false;
            forward_right = false;

            forward = false;
            forward_left = false;

            back = false;
            back_right = false;

            back = false;
            back_left = false;

            duck = false;

            duck_walk = false;

            key_run = false;

            idle = true;

        }

        if(key_run && !Key_s && !Key_d && !Key_a)
        {
            right = false;
            left = false;


            forward = false;
            forward_right = false;

            forward = false;
            forward_left = false;

            back = false;
            back_right = false;

            back = false;
            back_left = false;

            duck = false;

            duck_walk = false;

            key_run = false;

            idle = false;

            run = true;
        }

      







    }



    public GameObject cam;


    public bool _3rd;

    public GameObject[] heads;

    public void head_3rd_status()
    {
        // turning off the heads for each Charakter
        if(_3rd)
        {
            foreach(GameObject g in heads)
            {
                g.SetActive(false);
            }
        }
        else
        {
            foreach (GameObject g in heads)
            {
                g.SetActive(true);
            }
        }
    }

    public Transform skin_folder;

    int active_skin_ID;
    public LayerMask mask;
    public void action_execute()
    {
        // shoot ray to checking for door as example to open
        RaycastHit hit;

        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, Mathf.Infinity, ~mask))
        {
           
            if(hit.collider.tag == "lever")
            {
                hit.transform.GetComponent<lever>().Input();
            }
            if(hit.collider.tag == "metall_door")
            {
             
                hit.transform.GetComponent<door>().door_execute();
            }
            if (hit.collider.tag == "wood_door")
            {

                hit.transform.GetComponent<door>().door_execute();
            }
            if (hit.collider.tag == "eq")
            {
                destroy = false;
                picking_up(hit.transform.GetComponent<equipment>().ID);

                

                if (destroy)
                {
                    Destroy(hit.transform.gameObject);
                }
            }
            if (hit.collider.tag == "vehicle")
            {
                skin_folder = gameObject.transform.Find("Polygon_FPS/charakters");


                for(int i =0;i<skin_folder.childCount;i++)
                {
                    if(skin_folder.GetChild(i).gameObject.activeSelf)
                    {
                        
                        active_skin_ID = i;
                        break;
                    }
                }

                hit.collider.gameObject.GetComponent<vehicle_enter>().send_enter_request(gameObject, active_skin_ID);
            }
            if(hit.collider.tag == "8x8")
            {
                skin_folder = gameObject.transform.Find("Polygon_FPS/charakters");


                for (int i = 0; i < skin_folder.childCount; i++)
                {
                    if (skin_folder.GetChild(i).gameObject.activeSelf)
                    {

                        active_skin_ID = i;
                        break;
                    }
                }


                hit.collider.gameObject.GetComponent<controll_8x8>().enter_vehicle(gameObject, active_skin_ID);


            }




        }




    }


   
   
    


    bool destroy;

    // objects to drop, if pciked an other scope up, to drop the current scope as example

    public GameObject lamp_a;
    public GameObject lamp_laser_a;
    public GameObject lamp_laser_b;
    public GameObject laser_a;

    public GameObject red_dot_a;
    public GameObject red_dot_b;
    public GameObject red_dot_c;
    public GameObject red_dot_d;
    public GameObject red_dot_e;

    public GameObject scope_a;
    public GameObject scope_b;
    public GameObject scope_c;

    public GameObject suppressor_a;
    public GameObject suppressor_clustersub;
    public GameObject suppressor_c;
    public GameObject suppressor_d;



    // turning on active weapon and setting up custom adjustments

    public GameObject drop_assault57;
    public GameObject drop_auge;
    public GameObject drop_blastset;
    public GameObject drop_buzzsub;
    public GameObject drop_clusterShotgun;
    public GameObject drop_clustersub;
    public GameObject drop_crowbar;
    public GameObject drop_fireaxe;
    public GameObject drop_flamethrower;
    public GameObject drop_grenade;
    public GameObject drop_grenade_launcher;
    public GameObject drop_hunterrifle;
    public GameObject drop_lock;
    public GameObject drop_machine_gun;
    public GameObject drop_mkb16;
    public GameObject drop_nsp;
    public GameObject drop_old_pistol;
    public GameObject drop_pistol9;
    public GameObject drop_pumpgun_a;
    public GameObject drop_revolver;
    public GameObject drop_rocket_launcher;
    public GameObject drop_rp9;
    public GameObject drop_russian_sniper;
    public GameObject drop_sce5;
    public GameObject drop_scorp6;
    public GameObject drop_shotgun3;
    public GameObject drop_streetsub;
    public GameObject drop_sturmgewehr46;
    public GameObject drop_submachine5;
    public GameObject drop_tarusk;


    // accessing all weapon scripts to controll the change

    public GameObject active_assault57;
    public GameObject active_auge;
    public GameObject active_blastset;
    public GameObject active_buzzsub;
    public GameObject active_clusterShotgun;
    public GameObject active_clustersub;
    public GameObject active_crowbar;
    public GameObject active_fireaxe;
    public GameObject active_flamethrower;
    public GameObject active_grenade;
    public GameObject active_grenade_launcher;
    public GameObject active_hunterrifle;
    public GameObject active_lock;
    public GameObject active_machine_gun;
    public GameObject active_mkb16;
    public GameObject active_nsp;
    public GameObject active_old_pistol;
    public GameObject active_pistol9;
    public GameObject active_pumpgun_a;
    public GameObject active_revolver;
    public GameObject active_rocket_launcher;
    public GameObject active_rp9;
    public GameObject active_russian_sniper;
    public GameObject active_sce5;
    public GameObject active_scorp6;
    public GameObject active_shotgun3;
    public GameObject active_streetsub;
    public GameObject active_sturmgewehr46;
    public GameObject active_submachine5;
    public GameObject active_tarusk;


    // Icons of the weapons

    public GameObject Icon_assault57;
    public GameObject Icon_auge;
    public GameObject Icon_blastset;
    public GameObject Icon_buzzsub;
    public GameObject Icon_clusterShotgun;
    public GameObject Icon_clustersub;
    public GameObject Icon_crowbar;
    public GameObject Icon_fireaxe;
    public GameObject Icon_flamethrower;
    public GameObject Icon_grenade;
    public GameObject Icon_grenade_launcher;
    public GameObject Icon_hunterrifle;
    public GameObject Icon_lock;
    public GameObject Icon_machine_gun;
    public GameObject Icon_mkb16;
    public GameObject Icon_nsp;
    public GameObject Icon_old_pistol;
    public GameObject Icon_pistol9;
    public GameObject Icon_pumpgun_a;
    public GameObject Icon_revolver;
    public GameObject Icon_rocket_launcher;
    public GameObject Icon_rp9;
    public GameObject Icon_russian_sniper;
    public GameObject Icon_sce5;
    public GameObject Icon_scorp6;
    public GameObject Icon_shotgun3;
    public GameObject Icon_streetsub;
    public GameObject Icon_sturmgewehr46;
    public GameObject Icon_submachine5;
    public GameObject Icon_tarusk;





    public GameObject assault57_obj;
    public bool assault57_bool;

  
    public GameObject auge_obj;
    public bool auge_bool;

   
    public GameObject buzzsub_obj;
    public bool buzzsub_bool;

   
    public GameObject clusterSub_obj;
    public bool clusterSub_bool;

 
    public GameObject lock_obj;
    public bool lock_bool;

    
    public GameObject machineGun_obj;
    public bool machineGun_bool;

   
    public GameObject mkb16_obj;
    public bool mkb16_bool;

   
    public GameObject nsp_obj;
    public bool nsp_bool;


    public GameObject old_pistol_obj;
    public bool old_pistol_bool;


  
    public GameObject pistol9_obj;
    public bool pistol9_bool;

   
    public GameObject pumpgun_a_obj;
    public bool pumpgun_a_bool;


    public GameObject rp9_obj;
    public bool rp9_bool;


    public GameObject sce5_obj;
    public bool sce5_bool;


    public GameObject scorp6_obj;
    public bool scorp6_bool;


    public GameObject streetsub_obj;
    public bool streetsub_bool;


    public GameObject sturmgewehr46_obj;
    public bool sturmgewehr46_bool;


    public GameObject submachine_obj;
    public bool submachine_bool;


    public GameObject tarusk_obj;
    public bool tarusk_bool;



    // right                     laser_a , lamp_laser_a 
    // left                      lamp_a  , lamp_laser_b  

    public AudioClip click;
    public GameObject animator_obj;
    public void picking_up(string which)
    {
        // checking which weapon is in use
        // checking, which equipment picked up, to turn off and on the new on
        if(assault57_bool)
        {
            

            // checking, what you picked up and determine it with a string check and turning off other equipment, if required to make the place for the new one free
         


            // left side of holder
            if (which == "lamp_a")
            {

                AudioSource.PlayClipAtPoint(click, transform.position);
                assault57_obj.GetComponent<assault57>().Equipment_holder_b_bool = true;
                destroy = true;

                assault57_obj.GetComponent<assault57>().lamp_a_bool = true;

                // same position, turning lamp_laser_b off

                if(assault57_obj.GetComponent<assault57>().lamp_laser_b_bool)
                {
                    Drop("lamp_laser_b");
                }


                assault57_obj.GetComponent<assault57>().lamp_laser_b_bool = false;

                assault57_obj.GetComponent<assault57>().change_equipment();


            }
            if (which == "lamp_laser_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);
                assault57_obj.GetComponent<assault57>().Equipment_holder_b_bool = true;
                destroy = true;

                assault57_obj.GetComponent<assault57>().lamp_laser_b_bool = true;

                // same position, turning lamp_laser_b off

                if (assault57_obj.GetComponent<assault57>().lamp_a_bool)
                {
                    Drop("lamp_a");

                    assault57_obj.GetComponent<assault57>().lamp_a_bool = false;
                }


                

                assault57_obj.GetComponent<assault57>().change_equipment();


            }


            // right side of holder
            if (which == "laser_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);
                assault57_obj.GetComponent<assault57>().Equipment_holder_b_bool = true;
                destroy = true;

                assault57_obj.GetComponent<assault57>().laser_a_bool = true;



                if (assault57_obj.GetComponent<assault57>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_a");

                    assault57_obj.GetComponent<assault57>().lamp_laser_a_bool = false;
                }




                assault57_obj.GetComponent<assault57>().change_equipment();



            }
            if (which == "lamp_laser_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);
                assault57_obj.GetComponent<assault57>().Equipment_holder_b_bool = true;
                destroy = true;

                assault57_obj.GetComponent<assault57>().lamp_laser_a_bool = true;



                if (assault57_obj.GetComponent<assault57>().laser_a_bool)
                {
                    Drop("lamp_laser_a");

                    assault57_obj.GetComponent<assault57>().laser_a_bool = false;
                }




                assault57_obj.GetComponent<assault57>().change_equipment();



            }


            // changing scopes
            if (which == "red_dot_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (assault57_obj.GetComponent<assault57>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    assault57_obj.GetComponent<assault57>().red_dot_a_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    assault57_obj.GetComponent<assault57>().red_dot_b_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    assault57_obj.GetComponent<assault57>().red_dot_c_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    assault57_obj.GetComponent<assault57>().red_dot_d_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    assault57_obj.GetComponent<assault57>().red_dot_e_bool = false;
                }

                

                if (assault57_obj.GetComponent<assault57>().scope_a_bool)
                {
                    Drop("scope_a");
                    assault57_obj.GetComponent<assault57>().scope_a_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().scope_b_bool)
                {
                    Drop("scope_b");
                    assault57_obj.GetComponent<assault57>().scope_b_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().scope_c_bool)
                {
                    Drop("scope_c");
                    assault57_obj.GetComponent<assault57>().scope_c_bool = false;
                }

                Debug.Log("worked");

                assault57_obj.GetComponent<assault57>().Equipment_holder_a_bool = true;

                assault57_obj.GetComponent<assault57>().red_dot_a_bool = true;





                assault57_obj.GetComponent<assault57>().change_equipment();


            }
            if (which == "red_dot_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (assault57_obj.GetComponent<assault57>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    assault57_obj.GetComponent<assault57>().red_dot_a_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    assault57_obj.GetComponent<assault57>().red_dot_b_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    assault57_obj.GetComponent<assault57>().red_dot_c_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    assault57_obj.GetComponent<assault57>().red_dot_d_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    assault57_obj.GetComponent<assault57>().red_dot_e_bool = false;
                }



                if (assault57_obj.GetComponent<assault57>().scope_a_bool)
                {
                    Drop("scope_a");
                    assault57_obj.GetComponent<assault57>().scope_a_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().scope_b_bool)
                {
                    Drop("scope_b");
                    assault57_obj.GetComponent<assault57>().scope_b_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().scope_c_bool)
                {
                    Drop("scope_c");
                    assault57_obj.GetComponent<assault57>().scope_c_bool = false;
                }


                assault57_obj.GetComponent<assault57>().Equipment_holder_a_bool = true;

                assault57_obj.GetComponent<assault57>().red_dot_b_bool = true;





                assault57_obj.GetComponent<assault57>().change_equipment();


            }
            if (which == "red_dot_c")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (assault57_obj.GetComponent<assault57>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    assault57_obj.GetComponent<assault57>().red_dot_a_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    assault57_obj.GetComponent<assault57>().red_dot_b_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    assault57_obj.GetComponent<assault57>().red_dot_c_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    assault57_obj.GetComponent<assault57>().red_dot_d_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    assault57_obj.GetComponent<assault57>().red_dot_e_bool = false;
                }



                if (assault57_obj.GetComponent<assault57>().scope_a_bool)
                {
                    Drop("scope_a");
                    assault57_obj.GetComponent<assault57>().scope_a_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().scope_b_bool)
                {
                    Drop("scope_b");
                    assault57_obj.GetComponent<assault57>().scope_b_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().scope_c_bool)
                {
                    Drop("scope_c");
                    assault57_obj.GetComponent<assault57>().scope_c_bool = false;
                }


                assault57_obj.GetComponent<assault57>().Equipment_holder_a_bool = true;

                assault57_obj.GetComponent<assault57>().red_dot_c_bool = true;





                assault57_obj.GetComponent<assault57>().change_equipment();


            }
            if (which == "red_dot_d")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (assault57_obj.GetComponent<assault57>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    assault57_obj.GetComponent<assault57>().red_dot_a_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    assault57_obj.GetComponent<assault57>().red_dot_b_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    assault57_obj.GetComponent<assault57>().red_dot_c_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    assault57_obj.GetComponent<assault57>().red_dot_d_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    assault57_obj.GetComponent<assault57>().red_dot_e_bool = false;
                }



                if (assault57_obj.GetComponent<assault57>().scope_a_bool)
                {
                    Drop("scope_a");
                    assault57_obj.GetComponent<assault57>().scope_a_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().scope_b_bool)
                {
                    Drop("scope_b");
                    assault57_obj.GetComponent<assault57>().scope_b_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().scope_c_bool)
                {
                    Drop("scope_c");
                    assault57_obj.GetComponent<assault57>().scope_c_bool = false;
                }


                assault57_obj.GetComponent<assault57>().Equipment_holder_a_bool = true;

                assault57_obj.GetComponent<assault57>().red_dot_d_bool = true;





                assault57_obj.GetComponent<assault57>().change_equipment();


            }
            if (which == "red_dot_e")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (assault57_obj.GetComponent<assault57>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    assault57_obj.GetComponent<assault57>().red_dot_a_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    assault57_obj.GetComponent<assault57>().red_dot_b_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    assault57_obj.GetComponent<assault57>().red_dot_c_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    assault57_obj.GetComponent<assault57>().red_dot_d_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    assault57_obj.GetComponent<assault57>().red_dot_e_bool = false;
                }



                if (assault57_obj.GetComponent<assault57>().scope_a_bool)
                {
                    Drop("scope_a");
                    assault57_obj.GetComponent<assault57>().scope_a_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().scope_b_bool)
                {
                    Drop("scope_b");
                    assault57_obj.GetComponent<assault57>().scope_b_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().scope_c_bool)
                {
                    Drop("scope_c");
                    assault57_obj.GetComponent<assault57>().scope_c_bool = false;
                }


                assault57_obj.GetComponent<assault57>().Equipment_holder_a_bool = true;

                assault57_obj.GetComponent<assault57>().red_dot_e_bool = true;





                assault57_obj.GetComponent<assault57>().change_equipment();


            }
            if (which == "scope_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (assault57_obj.GetComponent<assault57>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    assault57_obj.GetComponent<assault57>().red_dot_a_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    assault57_obj.GetComponent<assault57>().red_dot_b_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    assault57_obj.GetComponent<assault57>().red_dot_c_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    assault57_obj.GetComponent<assault57>().red_dot_d_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    assault57_obj.GetComponent<assault57>().red_dot_e_bool = false;
                }



                if (assault57_obj.GetComponent<assault57>().scope_a_bool)
                {
                    Drop("scope_a");
                    assault57_obj.GetComponent<assault57>().scope_a_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().scope_b_bool)
                {
                    Drop("scope_b");
                    assault57_obj.GetComponent<assault57>().scope_b_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().scope_c_bool)
                {
                    Drop("scope_c");
                    assault57_obj.GetComponent<assault57>().scope_c_bool = false;
                }


                assault57_obj.GetComponent<assault57>().Equipment_holder_a_bool = true;
                
                assault57_obj.GetComponent<assault57>().scope_a_bool = true;





                assault57_obj.GetComponent<assault57>().change_equipment();


            }
            if (which == "scope_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (assault57_obj.GetComponent<assault57>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    assault57_obj.GetComponent<assault57>().red_dot_a_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    assault57_obj.GetComponent<assault57>().red_dot_b_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    assault57_obj.GetComponent<assault57>().red_dot_c_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    assault57_obj.GetComponent<assault57>().red_dot_d_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    assault57_obj.GetComponent<assault57>().red_dot_e_bool = false;
                }



                if (assault57_obj.GetComponent<assault57>().scope_a_bool)
                {
                    Drop("scope_a");
                    assault57_obj.GetComponent<assault57>().scope_a_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().scope_b_bool)
                {
                    Drop("scope_b");
                    assault57_obj.GetComponent<assault57>().scope_b_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().scope_c_bool)
                {
                    Drop("scope_c");
                    assault57_obj.GetComponent<assault57>().scope_c_bool = false;
                }


                assault57_obj.GetComponent<assault57>().Equipment_holder_a_bool = true;

                assault57_obj.GetComponent<assault57>().scope_b_bool = true;





                assault57_obj.GetComponent<assault57>().change_equipment();


            }
            if (which == "scope_c")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (assault57_obj.GetComponent<assault57>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    assault57_obj.GetComponent<assault57>().red_dot_a_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    assault57_obj.GetComponent<assault57>().red_dot_b_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    assault57_obj.GetComponent<assault57>().red_dot_c_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    assault57_obj.GetComponent<assault57>().red_dot_d_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    assault57_obj.GetComponent<assault57>().red_dot_e_bool = false;
                }



                if (assault57_obj.GetComponent<assault57>().scope_a_bool)
                {
                    Drop("scope_a");
                    assault57_obj.GetComponent<assault57>().scope_a_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().scope_b_bool)
                {
                    Drop("scope_b");
                    assault57_obj.GetComponent<assault57>().scope_b_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().scope_c_bool)
                {
                    Drop("scope_c");
                    assault57_obj.GetComponent<assault57>().scope_c_bool = false;
                }


                assault57_obj.GetComponent<assault57>().Equipment_holder_a_bool = true;

                assault57_obj.GetComponent<assault57>().scope_c_bool = true;





                assault57_obj.GetComponent<assault57>().change_equipment();


            }

           

            if (which == "suppressor_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);


                destroy = true;


                if (assault57_obj.GetComponent<assault57>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    assault57_obj.GetComponent<assault57>().suppressor_a_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    assault57_obj.GetComponent<assault57>().suppressor_c_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    assault57_obj.GetComponent<assault57>().suppressor_d_bool = false;
                }

                assault57_obj.GetComponent<assault57>().suppressor_a_bool = true;

                assault57_obj.GetComponent<assault57>().change_equipment();



            }
           // suppresor b is just for one weapon useable
            if (which == "suppressor_c")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);




                destroy = true;

                if (assault57_obj.GetComponent<assault57>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    assault57_obj.GetComponent<assault57>().suppressor_a_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    assault57_obj.GetComponent<assault57>().suppressor_c_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    assault57_obj.GetComponent<assault57>().suppressor_d_bool = false;
                }

                assault57_obj.GetComponent<assault57>().suppressor_c_bool = true;

                assault57_obj.GetComponent<assault57>().change_equipment();



            }
            if (which == "suppressor_d")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);


                destroy = true;


                if (assault57_obj.GetComponent<assault57>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    assault57_obj.GetComponent<assault57>().suppressor_a_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    assault57_obj.GetComponent<assault57>().suppressor_c_bool = false;
                }

                if (assault57_obj.GetComponent<assault57>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    assault57_obj.GetComponent<assault57>().suppressor_d_bool = false;
                }

                assault57_obj.GetComponent<assault57>().suppressor_d_bool = true;

                assault57_obj.GetComponent<assault57>().change_equipment();



            }

        }
        if(auge_bool)
        {
            // checking, what you picked up and determine it with a string check and turning off other equipment, if required to make the place for the new one free
            // left side of holder
            if (which == "lamp_a")
            {

                AudioSource.PlayClipAtPoint(click, transform.position);
              


                auge_obj.GetComponent<auge>().lamp_a_bool = true;

                // same position, turning lamp_laser_b off

                if (auge_obj.GetComponent<auge>().lamp_laser_b_bool)
                {
                    Drop("lamp_laser_b");
                }


                auge_obj.GetComponent<auge>().lamp_laser_b_bool = false;

                auge_obj.GetComponent<auge>().change_equipment();
                destroy = true;

            }
            if (which == "lamp_laser_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);
             


                auge_obj.GetComponent<auge>().lamp_laser_b_bool = true;

                // same position, turning lamp_laser_b off

                if (auge_obj.GetComponent<auge>().lamp_a_bool)
                {
                    Drop("lamp_a");

                    auge_obj.GetComponent<auge>().lamp_a_bool = false;
                }




                auge_obj.GetComponent<auge>().change_equipment();

                destroy = true;
            }


            // right side of holder
            if (which == "laser_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);
             


                auge_obj.GetComponent<auge>().laser_a_bool = true;



                if (auge_obj.GetComponent<auge>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_a");

                    auge_obj.GetComponent<auge>().lamp_laser_a_bool = false;
                }




                auge_obj.GetComponent<auge>().change_equipment();
                destroy = true;


            }
            if (which == "lamp_laser_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);
               


                auge_obj.GetComponent<auge>().lamp_laser_a_bool = true;



                if (auge_obj.GetComponent<auge>().laser_a_bool)
                {
                    Drop("lamp_laser_a");

                    auge_obj.GetComponent<auge>().laser_a_bool = false;
                }




                auge_obj.GetComponent<auge>().change_equipment();

                destroy = true;

            }





            if (which == "suppressor_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);





                if (auge_obj.GetComponent<auge>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    auge_obj.GetComponent<auge>().suppressor_a_bool = false;
                }

                if (auge_obj.GetComponent<auge>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    auge_obj.GetComponent<auge>().suppressor_c_bool = false;
                }

                if (auge_obj.GetComponent<auge>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    auge_obj.GetComponent<auge>().suppressor_d_bool = false;
                }

                auge_obj.GetComponent<auge>().suppressor_a_bool = true;

                auge_obj.GetComponent<auge>().change_equipment();

                destroy = true;

            }
            // suppresor b is just for one weapon useable
            if (which == "suppressor_c")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);






                if (auge_obj.GetComponent<auge>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    auge_obj.GetComponent<auge>().suppressor_a_bool = false;
                }

                if (auge_obj.GetComponent<auge>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    auge_obj.GetComponent<auge>().suppressor_c_bool = false;
                }

                if (auge_obj.GetComponent<auge>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    auge_obj.GetComponent<auge>().suppressor_d_bool = false;
                }

                auge_obj.GetComponent<auge>().suppressor_c_bool = true;

                auge_obj.GetComponent<auge>().change_equipment();

                destroy = true;

            }
            if (which == "suppressor_d")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);





                if (auge_obj.GetComponent<auge>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    auge_obj.GetComponent<auge>().suppressor_a_bool = false;
                }

                if (auge_obj.GetComponent<auge>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    auge_obj.GetComponent<auge>().suppressor_c_bool = false;
                }

                if (auge_obj.GetComponent<auge>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    auge_obj.GetComponent<auge>().suppressor_d_bool = false;
                }

                auge_obj.GetComponent<auge>().suppressor_d_bool = true;

                auge_obj.GetComponent<auge>().change_equipment();


                destroy = true;
            }
        }
        if(buzzsub_bool)
        {


            // checking, what you picked up and determine it with a string check and turning off other equipment, if required to make the place for the new one free


            if (which == "lamp_a")
            {

                AudioSource.PlayClipAtPoint(click, transform.position);



              

                // same position, turning lamp_laser_b off

                if (buzzsub_obj.GetComponent<buzzsub>().laser_a_bool)
                {
                    Drop("lamp_laser_a");

                    buzzsub_obj.GetComponent<buzzsub>().laser_a_bool = false;
                }
                if (buzzsub_obj.GetComponent<buzzsub>().lamp_laser_a_bool)
                {
                    Drop("laser_a");

                    buzzsub_obj.GetComponent<buzzsub>().lamp_laser_a_bool = false;
                }
                if (buzzsub_obj.GetComponent<buzzsub>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_b");
                }
                if (buzzsub_obj.GetComponent<buzzsub>().lamp_laser_a_bool)
                {
                    Drop("lamp_a");
                }


                buzzsub_obj.GetComponent<buzzsub>().lamp_laser_a_bool = false;
                buzzsub_obj.GetComponent<buzzsub>().lamp_laser_b_bool = false;
                buzzsub_obj.GetComponent<buzzsub>().laser_a_bool = false;

                buzzsub_obj.GetComponent<buzzsub>().lamp_a_bool = true;

                buzzsub_obj.GetComponent<buzzsub>().change_equipment();

                destroy = true;
            }
            if (which == "lamp_laser_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);
     


              

                // same position, turning lamp_laser_b off

                if (buzzsub_obj.GetComponent<buzzsub>().laser_a_bool)
                {
                    Drop("lamp_laser_a");

                    buzzsub_obj.GetComponent<buzzsub>().laser_a_bool = false;
                }
                if (buzzsub_obj.GetComponent<buzzsub>().lamp_laser_a_bool)
                {
                    Drop("laser_a");

                    buzzsub_obj.GetComponent<buzzsub>().lamp_laser_a_bool = false;
                }
                if (buzzsub_obj.GetComponent<buzzsub>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_b");
                }
                if (buzzsub_obj.GetComponent<buzzsub>().lamp_laser_a_bool)
                {
                    Drop("lamp_a");
                }

                buzzsub_obj.GetComponent<buzzsub>().lamp_laser_a_bool = false;
                buzzsub_obj.GetComponent<buzzsub>().lamp_a_bool = false;
                buzzsub_obj.GetComponent<buzzsub>().laser_a_bool = false;

                buzzsub_obj.GetComponent<buzzsub>().lamp_laser_b_bool = true;

                buzzsub_obj.GetComponent<buzzsub>().change_equipment();

                destroy = true;
            }

            if (which == "laser_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);
               


              



                if (buzzsub_obj.GetComponent<buzzsub>().laser_a_bool)
                {
                    Drop("lamp_laser_a");

                    buzzsub_obj.GetComponent<buzzsub>().laser_a_bool = false;
                }
                if (buzzsub_obj.GetComponent<buzzsub>().lamp_laser_a_bool)
                {
                    Drop("laser_a");

                    buzzsub_obj.GetComponent<buzzsub>().lamp_laser_a_bool = false;
                }
                if (buzzsub_obj.GetComponent<buzzsub>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_b");
                }
                if (buzzsub_obj.GetComponent<buzzsub>().lamp_laser_a_bool)
                {
                    Drop("lamp_a");
                }


                buzzsub_obj.GetComponent<buzzsub>().lamp_laser_a_bool = false;
                buzzsub_obj.GetComponent<buzzsub>().lamp_laser_b_bool = false;
                buzzsub_obj.GetComponent<buzzsub>().lamp_a_bool = false;

                buzzsub_obj.GetComponent<buzzsub>().laser_a_bool = true;

                buzzsub_obj.GetComponent<buzzsub>().change_equipment();

                destroy = true;

            }
            if (which == "lamp_laser_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);
         


                



                if (buzzsub_obj.GetComponent<buzzsub>().laser_a_bool)
                {
                    Drop("lamp_laser_a");

                    buzzsub_obj.GetComponent<buzzsub>().laser_a_bool = false;
                }
                if (buzzsub_obj.GetComponent<buzzsub>().lamp_laser_a_bool)
                {
                    Drop("laser_a");

                    buzzsub_obj.GetComponent<buzzsub>().lamp_laser_a_bool = false;
                }
                if (buzzsub_obj.GetComponent<buzzsub>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_b");
                }
                if (buzzsub_obj.GetComponent<buzzsub>().lamp_laser_a_bool)
                {
                    Drop("lamp_a");
                }


                buzzsub_obj.GetComponent<buzzsub>().laser_a_bool = false;
                buzzsub_obj.GetComponent<buzzsub>().lamp_laser_b_bool = false;
                buzzsub_obj.GetComponent<buzzsub>().lamp_a_bool = false;

                buzzsub_obj.GetComponent<buzzsub>().lamp_laser_a_bool = true;

                buzzsub_obj.GetComponent<buzzsub>().change_equipment();

                destroy = true;

            }



            // changing scopes
            if (which == "red_dot_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);



                // checking, droping and turning off other scopes


                if (buzzsub_obj.GetComponent<buzzsub>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    buzzsub_obj.GetComponent<buzzsub>().red_dot_a_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    buzzsub_obj.GetComponent<buzzsub>().red_dot_b_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    buzzsub_obj.GetComponent<buzzsub>().red_dot_c_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    buzzsub_obj.GetComponent<buzzsub>().red_dot_d_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    buzzsub_obj.GetComponent<buzzsub>().red_dot_e_bool = false;
                }



                if (buzzsub_obj.GetComponent<buzzsub>().scope_a_bool)
                {
                    Drop("scope_a");
                    buzzsub_obj.GetComponent<buzzsub>().scope_a_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().scope_b_bool)
                {
                    Drop("scope_b");
                    buzzsub_obj.GetComponent<buzzsub>().scope_b_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().scope_c_bool)
                {
                    Drop("scope_c");
                    buzzsub_obj.GetComponent<buzzsub>().scope_c_bool = false;
                }

         

      

                buzzsub_obj.GetComponent<buzzsub>().red_dot_a_bool = true;





                buzzsub_obj.GetComponent<buzzsub>().change_equipment();
                destroy = true;

            }
            if (which == "red_dot_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);



                // checking, droping and turning off other scopes


                if (buzzsub_obj.GetComponent<buzzsub>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    buzzsub_obj.GetComponent<buzzsub>().red_dot_a_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    buzzsub_obj.GetComponent<buzzsub>().red_dot_b_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    buzzsub_obj.GetComponent<buzzsub>().red_dot_c_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    buzzsub_obj.GetComponent<buzzsub>().red_dot_d_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    buzzsub_obj.GetComponent<buzzsub>().red_dot_e_bool = false;
                }



                if (buzzsub_obj.GetComponent<buzzsub>().scope_a_bool)
                {
                    Drop("scope_a");
                    buzzsub_obj.GetComponent<buzzsub>().scope_a_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().scope_b_bool)
                {
                    Drop("scope_b");
                    buzzsub_obj.GetComponent<buzzsub>().scope_b_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().scope_c_bool)
                {
                    Drop("scope_c");
                    buzzsub_obj.GetComponent<buzzsub>().scope_c_bool = false;
                }



                buzzsub_obj.GetComponent<buzzsub>().red_dot_b_bool = true;





                buzzsub_obj.GetComponent<buzzsub>().change_equipment();
                destroy = true;

            }
            if (which == "red_dot_c")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);



                // checking, droping and turning off other scopes


                if (buzzsub_obj.GetComponent<buzzsub>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    buzzsub_obj.GetComponent<buzzsub>().red_dot_a_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    buzzsub_obj.GetComponent<buzzsub>().red_dot_b_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    buzzsub_obj.GetComponent<buzzsub>().red_dot_c_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    buzzsub_obj.GetComponent<buzzsub>().red_dot_d_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    buzzsub_obj.GetComponent<buzzsub>().red_dot_e_bool = false;
                }



                if (buzzsub_obj.GetComponent<buzzsub>().scope_a_bool)
                {
                    Drop("scope_a");
                    buzzsub_obj.GetComponent<buzzsub>().scope_a_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().scope_b_bool)
                {
                    Drop("scope_b");
                    buzzsub_obj.GetComponent<buzzsub>().scope_b_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().scope_c_bool)
                {
                    Drop("scope_c");
                    buzzsub_obj.GetComponent<buzzsub>().scope_c_bool = false;
                }



                buzzsub_obj.GetComponent<buzzsub>().red_dot_c_bool = true;





                buzzsub_obj.GetComponent<buzzsub>().change_equipment();
                destroy = true;

            }
            if (which == "red_dot_d")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);



                // checking, droping and turning off other scopes


                if (buzzsub_obj.GetComponent<buzzsub>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    buzzsub_obj.GetComponent<buzzsub>().red_dot_a_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    buzzsub_obj.GetComponent<buzzsub>().red_dot_b_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    buzzsub_obj.GetComponent<buzzsub>().red_dot_c_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    buzzsub_obj.GetComponent<buzzsub>().red_dot_d_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    buzzsub_obj.GetComponent<buzzsub>().red_dot_e_bool = false;
                }



                if (buzzsub_obj.GetComponent<buzzsub>().scope_a_bool)
                {
                    Drop("scope_a");
                    buzzsub_obj.GetComponent<buzzsub>().scope_a_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().scope_b_bool)
                {
                    Drop("scope_b");
                    buzzsub_obj.GetComponent<buzzsub>().scope_b_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().scope_c_bool)
                {
                    Drop("scope_c");
                    buzzsub_obj.GetComponent<buzzsub>().scope_c_bool = false;
                }


                

                buzzsub_obj.GetComponent<buzzsub>().red_dot_d_bool = true;





                buzzsub_obj.GetComponent<buzzsub>().change_equipment();
                destroy = true;

            }
            if (which == "red_dot_e")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);



                // checking, droping and turning off other scopes


                if (buzzsub_obj.GetComponent<buzzsub>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    buzzsub_obj.GetComponent<buzzsub>().red_dot_a_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    buzzsub_obj.GetComponent<buzzsub>().red_dot_b_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    buzzsub_obj.GetComponent<buzzsub>().red_dot_c_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    buzzsub_obj.GetComponent<buzzsub>().red_dot_d_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    buzzsub_obj.GetComponent<buzzsub>().red_dot_e_bool = false;
                }



                if (buzzsub_obj.GetComponent<buzzsub>().scope_a_bool)
                {
                    Drop("scope_a");
                    buzzsub_obj.GetComponent<buzzsub>().scope_a_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().scope_b_bool)
                {
                    Drop("scope_b");
                    buzzsub_obj.GetComponent<buzzsub>().scope_b_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().scope_c_bool)
                {
                    Drop("scope_c");
                    buzzsub_obj.GetComponent<buzzsub>().scope_c_bool = false;
                }


             

                buzzsub_obj.GetComponent<buzzsub>().red_dot_e_bool = true;





                buzzsub_obj.GetComponent<buzzsub>().change_equipment();
                destroy = true;

            }
            if (which == "scope_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);



                // checking, droping and turning off other scopes


                if (buzzsub_obj.GetComponent<buzzsub>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    buzzsub_obj.GetComponent<buzzsub>().red_dot_a_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    buzzsub_obj.GetComponent<buzzsub>().red_dot_b_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    buzzsub_obj.GetComponent<buzzsub>().red_dot_c_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    buzzsub_obj.GetComponent<buzzsub>().red_dot_d_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    buzzsub_obj.GetComponent<buzzsub>().red_dot_e_bool = false;
                }



                if (buzzsub_obj.GetComponent<buzzsub>().scope_a_bool)
                {
                    Drop("scope_a");
                    buzzsub_obj.GetComponent<buzzsub>().scope_a_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().scope_b_bool)
                {
                    Drop("scope_b");
                    buzzsub_obj.GetComponent<buzzsub>().scope_b_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().scope_c_bool)
                {
                    Drop("scope_c");
                    buzzsub_obj.GetComponent<buzzsub>().scope_c_bool = false;
                }


            

                buzzsub_obj.GetComponent<buzzsub>().scope_a_bool = true;





                buzzsub_obj.GetComponent<buzzsub>().change_equipment();


            }
            if (which == "scope_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);



                // checking, droping and turning off other scopes


                if (buzzsub_obj.GetComponent<buzzsub>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    buzzsub_obj.GetComponent<buzzsub>().red_dot_a_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    buzzsub_obj.GetComponent<buzzsub>().red_dot_b_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    buzzsub_obj.GetComponent<buzzsub>().red_dot_c_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    buzzsub_obj.GetComponent<buzzsub>().red_dot_d_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    buzzsub_obj.GetComponent<buzzsub>().red_dot_e_bool = false;
                }



                if (buzzsub_obj.GetComponent<buzzsub>().scope_a_bool)
                {
                    Drop("scope_a");
                    buzzsub_obj.GetComponent<buzzsub>().scope_a_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().scope_b_bool)
                {
                    Drop("scope_b");
                    buzzsub_obj.GetComponent<buzzsub>().scope_b_bool = false;
                }

                if (buzzsub_obj.GetComponent<buzzsub>().scope_c_bool)
                {
                    Drop("scope_c");
                    buzzsub_obj.GetComponent<buzzsub>().scope_c_bool = false;
                }


             

                buzzsub_obj.GetComponent<buzzsub>().scope_b_bool = true;





                buzzsub_obj.GetComponent<buzzsub>().change_equipment();
                destroy = true;

            }
            // scope c to big for the buzzsub


            // already suppresor on the gun

        }
        if (clusterSub_bool)
        {


            // checking, what you picked up and determine it with a string check and turning off other equipment, if required to make the place for the new one free


            if (which == "lamp_a")
            {

                AudioSource.PlayClipAtPoint(click, transform.position);





                // same position, turning lamp_laser_b off

                if (clusterSub_obj.GetComponent<clustersub>().laser_a_bool)
                {
                    Drop("lamp_laser_a");

                    buzzsub_obj.GetComponent<clustersub>().laser_a_bool = false;
                }
                if (clusterSub_obj.GetComponent<clustersub>().lamp_laser_a_bool)
                {
                    Drop("laser_a");

                    buzzsub_obj.GetComponent<clustersub>().lamp_laser_a_bool = false;
                }
                if (clusterSub_obj.GetComponent<clustersub>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_b");
                }
                if (clusterSub_obj.GetComponent<clustersub>().lamp_laser_a_bool)
                {
                    Drop("lamp_a");
                }


                clusterSub_obj.GetComponent<clustersub>().lamp_laser_a_bool = false;
                clusterSub_obj.GetComponent<clustersub>().lamp_laser_b_bool = false;
                clusterSub_obj.GetComponent<clustersub>().laser_a_bool = false;

                clusterSub_obj.GetComponent<clustersub>().lamp_a_bool = true;

                clusterSub_obj.GetComponent<clustersub>().change_equipment();

                destroy = true;
            }
            if (which == "lamp_laser_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);





                // same position, turning lamp_laser_b off

                if (clusterSub_obj.GetComponent<clustersub>().laser_a_bool)
                {
                    Drop("lamp_laser_a");

                    clusterSub_obj.GetComponent<clustersub>().laser_a_bool = false;
                }
                if (clusterSub_obj.GetComponent<clustersub>().lamp_laser_a_bool)
                {
                    Drop("laser_a");

                    clusterSub_obj.GetComponent<clustersub>().lamp_laser_a_bool = false;
                }
                if (clusterSub_obj.GetComponent<clustersub>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_b");
                }
                if (clusterSub_obj.GetComponent<clustersub>().lamp_laser_a_bool)
                {
                    Drop("lamp_a");
                }

                clusterSub_obj.GetComponent<clustersub>().lamp_laser_a_bool = false;
                clusterSub_obj.GetComponent<clustersub>().lamp_a_bool = false;
                clusterSub_obj.GetComponent<clustersub>().laser_a_bool = false;

                clusterSub_obj.GetComponent<clustersub>().lamp_laser_b_bool = true;

                clusterSub_obj.GetComponent<clustersub>().change_equipment();

                destroy = true;
            }
            if (which == "laser_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);







                if (clusterSub_obj.GetComponent<clustersub>().laser_a_bool)
                {
                    Drop("lamp_laser_a");

                    buzzsub_obj.GetComponent<clustersub>().laser_a_bool = false;
                }
                if (clusterSub_obj.GetComponent<clustersub>().lamp_laser_a_bool)
                {
                    Drop("laser_a");

                    clusterSub_obj.GetComponent<clustersub>().lamp_laser_a_bool = false;
                }
                if (clusterSub_obj.GetComponent<clustersub>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_b");
                }
                if (clusterSub_obj.GetComponent<clustersub>().lamp_laser_a_bool)
                {
                    Drop("lamp_a");
                }


                clusterSub_obj.GetComponent<clustersub>().lamp_laser_a_bool = false;
                clusterSub_obj.GetComponent<clustersub>().lamp_laser_b_bool = false;
                clusterSub_obj.GetComponent<clustersub>().lamp_a_bool = false;

                clusterSub_obj.GetComponent<clustersub>().laser_a_bool = true;

                clusterSub_obj.GetComponent<clustersub>().change_equipment();

                destroy = true;

            }
            if (which == "lamp_laser_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);







                if (clusterSub_obj.GetComponent<clustersub>().laser_a_bool)
                {
                    Drop("lamp_laser_a");

                    clusterSub_obj.GetComponent<clustersub>().laser_a_bool = false;
                }
                if (clusterSub_obj.GetComponent<clustersub>().lamp_laser_a_bool)
                {
                    Drop("laser_a");

                    clusterSub_obj.GetComponent<clustersub>().lamp_laser_a_bool = false;
                }
                if (clusterSub_obj.GetComponent<clustersub>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_b");
                }
                if (clusterSub_obj.GetComponent<clustersub>().lamp_laser_a_bool)
                {
                    Drop("lamp_a");
                }


                clusterSub_obj.GetComponent<clustersub>().laser_a_bool = false;
                clusterSub_obj.GetComponent<clustersub>().lamp_laser_b_bool = false;
                clusterSub_obj.GetComponent<clustersub>().lamp_a_bool = false;

                clusterSub_obj.GetComponent<clustersub>().lamp_laser_a_bool = true;

                clusterSub_obj.GetComponent<clustersub>().change_equipment();

                destroy = true;

            }



            // changing scopes
            if (which == "red_dot_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);



                // checking, droping and turning off other scopes


                if (clusterSub_obj.GetComponent<clustersub>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    clusterSub_obj.GetComponent<clustersub>().red_dot_a_bool = false;
                }

                if (clusterSub_obj.GetComponent<clustersub>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    clusterSub_obj.GetComponent<clustersub>().red_dot_b_bool = false;
                }

                if (clusterSub_obj.GetComponent<clustersub>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    clusterSub_obj.GetComponent<clustersub>().red_dot_c_bool = false;
                }

                if (clusterSub_obj.GetComponent<clustersub>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    clusterSub_obj.GetComponent<clustersub>().red_dot_d_bool = false;
                }

                if (clusterSub_obj.GetComponent<clustersub>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    clusterSub_obj.GetComponent<clustersub>().red_dot_e_bool = false;
                }



                if (clusterSub_obj.GetComponent<clustersub>().scope_a_bool)
                {
                    Drop("scope_a");
                    clusterSub_obj.GetComponent<clustersub>().scope_a_bool = false;
                }

                if (clusterSub_obj.GetComponent<clustersub>().scope_b_bool)
                {
                    Drop("scope_b");
                    clusterSub_obj.GetComponent<clustersub>().scope_b_bool = false;
                }

                if (clusterSub_obj.GetComponent<clustersub>().scope_c_bool)
                {
                    Drop("scope_c");
                    clusterSub_obj.GetComponent<clustersub>().scope_c_bool = false;
                }





                clusterSub_obj.GetComponent<clustersub>().red_dot_a_bool = true;





                clusterSub_obj.GetComponent<clustersub>().change_equipment();
                destroy = true;

            }
            if (which == "red_dot_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);



                // checking, droping and turning off other scopes


                if (clusterSub_obj.GetComponent<clustersub>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    clusterSub_obj.GetComponent<clustersub>().red_dot_a_bool = false;
                }

                if (clusterSub_obj.GetComponent<clustersub>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    clusterSub_obj.GetComponent<clustersub>().red_dot_b_bool = false;
                }

                if (clusterSub_obj.GetComponent<clustersub>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    clusterSub_obj.GetComponent<clustersub>().red_dot_c_bool = false;
                }

                if (clusterSub_obj.GetComponent<clustersub>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    clusterSub_obj.GetComponent<clustersub>().red_dot_d_bool = false;
                }

                if (clusterSub_obj.GetComponent<clustersub>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    clusterSub_obj.GetComponent<clustersub>().red_dot_e_bool = false;
                }



                if (clusterSub_obj.GetComponent<clustersub>().scope_a_bool)
                {
                    Drop("scope_a");
                    clusterSub_obj.GetComponent<clustersub>().scope_a_bool = false;
                }

                if (clusterSub_obj.GetComponent<clustersub>().scope_b_bool)
                {
                    Drop("scope_b");
                    clusterSub_obj.GetComponent<clustersub>().scope_b_bool = false;
                }

                if (clusterSub_obj.GetComponent<clustersub>().scope_c_bool)
                {
                    Drop("scope_c");
                    clusterSub_obj.GetComponent<clustersub>().scope_c_bool = false;
                }



                clusterSub_obj.GetComponent<clustersub>().red_dot_b_bool = true;





                clusterSub_obj.GetComponent<clustersub>().change_equipment();
                destroy = true;

            }
            if (which == "red_dot_c")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);



                // checking, droping and turning off other scopes


                if (clusterSub_obj.GetComponent<clustersub>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    clusterSub_obj.GetComponent<clustersub>().red_dot_a_bool = false;
                }

                if (clusterSub_obj.GetComponent<clustersub>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    clusterSub_obj.GetComponent<clustersub>().red_dot_b_bool = false;
                }

                if (clusterSub_obj.GetComponent<clustersub>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    clusterSub_obj.GetComponent<clustersub>().red_dot_c_bool = false;
                }

                if (clusterSub_obj.GetComponent<clustersub>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    clusterSub_obj.GetComponent<clustersub>().red_dot_d_bool = false;
                }

                if (clusterSub_obj.GetComponent<clustersub>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    clusterSub_obj.GetComponent<clustersub>().red_dot_e_bool = false;
                }



                if (clusterSub_obj.GetComponent<clustersub>().scope_a_bool)
                {
                    Drop("scope_a");
                    clusterSub_obj.GetComponent<clustersub>().scope_a_bool = false;
                }

                if (clusterSub_obj.GetComponent<clustersub>().scope_b_bool)
                {
                    Drop("scope_b");
                    clusterSub_obj.GetComponent<clustersub>().scope_b_bool = false;
                }

                if (clusterSub_obj.GetComponent<clustersub>().scope_c_bool)
                {
                    Drop("scope_c");
                    clusterSub_obj.GetComponent<clustersub>().scope_c_bool = false;
                }



                clusterSub_obj.GetComponent<clustersub>().red_dot_c_bool = true;





                clusterSub_obj.GetComponent<clustersub>().change_equipment();
                destroy = true;

            }
          
            

            if (which == "Suppressor_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);


                clusterSub_obj.GetComponent<clustersub>().suppressor_clusterSub_bool = true;

                clusterSub_obj.GetComponent<clustersub>().change_equipment();

                destroy = true;

            }


        }
        if (lock_bool)
        {


            // checking, what you picked up and determine it with a string check and turning off other equipment, if required to make the place for the new one free



         
            if (which == "lamp_laser_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);





                // same position, turning lamp_laser_b off

                if (lock_obj.GetComponent<lock_>().laser_a_bool)
                {
                    Drop("lamp_laser_a");
                }
                if (lock_obj.GetComponent<lock_>().lamp_laser_a_bool)
                {
                    Drop("laser_a");
                }
                if (lock_obj.GetComponent<lock_>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_b");
                }
                if (lock_obj.GetComponent<lock_>().lamp_laser_a_bool)
                {
                    Drop("lamp_a");
                }

                lock_obj.GetComponent<lock_>().lamp_laser_a_bool = false;
                lock_obj.GetComponent<lock_>().lamp_a_bool = false;
                lock_obj.GetComponent<lock_>().laser_a_bool = false;

                lock_obj.GetComponent<lock_>().lamp_laser_b_bool = true;

                lock_obj.GetComponent<lock_>().change_equipment();

                destroy = true;
            }
            if (which == "laser_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);







                if (lock_obj.GetComponent<lock_>().laser_a_bool)
                {
                    Drop("lamp_laser_a");
                }
                if (lock_obj.GetComponent<lock_>().lamp_laser_a_bool)
                {
                    Drop("laser_a");
                }
                if (lock_obj.GetComponent<lock_>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_b");
                }
                if (lock_obj.GetComponent<lock_>().lamp_laser_a_bool)
                {
                    Drop("lamp_a");
                }


                lock_obj.GetComponent<lock_>().lamp_laser_a_bool = false;
                lock_obj.GetComponent<lock_>().lamp_laser_b_bool = false;
                lock_obj.GetComponent<lock_>().lamp_a_bool = false;

                lock_obj.GetComponent<lock_>().laser_a_bool = true;

                lock_obj.GetComponent<lock_>().change_equipment();

                destroy = true;

            }
            if (which == "lamp_laser_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);







                if (lock_obj.GetComponent<lock_>().laser_a_bool)
                {
                    Drop("lamp_laser_a");
                }
                if (lock_obj.GetComponent<lock_>().lamp_laser_a_bool)
                {
                    Drop("laser_a");
                }
                if (lock_obj.GetComponent<lock_>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_b");
                }
                if (lock_obj.GetComponent<lock_>().lamp_laser_a_bool)
                {
                    Drop("lamp_a");
                }


                lock_obj.GetComponent<lock_>().laser_a_bool = false;
                lock_obj.GetComponent<lock_>().lamp_laser_b_bool = false;
                lock_obj.GetComponent<lock_>().lamp_a_bool = false;

                lock_obj.GetComponent<lock_>().lamp_laser_a_bool = true;

                lock_obj.GetComponent<lock_>().change_equipment();

                destroy = true;

            }


            // changing scopes
            if (which == "red_dot_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (lock_obj.GetComponent<lock_>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    lock_obj.GetComponent<lock_>().red_dot_a_bool = false;
                }




                lock_obj.GetComponent<lock_>().red_dot_a_bool = true;





                lock_obj.GetComponent<lock_>().change_equipment();


            }




            if (which == "suppressor_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);


                destroy = true;


                if (lock_obj.GetComponent<lock_>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    lock_obj.GetComponent<lock_>().suppressor_a_bool = false;
                }

                if (lock_obj.GetComponent<lock_>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    lock_obj.GetComponent<lock_>().suppressor_c_bool = false;
                }

                if (lock_obj.GetComponent<lock_>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    lock_obj.GetComponent<lock_>().suppressor_d_bool = false;
                }

                lock_obj.GetComponent<lock_>().suppressor_a_bool = true;

                lock_obj.GetComponent<lock_>().change_equipment();



            }
            // suppresor b is just for one weapon useable
            if (which == "suppressor_c")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);




                destroy = true;

                if (lock_obj.GetComponent<lock_>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    lock_obj.GetComponent<lock_>().suppressor_a_bool = false;
                }

                if (lock_obj.GetComponent<lock_>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    lock_obj.GetComponent<lock_>().suppressor_c_bool = false;
                }

                if (lock_obj.GetComponent<lock_>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    lock_obj.GetComponent<lock_>().suppressor_d_bool = false;
                }

                lock_obj.GetComponent<lock_>().suppressor_c_bool = true;

                lock_obj.GetComponent<lock_>().change_equipment();



            }
            if (which == "suppressor_d")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);


                destroy = true;


                if (lock_obj.GetComponent<lock_>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    lock_obj.GetComponent<lock_>().suppressor_a_bool = false;
                }

                if (lock_obj.GetComponent<lock_>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    lock_obj.GetComponent<lock_>().suppressor_c_bool = false;
                }

                if (lock_obj.GetComponent<lock_>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    lock_obj.GetComponent<lock_>().suppressor_d_bool = false;
                }

                lock_obj.GetComponent<lock_>().suppressor_d_bool = true;

                lock_obj.GetComponent<lock_>().change_equipment();



            }

        }
        if (machineGun_bool)
        {


            // checking, what you picked up and determine it with a string check and turning off other equipment, if required to make the place for the new one free



            // left side of holder
            if (which == "lamp_a")
            {

                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                machineGun_obj.GetComponent<machine_gun>().lamp_a_bool = true;

                // same position, turning lamp_laser_b off

                if (machineGun_obj.GetComponent<machine_gun>().lamp_laser_b_bool)
                {
                    Drop("lamp_laser_b");
                }


                machineGun_obj.GetComponent<machine_gun>().lamp_laser_b_bool = false;

                machineGun_obj.GetComponent<machine_gun>().change_equipment();


            }
            if (which == "lamp_laser_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);
      
                destroy = true;

                machineGun_obj.GetComponent<machine_gun>().lamp_laser_b_bool = true;

                // same position, turning lamp_laser_b off

                if (machineGun_obj.GetComponent<machine_gun>().lamp_a_bool)
                {
                    Drop("lamp_a");

                    machineGun_obj.GetComponent<machine_gun>().lamp_a_bool = false;
                }




                machineGun_obj.GetComponent<machine_gun>().change_equipment();


            }


            // right side of holder
            if (which == "laser_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);
                destroy = true;

                machineGun_obj.GetComponent<machine_gun>().laser_a_bool = true;



                if (machineGun_obj.GetComponent<machine_gun>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_a");

                    machineGun_obj.GetComponent<machine_gun>().lamp_laser_a_bool = false;
                }




                machineGun_obj.GetComponent<machine_gun>().change_equipment();



            }
            if (which == "lamp_laser_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);
                destroy = true;

                machineGun_obj.GetComponent<machine_gun>().lamp_laser_a_bool = true;



                if (machineGun_obj.GetComponent<machine_gun>().laser_a_bool)
                {
                    Drop("lamp_laser_a");

                    machineGun_obj.GetComponent<machine_gun>().laser_a_bool = false;
                }




                machineGun_obj.GetComponent<machine_gun>().change_equipment();



            }


            // changing scopes
            if (which == "red_dot_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (machineGun_obj.GetComponent<machine_gun>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_a_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_b_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_c_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_d_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_e_bool = false;
                }



                if (machineGun_obj.GetComponent<machine_gun>().scope_a_bool)
                {
                    Drop("scope_a");
                    machineGun_obj.GetComponent<machine_gun>().scope_a_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().scope_b_bool)
                {
                    Drop("scope_b");
                    machineGun_obj.GetComponent<machine_gun>().scope_b_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().scope_c_bool)
                {
                    Drop("scope_c");
                    machineGun_obj.GetComponent<machine_gun>().scope_c_bool = false;
                }

                Debug.Log("worked");

           

                machineGun_obj.GetComponent<machine_gun>().red_dot_a_bool = true;





                machineGun_obj.GetComponent<machine_gun>().change_equipment();


            }
            if (which == "red_dot_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (machineGun_obj.GetComponent<machine_gun>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_a_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_b_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_c_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_d_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_e_bool = false;
                }



                if (machineGun_obj.GetComponent<machine_gun>().scope_a_bool)
                {
                    Drop("scope_a");
                    machineGun_obj.GetComponent<machine_gun>().scope_a_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().scope_b_bool)
                {
                    Drop("scope_b");
                    machineGun_obj.GetComponent<machine_gun>().scope_b_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().scope_c_bool)
                {
                    Drop("scope_c");
                    machineGun_obj.GetComponent<machine_gun>().scope_c_bool = false;
                }


              

                machineGun_obj.GetComponent<machine_gun>().red_dot_b_bool = true;





                machineGun_obj.GetComponent<machine_gun>().change_equipment();


            }
            if (which == "red_dot_c")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (machineGun_obj.GetComponent<machine_gun>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_a_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_b_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_c_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_d_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_e_bool = false;
                }



                if (machineGun_obj.GetComponent<machine_gun>().scope_a_bool)
                {
                    Drop("scope_a");
                    machineGun_obj.GetComponent<machine_gun>().scope_a_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().scope_b_bool)
                {
                    Drop("scope_b");
                    machineGun_obj.GetComponent<machine_gun>().scope_b_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().scope_c_bool)
                {
                    Drop("scope_c");
                    machineGun_obj.GetComponent<machine_gun>().scope_c_bool = false;
                }


          

                machineGun_obj.GetComponent<machine_gun>().red_dot_c_bool = true;





                machineGun_obj.GetComponent<machine_gun>().change_equipment();


            }
            if (which == "red_dot_d")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (machineGun_obj.GetComponent<machine_gun>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_a_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_b_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_c_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_d_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_e_bool = false;
                }



                if (machineGun_obj.GetComponent<machine_gun>().scope_a_bool)
                {
                    Drop("scope_a");
                    machineGun_obj.GetComponent<machine_gun>().scope_a_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().scope_b_bool)
                {
                    Drop("scope_b");
                    machineGun_obj.GetComponent<machine_gun>().scope_b_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().scope_c_bool)
                {
                    Drop("scope_c");
                    machineGun_obj.GetComponent<machine_gun>().scope_c_bool = false;
                }


       

                machineGun_obj.GetComponent<machine_gun>().red_dot_d_bool = true;





                machineGun_obj.GetComponent<machine_gun>().change_equipment();


            }
            if (which == "red_dot_e")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (machineGun_obj.GetComponent<machine_gun>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_a_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_b_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_c_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_d_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_e_bool = false;
                }



                if (machineGun_obj.GetComponent<machine_gun>().scope_a_bool)
                {
                    Drop("scope_a");
                    machineGun_obj.GetComponent<machine_gun>().scope_a_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().scope_b_bool)
                {
                    Drop("scope_b");
                    machineGun_obj.GetComponent<machine_gun>().scope_b_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().scope_c_bool)
                {
                    Drop("scope_c");
                    machineGun_obj.GetComponent<machine_gun>().scope_c_bool = false;
                }


             

                machineGun_obj.GetComponent<machine_gun>().red_dot_e_bool = true;





                machineGun_obj.GetComponent<machine_gun>().change_equipment();


            }
            if (which == "scope_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (machineGun_obj.GetComponent<machine_gun>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_a_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_b_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_c_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_d_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_e_bool = false;
                }



                if (machineGun_obj.GetComponent<machine_gun>().scope_a_bool)
                {
                    Drop("scope_a");
                    machineGun_obj.GetComponent<machine_gun>().scope_a_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().scope_b_bool)
                {
                    Drop("scope_b");
                    machineGun_obj.GetComponent<machine_gun>().scope_b_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().scope_c_bool)
                {
                    Drop("scope_c");
                    machineGun_obj.GetComponent<machine_gun>().scope_c_bool = false;
                }



                machineGun_obj.GetComponent<machine_gun>().scope_a_bool = true;





                machineGun_obj.GetComponent<machine_gun>().change_equipment();


            }
            if (which == "scope_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (machineGun_obj.GetComponent<machine_gun>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_a_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_b_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_c_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_d_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_e_bool = false;
                }



                if (machineGun_obj.GetComponent<machine_gun>().scope_a_bool)
                {
                    Drop("scope_a");
                    machineGun_obj.GetComponent<machine_gun>().scope_a_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().scope_b_bool)
                {
                    Drop("scope_b");
                    machineGun_obj.GetComponent<machine_gun>().scope_b_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().scope_c_bool)
                {
                    Drop("scope_c");
                    machineGun_obj.GetComponent<machine_gun>().scope_c_bool = false;
                }


    
                machineGun_obj.GetComponent<machine_gun>().scope_b_bool = true;





                machineGun_obj.GetComponent<machine_gun>().change_equipment();


            }
            if (which == "scope_c")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (machineGun_obj.GetComponent<machine_gun>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_a_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_b_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_c_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_d_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    machineGun_obj.GetComponent<machine_gun>().red_dot_e_bool = false;
                }



                if (machineGun_obj.GetComponent<machine_gun>().scope_a_bool)
                {
                    Drop("scope_a");
                    machineGun_obj.GetComponent<machine_gun>().scope_a_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().scope_b_bool)
                {
                    Drop("scope_b");
                    machineGun_obj.GetComponent<machine_gun>().scope_b_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().scope_c_bool)
                {
                    Drop("scope_c");
                    machineGun_obj.GetComponent<machine_gun>().scope_c_bool = false;
                }


   

                machineGun_obj.GetComponent<machine_gun>().scope_c_bool = true;





                machineGun_obj.GetComponent<machine_gun>().change_equipment();


            }



            if (which == "suppressor_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);


                destroy = true;


                if (machineGun_obj.GetComponent<machine_gun>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    machineGun_obj.GetComponent<machine_gun>().suppressor_a_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    machineGun_obj.GetComponent<machine_gun>().suppressor_c_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    machineGun_obj.GetComponent<machine_gun>().suppressor_d_bool = false;
                }

                machineGun_obj.GetComponent<machine_gun>().suppressor_a_bool = true;

                machineGun_obj.GetComponent<machine_gun>().change_equipment();



            }
            // suppresor b is just for one weapon useable
            if (which == "suppressor_c")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);




                destroy = true;

                if (machineGun_obj.GetComponent<machine_gun>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    machineGun_obj.GetComponent<machine_gun>().suppressor_a_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    machineGun_obj.GetComponent<machine_gun>().suppressor_c_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    machineGun_obj.GetComponent<machine_gun>().suppressor_d_bool = false;
                }

                machineGun_obj.GetComponent<machine_gun>().suppressor_c_bool = true;

                machineGun_obj.GetComponent<machine_gun>().change_equipment();



            }
            if (which == "suppressor_d")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);


                destroy = true;


                if (machineGun_obj.GetComponent<machine_gun>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    machineGun_obj.GetComponent<machine_gun>().suppressor_a_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    machineGun_obj.GetComponent<machine_gun>().suppressor_c_bool = false;
                }

                if (machineGun_obj.GetComponent<machine_gun>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    machineGun_obj.GetComponent<machine_gun>().suppressor_d_bool = false;
                }

                machineGun_obj.GetComponent<machine_gun>().suppressor_d_bool = true;

                machineGun_obj.GetComponent<machine_gun>().change_equipment();



            }

        }
        if (mkb16_bool)
        {


            // checking, what you picked up and determine it with a string check and turning off other equipment, if required to make the place for the new one free



            // left side of holder
            if (which == "lamp_a")
            {

                AudioSource.PlayClipAtPoint(click, transform.position);
                
                destroy = true;

                mkb16_obj.GetComponent<mkb16>().lamp_a_bool = true;

                // same position, turning lamp_laser_b off

                if (mkb16_obj.GetComponent<mkb16>().lamp_laser_b_bool)
                {
                    Drop("lamp_laser_b");
                }


                mkb16_obj.GetComponent<mkb16>().lamp_laser_b_bool = false;

                mkb16_obj.GetComponent<mkb16>().change_equipment();


            }
            if (which == "lamp_laser_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);
               
                destroy = true;

                mkb16_obj.GetComponent<mkb16>().lamp_laser_b_bool = true;

                // same position, turning lamp_laser_b off

                if (mkb16_obj.GetComponent<mkb16>().lamp_a_bool)
                {
                    Drop("lamp_a");

                    mkb16_obj.GetComponent<mkb16>().lamp_a_bool = false;
                }




                mkb16_obj.GetComponent<mkb16>().change_equipment();


            }


            // right side of holder
            if (which == "laser_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);
           
                destroy = true;

                mkb16_obj.GetComponent<mkb16>().laser_a_bool = true;



                if (mkb16_obj.GetComponent<mkb16>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_a");

                    mkb16_obj.GetComponent<mkb16>().lamp_laser_a_bool = false;
                }




                mkb16_obj.GetComponent<mkb16>().change_equipment();



            }
            if (which == "lamp_laser_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);
             
                destroy = true;

                mkb16_obj.GetComponent<mkb16>().lamp_laser_a_bool = true;



                if (mkb16_obj.GetComponent<mkb16>().laser_a_bool)
                {
                    Drop("lamp_laser_a");

                    mkb16_obj.GetComponent<mkb16>().laser_a_bool = false;
                }




                mkb16_obj.GetComponent<mkb16>().change_equipment();



            }


            // changing scopes
            if (which == "red_dot_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (mkb16_obj.GetComponent<mkb16>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    mkb16_obj.GetComponent<mkb16>().red_dot_a_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    mkb16_obj.GetComponent<mkb16>().red_dot_b_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    mkb16_obj.GetComponent<mkb16>().red_dot_c_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    mkb16_obj.GetComponent<mkb16>().red_dot_d_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    mkb16_obj.GetComponent<mkb16>().red_dot_e_bool = false;
                }



                if (mkb16_obj.GetComponent<mkb16>().scope_a_bool)
                {
                    Drop("scope_a");
                    mkb16_obj.GetComponent<mkb16>().scope_a_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().scope_b_bool)
                {
                    Drop("scope_b");
                    mkb16_obj.GetComponent<mkb16>().scope_b_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().scope_c_bool)
                {
                    Drop("scope_c");
                    mkb16_obj.GetComponent<mkb16>().scope_c_bool = false;
                }

           

                mkb16_obj.GetComponent<mkb16>().front_sight_bool = false;
                mkb16_obj.GetComponent<mkb16>().back_sight_bool = false;

                mkb16_obj.GetComponent<mkb16>().red_dot_a_bool = true;





                mkb16_obj.GetComponent<mkb16>().change_equipment();


            }
            if (which == "red_dot_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (mkb16_obj.GetComponent<mkb16>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    mkb16_obj.GetComponent<mkb16>().red_dot_a_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    mkb16_obj.GetComponent<mkb16>().red_dot_b_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    mkb16_obj.GetComponent<mkb16>().red_dot_c_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    mkb16_obj.GetComponent<mkb16>().red_dot_d_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    mkb16_obj.GetComponent<mkb16>().red_dot_e_bool = false;
                }



                if (mkb16_obj.GetComponent<mkb16>().scope_a_bool)
                {
                    Drop("scope_a");
                    mkb16_obj.GetComponent<mkb16>().scope_a_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().scope_b_bool)
                {
                    Drop("scope_b");
                    mkb16_obj.GetComponent<mkb16>().scope_b_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().scope_c_bool)
                {
                    Drop("scope_c");
                    mkb16_obj.GetComponent<mkb16>().scope_c_bool = false;
                }


                mkb16_obj.GetComponent<mkb16>().front_sight_bool = false;
                mkb16_obj.GetComponent<mkb16>().back_sight_bool = false;

                mkb16_obj.GetComponent<mkb16>().red_dot_b_bool = true;





                mkb16_obj.GetComponent<mkb16>().change_equipment();


            }
            if (which == "red_dot_c")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (mkb16_obj.GetComponent<mkb16>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    mkb16_obj.GetComponent<mkb16>().red_dot_a_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    mkb16_obj.GetComponent<mkb16>().red_dot_b_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    mkb16_obj.GetComponent<mkb16>().red_dot_c_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    mkb16_obj.GetComponent<mkb16>().red_dot_d_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    mkb16_obj.GetComponent<mkb16>().red_dot_e_bool = false;
                }



                if (mkb16_obj.GetComponent<mkb16>().scope_a_bool)
                {
                    Drop("scope_a");
                    mkb16_obj.GetComponent<mkb16>().scope_a_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().scope_b_bool)
                {
                    Drop("scope_b");
                    mkb16_obj.GetComponent<mkb16>().scope_b_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().scope_c_bool)
                {
                    Drop("scope_c");
                    mkb16_obj.GetComponent<mkb16>().scope_c_bool = false;
                }


                mkb16_obj.GetComponent<mkb16>().front_sight_bool = false;
                mkb16_obj.GetComponent<mkb16>().back_sight_bool = false;

                mkb16_obj.GetComponent<mkb16>().red_dot_c_bool = true;





                mkb16_obj.GetComponent<mkb16>().change_equipment();


            }
            if (which == "red_dot_d")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (mkb16_obj.GetComponent<mkb16>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    mkb16_obj.GetComponent<mkb16>().red_dot_a_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    mkb16_obj.GetComponent<mkb16>().red_dot_b_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    mkb16_obj.GetComponent<mkb16>().red_dot_c_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    mkb16_obj.GetComponent<mkb16>().red_dot_d_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    mkb16_obj.GetComponent<mkb16>().red_dot_e_bool = false;
                }



                if (mkb16_obj.GetComponent<mkb16>().scope_a_bool)
                {
                    Drop("scope_a");
                    mkb16_obj.GetComponent<mkb16>().scope_a_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().scope_b_bool)
                {
                    Drop("scope_b");
                    mkb16_obj.GetComponent<mkb16>().scope_b_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().scope_c_bool)
                {
                    Drop("scope_c");
                    mkb16_obj.GetComponent<mkb16>().scope_c_bool = false;
                }


                mkb16_obj.GetComponent<mkb16>().front_sight_bool = false;
                mkb16_obj.GetComponent<mkb16>().back_sight_bool = false;

                mkb16_obj.GetComponent<mkb16>().red_dot_d_bool = true;





                mkb16_obj.GetComponent<mkb16>().change_equipment();


            }
            if (which == "red_dot_e")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (mkb16_obj.GetComponent<mkb16>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    mkb16_obj.GetComponent<mkb16>().red_dot_a_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    mkb16_obj.GetComponent<mkb16>().red_dot_b_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    mkb16_obj.GetComponent<mkb16>().red_dot_c_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    mkb16_obj.GetComponent<mkb16>().red_dot_d_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    mkb16_obj.GetComponent<mkb16>().red_dot_e_bool = false;
                }



                if (mkb16_obj.GetComponent<mkb16>().scope_a_bool)
                {
                    Drop("scope_a");
                    mkb16_obj.GetComponent<mkb16>().scope_a_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().scope_b_bool)
                {
                    Drop("scope_b");
                    mkb16_obj.GetComponent<mkb16>().scope_b_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().scope_c_bool)
                {
                    Drop("scope_c");
                    mkb16_obj.GetComponent<mkb16>().scope_c_bool = false;
                }


                mkb16_obj.GetComponent<mkb16>().front_sight_bool = false;
                mkb16_obj.GetComponent<mkb16>().back_sight_bool = false;

                mkb16_obj.GetComponent<mkb16>().red_dot_e_bool = true;





                mkb16_obj.GetComponent<mkb16>().change_equipment();


            }
            if (which == "scope_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (mkb16_obj.GetComponent<mkb16>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    mkb16_obj.GetComponent<mkb16>().red_dot_a_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    mkb16_obj.GetComponent<mkb16>().red_dot_b_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    mkb16_obj.GetComponent<mkb16>().red_dot_c_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    mkb16_obj.GetComponent<mkb16>().red_dot_d_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    mkb16_obj.GetComponent<mkb16>().red_dot_e_bool = false;
                }



                if (mkb16_obj.GetComponent<mkb16>().scope_a_bool)
                {
                    Drop("scope_a");
                    mkb16_obj.GetComponent<mkb16>().scope_a_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().scope_b_bool)
                {
                    Drop("scope_b");
                    mkb16_obj.GetComponent<mkb16>().scope_b_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().scope_c_bool)
                {
                    Drop("scope_c");
                    mkb16_obj.GetComponent<mkb16>().scope_c_bool = false;
                }


                mkb16_obj.GetComponent<mkb16>().front_sight_bool = false;
                mkb16_obj.GetComponent<mkb16>().back_sight_bool = false;

                mkb16_obj.GetComponent<mkb16>().scope_a_bool = true;





                mkb16_obj.GetComponent<mkb16>().change_equipment();


            }
            if (which == "scope_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (mkb16_obj.GetComponent<mkb16>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    mkb16_obj.GetComponent<mkb16>().red_dot_a_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    mkb16_obj.GetComponent<mkb16>().red_dot_b_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    mkb16_obj.GetComponent<mkb16>().red_dot_c_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    mkb16_obj.GetComponent<mkb16>().red_dot_d_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    mkb16_obj.GetComponent<mkb16>().red_dot_e_bool = false;
                }



                if (mkb16_obj.GetComponent<mkb16>().scope_a_bool)
                {
                    Drop("scope_a");
                    mkb16_obj.GetComponent<mkb16>().scope_a_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().scope_b_bool)
                {
                    Drop("scope_b");
                    mkb16_obj.GetComponent<mkb16>().scope_b_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().scope_c_bool)
                {
                    Drop("scope_c");
                    mkb16_obj.GetComponent<mkb16>().scope_c_bool = false;
                }


                mkb16_obj.GetComponent<mkb16>().front_sight_bool = false;
                mkb16_obj.GetComponent<mkb16>().back_sight_bool = false;

                mkb16_obj.GetComponent<mkb16>().scope_b_bool = true;





                mkb16_obj.GetComponent<mkb16>().change_equipment();


            }
            if (which == "scope_c")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (mkb16_obj.GetComponent<mkb16>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    mkb16_obj.GetComponent<mkb16>().red_dot_a_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    mkb16_obj.GetComponent<mkb16>().red_dot_b_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    mkb16_obj.GetComponent<mkb16>().red_dot_c_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    mkb16_obj.GetComponent<mkb16>().red_dot_d_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    mkb16_obj.GetComponent<mkb16>().red_dot_e_bool = false;
                }



                if (mkb16_obj.GetComponent<mkb16>().scope_a_bool)
                {
                    Drop("scope_a");
                    mkb16_obj.GetComponent<mkb16>().scope_a_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().scope_b_bool)
                {
                    Drop("scope_b");
                    mkb16_obj.GetComponent<mkb16>().scope_b_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().scope_c_bool)
                {
                    Drop("scope_c");
                    mkb16_obj.GetComponent<mkb16>().scope_c_bool = false;
                }



                mkb16_obj.GetComponent<mkb16>().front_sight_bool = false;
                mkb16_obj.GetComponent<mkb16>().back_sight_bool = false;

                mkb16_obj.GetComponent<mkb16>().scope_c_bool = true;





                mkb16_obj.GetComponent<mkb16>().change_equipment();


            }



            if (which == "suppressor_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);


                destroy = true;


                if (mkb16_obj.GetComponent<mkb16>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    mkb16_obj.GetComponent<mkb16>().suppressor_a_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    mkb16_obj.GetComponent<mkb16>().suppressor_c_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    mkb16_obj.GetComponent<mkb16>().suppressor_d_bool = false;
                }

                mkb16_obj.GetComponent<mkb16>().suppressor_a_bool = true;

                mkb16_obj.GetComponent<mkb16>().change_equipment();



            }
            // suppresor b is just for one weapon useable
            if (which == "suppressor_c")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);




                destroy = true;

                if (mkb16_obj.GetComponent<mkb16>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    mkb16_obj.GetComponent<mkb16>().suppressor_a_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    mkb16_obj.GetComponent<mkb16>().suppressor_c_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    mkb16_obj.GetComponent<mkb16>().suppressor_d_bool = false;
                }

                mkb16_obj.GetComponent<mkb16>().suppressor_c_bool = true;

                mkb16_obj.GetComponent<mkb16>().change_equipment();



            }
            if (which == "suppressor_d")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);


                destroy = true;


                if (mkb16_obj.GetComponent<mkb16>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    mkb16_obj.GetComponent<mkb16>().suppressor_a_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    mkb16_obj.GetComponent<mkb16>().suppressor_c_bool = false;
                }

                if (mkb16_obj.GetComponent<mkb16>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    mkb16_obj.GetComponent<mkb16>().suppressor_d_bool = false;
                }

                mkb16_obj.GetComponent<mkb16>().suppressor_d_bool = true;

                mkb16_obj.GetComponent<mkb16>().change_equipment();



            }

        }
        if (nsp_bool)
        {


            // checking, what you picked up and determine it with a string check and turning off other equipment, if required to make the place for the new one free




            if (which == "lamp_laser_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);





                // same position, turning lamp_laser_b off

                if (nsp_obj.GetComponent<nsp>().laser_a_bool)
                {
                    Drop("lamp_laser_a");
                }
                if (nsp_obj.GetComponent<nsp>().lamp_laser_a_bool)
                {
                    Drop("laser_a");
                }
                if (nsp_obj.GetComponent<nsp>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_b");
                }
                if (nsp_obj.GetComponent<nsp>().lamp_laser_a_bool)
                {
                    Drop("lamp_a");
                }

                nsp_obj.GetComponent<nsp>().lamp_laser_a_bool = false;
                nsp_obj.GetComponent<nsp>().lamp_a_bool = false;
                nsp_obj.GetComponent<nsp>().laser_a_bool = false;

                nsp_obj.GetComponent<nsp>().lamp_laser_b_bool = true;

                nsp_obj.GetComponent<nsp>().change_equipment();

                destroy = true;
            }
            if (which == "laser_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);







                if (nsp_obj.GetComponent<nsp>().laser_a_bool)
                {
                    Drop("lamp_laser_a");
                }
                if (nsp_obj.GetComponent<nsp>().lamp_laser_a_bool)
                {
                    Drop("laser_a");
                }
                if (nsp_obj.GetComponent<nsp>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_b");
                }
                if (nsp_obj.GetComponent<nsp>().lamp_laser_a_bool)
                {
                    Drop("lamp_a");
                }


                nsp_obj.GetComponent<nsp>().lamp_laser_a_bool = false;
                nsp_obj.GetComponent<nsp>().lamp_laser_b_bool = false;
                nsp_obj.GetComponent<nsp>().lamp_a_bool = false;

                nsp_obj.GetComponent<nsp>().laser_a_bool = true;

                nsp_obj.GetComponent<nsp>().change_equipment();

                destroy = true;

            }
            if (which == "lamp_laser_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);







                if (nsp_obj.GetComponent<nsp>().laser_a_bool)
                {
                    Drop("lamp_laser_a");
                }
                if (nsp_obj.GetComponent<nsp>().lamp_laser_a_bool)
                {
                    Drop("laser_a");
                }
                if (nsp_obj.GetComponent<nsp>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_b");
                }
                if (nsp_obj.GetComponent<nsp>().lamp_laser_a_bool)
                {
                    Drop("lamp_a");
                }


                nsp_obj.GetComponent<nsp>().laser_a_bool = false;
                nsp_obj.GetComponent<nsp>().lamp_laser_b_bool = false;
                nsp_obj.GetComponent<nsp>().lamp_a_bool = false;

                nsp_obj.GetComponent<nsp>().lamp_laser_a_bool = true;

                nsp_obj.GetComponent<nsp>().change_equipment();

                destroy = true;

            }


            // changing scopes
            if (which == "red_dot_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (nsp_obj.GetComponent<nsp>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    nsp_obj.GetComponent<nsp>().red_dot_a_bool = false;
                }




                nsp_obj.GetComponent<nsp>().red_dot_a_bool = true;





                nsp_obj.GetComponent<nsp>().change_equipment();


            }





            if (which == "suppressor_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);


                destroy = true;


                if (nsp_obj.GetComponent<nsp>().suppressor_a_bool)
                {
                    Drop("suppressor_a");
                    
                    nsp_obj.GetComponent<nsp>().suppressor_a_bool = false;
                }

                if (nsp_obj.GetComponent<nsp>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    nsp_obj.GetComponent<nsp>().suppressor_c_bool = false;
                }

                if (nsp_obj.GetComponent<nsp>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    nsp_obj.GetComponent<nsp>().suppressor_d_bool = false;
                }

                nsp_obj.GetComponent<nsp>().suppressor_a_bool = true;

                nsp_obj.GetComponent<nsp>().change_equipment();



            }
            // suppresor b is just for one weapon useable
            if (which == "suppressor_c")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);




                destroy = true;

                if (nsp_obj.GetComponent<nsp>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    nsp_obj.GetComponent<nsp>().suppressor_a_bool = false;
                }

                if (nsp_obj.GetComponent<nsp>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    nsp_obj.GetComponent<nsp>().suppressor_c_bool = false;
                }

                if (nsp_obj.GetComponent<nsp>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    nsp_obj.GetComponent<nsp>().suppressor_d_bool = false;
                }

                nsp_obj.GetComponent<nsp>().suppressor_c_bool = true;

                nsp_obj.GetComponent<nsp>().change_equipment();



            }
            if (which == "suppressor_d")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);


                destroy = true;


                if (nsp_obj.GetComponent<nsp>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    nsp_obj.GetComponent<nsp>().suppressor_a_bool = false;
                }

                if (nsp_obj.GetComponent<nsp>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    nsp_obj.GetComponent<nsp>().suppressor_c_bool = false;
                }

                if (nsp_obj.GetComponent<nsp>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    nsp_obj.GetComponent<nsp>().suppressor_d_bool = false;
                }

                nsp_obj.GetComponent<nsp>().suppressor_d_bool = true;

                nsp_obj.GetComponent<nsp>().change_equipment();



            }

        }
        if (old_pistol_bool)
        {


            // checking, what you picked up and determine it with a string check and turning off other equipment, if required to make the place for the new one free




            if (which == "lamp_laser_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);





                // same position, turning lamp_laser_b off

                if (old_pistol_obj.GetComponent<old_pistol>().laser_a_bool)
                {
                    Drop("lamp_laser_a");
                }
                if (old_pistol_obj.GetComponent<old_pistol>().lamp_laser_a_bool)
                {
                    Drop("laser_a");
                }
                if (old_pistol_obj.GetComponent<old_pistol>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_b");
                }
                if (old_pistol_obj.GetComponent<old_pistol>().lamp_laser_a_bool)
                {
                    Drop("lamp_a");
                }

                old_pistol_obj.GetComponent<old_pistol>().lamp_laser_a_bool = false;
                old_pistol_obj.GetComponent<old_pistol>().laser_a_bool = false;

                old_pistol_obj.GetComponent<old_pistol>().lamp_laser_b_bool = true;

                old_pistol_obj.GetComponent<old_pistol>().change_equipment();

                destroy = true;
            }
            if (which == "laser_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);







                if (old_pistol_obj.GetComponent<old_pistol>().laser_a_bool)
                {
                    Drop("lamp_laser_a");
                }
                if (old_pistol_obj.GetComponent<old_pistol>().lamp_laser_a_bool)
                {
                    Drop("laser_a");
                }
                if (old_pistol_obj.GetComponent<old_pistol>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_b");
                }
                if (old_pistol_obj.GetComponent<old_pistol>().lamp_laser_a_bool)
                {
                    Drop("lamp_a");
                }


                old_pistol_obj.GetComponent<old_pistol>().lamp_laser_a_bool = false;
                old_pistol_obj.GetComponent<old_pistol>().lamp_laser_b_bool = false;
           

                old_pistol_obj.GetComponent<old_pistol>().laser_a_bool = true;

                old_pistol_obj.GetComponent<old_pistol>().change_equipment();

                destroy = true;

            }
            if (which == "lamp_laser_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);







                if (old_pistol_obj.GetComponent<old_pistol>().laser_a_bool)
                {
                    Drop("lamp_laser_a");
                }
                if (old_pistol_obj.GetComponent<old_pistol>().lamp_laser_a_bool)
                {
                    Drop("laser_a");
                }
                if (old_pistol_obj.GetComponent<old_pistol>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_b");
                }
                if (old_pistol_obj.GetComponent<old_pistol>().lamp_laser_a_bool)
                {
                    Drop("lamp_a");
                }


                old_pistol_obj.GetComponent<old_pistol>().laser_a_bool = false;
                old_pistol_obj.GetComponent<old_pistol>().lamp_laser_b_bool = false;
             

                old_pistol_obj.GetComponent<old_pistol>().lamp_laser_a_bool = true;

                old_pistol_obj.GetComponent<old_pistol>().change_equipment();

                destroy = true;

            }


            // changing scopes
            if (which == "red_dot_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (old_pistol_obj.GetComponent<old_pistol>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    old_pistol_obj.GetComponent<old_pistol>().red_dot_a_bool = false;
                }




                old_pistol_obj.GetComponent<old_pistol>().red_dot_a_bool = true;





                old_pistol_obj.GetComponent<old_pistol>().change_equipment();


            }





            if (which == "suppressor_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);


                destroy = true;


                if (old_pistol_obj.GetComponent<old_pistol>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    old_pistol_obj.GetComponent<old_pistol>().suppressor_a_bool = false;
                }

                if (old_pistol_obj.GetComponent<old_pistol>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    old_pistol_obj.GetComponent<old_pistol>().suppressor_c_bool = false;
                }

                if (old_pistol_obj.GetComponent<old_pistol>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    old_pistol_obj.GetComponent<old_pistol>().suppressor_d_bool = false;
                }

                old_pistol_obj.GetComponent<old_pistol>().suppressor_a_bool = true;

                old_pistol_obj.GetComponent<old_pistol>().change_equipment();



            }
            // suppresor b is just for one weapon useable
            if (which == "suppressor_c")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);




                destroy = true;

                if (old_pistol_obj.GetComponent<old_pistol>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    old_pistol_obj.GetComponent<old_pistol>().suppressor_a_bool = false;
                }

                if (old_pistol_obj.GetComponent<old_pistol>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    old_pistol_obj.GetComponent<old_pistol>().suppressor_c_bool = false;
                }

                if (old_pistol_obj.GetComponent<old_pistol>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    old_pistol_obj.GetComponent<old_pistol>().suppressor_d_bool = false;
                }

                old_pistol_obj.GetComponent<old_pistol>().suppressor_c_bool = true;

                old_pistol_obj.GetComponent<old_pistol>().change_equipment();



            }
            if (which == "suppressor_d")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);


                destroy = true;


                if (old_pistol_obj.GetComponent<old_pistol>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    old_pistol_obj.GetComponent<old_pistol>().suppressor_a_bool = false;
                }

                if (old_pistol_obj.GetComponent<old_pistol>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    old_pistol_obj.GetComponent<old_pistol>().suppressor_c_bool = false;
                }

                if (old_pistol_obj.GetComponent<old_pistol>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    old_pistol_obj.GetComponent<old_pistol>().suppressor_d_bool = false;
                }

                old_pistol_obj.GetComponent<old_pistol>().suppressor_d_bool = true;

                old_pistol_obj.GetComponent<old_pistol>().change_equipment();



            }

        }
        if (pistol9_bool)
        {


            // checking, what you picked up and determine it with a string check and turning off other equipment, if required to make the place for the new one free




            if (which == "lamp_laser_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);





                // same position, turning lamp_laser_b off

                if (pistol9_obj.GetComponent<pistol9>().laser_a_bool)
                {
                    Drop("lamp_laser_a");
                }
                if (pistol9_obj.GetComponent<pistol9>().lamp_laser_a_bool)
                {
                    Drop("laser_a");
                }
                if (pistol9_obj.GetComponent<pistol9>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_b");
                }
                if (pistol9_obj.GetComponent<pistol9>().lamp_laser_a_bool)
                {
                    Drop("lamp_a");
                }

                pistol9_obj.GetComponent<pistol9>().lamp_laser_a_bool = false;
                pistol9_obj.GetComponent<pistol9>().laser_a_bool = false;

                pistol9_obj.GetComponent<pistol9>().lamp_laser_b_bool = true;

                pistol9_obj.GetComponent<pistol9>().change_equipment();

                destroy = true;
            }
            if (which == "laser_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);







                if (pistol9_obj.GetComponent<pistol9>().laser_a_bool)
                {
                    Drop("lamp_laser_a");
                }
                if (pistol9_obj.GetComponent<pistol9>().lamp_laser_a_bool)
                {
                    Drop("laser_a");
                }
                if (pistol9_obj.GetComponent<pistol9>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_b");
                }
                if (pistol9_obj.GetComponent<pistol9>().lamp_laser_a_bool)
                {
                    Drop("lamp_a");
                }


                pistol9_obj.GetComponent<pistol9>().lamp_laser_a_bool = false;
                pistol9_obj.GetComponent<pistol9>().lamp_laser_b_bool = false;


                pistol9_obj.GetComponent<pistol9>().laser_a_bool = true;

                pistol9_obj.GetComponent<pistol9>().change_equipment();

                destroy = true;

            }
            if (which == "lamp_laser_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);







                if (pistol9_obj.GetComponent<pistol9>().laser_a_bool)
                {
                    Drop("lamp_laser_a");
                }
                if (pistol9_obj.GetComponent<pistol9>().lamp_laser_a_bool)
                {
                    Drop("laser_a");
                }
                if (pistol9_obj.GetComponent<pistol9>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_b");
                }
                if (pistol9_obj.GetComponent<pistol9>().lamp_laser_a_bool)
                {
                    Drop("lamp_a");
                }


                pistol9_obj.GetComponent<pistol9>().laser_a_bool = false;
                pistol9_obj.GetComponent<pistol9>().lamp_laser_b_bool = false;


                pistol9_obj.GetComponent<pistol9>().lamp_laser_a_bool = true;

                pistol9_obj.GetComponent<pistol9>().change_equipment();

                destroy = true;

            }


            // changing scopes
            if (which == "red_dot_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (pistol9_obj.GetComponent<pistol9>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    pistol9_obj.GetComponent<pistol9>().red_dot_a_bool = false;
                }




                pistol9_obj.GetComponent<pistol9>().red_dot_a_bool = true;





                pistol9_obj.GetComponent<pistol9>().change_equipment();


            }





            if (which == "suppressor_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);


                destroy = true;


                if (pistol9_obj.GetComponent<pistol9>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    pistol9_obj.GetComponent<pistol9>().suppressor_a_bool = false;
                }

                if (pistol9_obj.GetComponent<pistol9>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    pistol9_obj.GetComponent<pistol9>().suppressor_c_bool = false;
                }

                if (pistol9_obj.GetComponent<pistol9>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    pistol9_obj.GetComponent<pistol9>().suppressor_d_bool = false;
                }

                pistol9_obj.GetComponent<pistol9>().suppressor_a_bool = true;

                pistol9_obj.GetComponent<pistol9>().change_equipment();



            }
            // suppresor b is just for one weapon useable
            if (which == "suppressor_c")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);




                destroy = true;

                if (pistol9_obj.GetComponent<pistol9>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    pistol9_obj.GetComponent<pistol9>().suppressor_a_bool = false;
                }

                if (pistol9_obj.GetComponent<pistol9>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    pistol9_obj.GetComponent<pistol9>().suppressor_c_bool = false;
                }

                if (pistol9_obj.GetComponent<pistol9>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    pistol9_obj.GetComponent<pistol9>().suppressor_d_bool = false;
                }

                pistol9_obj.GetComponent<pistol9>().suppressor_c_bool = true;

                pistol9_obj.GetComponent<pistol9>().change_equipment();



            }
            if (which == "suppressor_d")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);


                destroy = true;


                if (pistol9_obj.GetComponent<pistol9>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    pistol9_obj.GetComponent<pistol9>().suppressor_a_bool = false;
                }

                if (pistol9_obj.GetComponent<pistol9>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    pistol9_obj.GetComponent<pistol9>().suppressor_c_bool = false;
                }

                if (pistol9_obj.GetComponent<pistol9>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    pistol9_obj.GetComponent<pistol9>().suppressor_d_bool = false;
                }

                pistol9_obj.GetComponent<pistol9>().suppressor_d_bool = true;

                pistol9_obj.GetComponent<pistol9>().change_equipment();



            }

        }
        if (pumpgun_a_bool)
        {


            // checking, what you picked up and determine it with a string check and turning off other equipment, if required to make the place for the new one free




            if (which == "lamp_laser_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);





                // same position, turning lamp_laser_b off

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().laser_a_bool)
                {
                    Drop("lamp_laser_a");
                }
                if (pumpgun_a_obj.GetComponent<pumpgun_a>().lamp_laser_a_bool)
                {
                    Drop("laser_a");
                }
                if (pumpgun_a_obj.GetComponent<pumpgun_a>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_b");
                }
                if (pumpgun_a_obj.GetComponent<pumpgun_a>().lamp_a_bool)
                {
                    Drop("lamp_a");
                }

                pumpgun_a_obj.GetComponent<pumpgun_a>().lamp_laser_a_bool = false;
                pumpgun_a_obj.GetComponent<pumpgun_a>().laser_a_bool = false;
                pumpgun_a_obj.GetComponent<pumpgun_a>().lamp_a_bool = false;

                pumpgun_a_obj.GetComponent<pumpgun_a>().lamp_laser_b_bool = true;

                pumpgun_a_obj.GetComponent<pumpgun_a>().change_equipment();

                destroy = true;
            }
            if (which == "laser_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);







                if (pumpgun_a_obj.GetComponent<pumpgun_a>().laser_a_bool)
                {
                    Drop("lamp_laser_a");
                }
                if (pumpgun_a_obj.GetComponent<pumpgun_a>().lamp_laser_a_bool)
                {
                    Drop("laser_a");
                }
                if (pumpgun_a_obj.GetComponent<pumpgun_a>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_b");
                }
                if (pumpgun_a_obj.GetComponent<pumpgun_a>().lamp_a_bool)
                {
                    Drop("lamp_a");
                }


                pumpgun_a_obj.GetComponent<pumpgun_a>().lamp_laser_a_bool = false;
                pumpgun_a_obj.GetComponent<pumpgun_a>().lamp_laser_b_bool = false;
                pumpgun_a_obj.GetComponent<pumpgun_a>().lamp_a_bool = false;

                pumpgun_a_obj.GetComponent<pumpgun_a>().laser_a_bool = true;

                pumpgun_a_obj.GetComponent<pumpgun_a>().change_equipment();

                destroy = true;

            }
            if (which == "lamp_laser_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);







                if (pumpgun_a_obj.GetComponent<pumpgun_a>().laser_a_bool)
                {
                    Drop("lamp_laser_a");
                }
                if (pumpgun_a_obj.GetComponent<pumpgun_a>().lamp_laser_a_bool)
                {
                    Drop("laser_a");
                }
                if (pumpgun_a_obj.GetComponent<pumpgun_a>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_b");
                }
                if (pumpgun_a_obj.GetComponent<pumpgun_a>().lamp_a_bool)
                {
                    Drop("lamp_a");
                }


                pumpgun_a_obj.GetComponent<pumpgun_a>().laser_a_bool = false;
                pumpgun_a_obj.GetComponent<pumpgun_a>().lamp_laser_b_bool = false;
                pumpgun_a_obj.GetComponent<pumpgun_a>().lamp_a_bool = false;

                pumpgun_a_obj.GetComponent<pumpgun_a>().lamp_laser_a_bool = true;

                pumpgun_a_obj.GetComponent<pumpgun_a>().change_equipment();

                destroy = true;

            }
            if (which == "lamp_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);







                if (pumpgun_a_obj.GetComponent<pumpgun_a>().laser_a_bool)
                {
                    Drop("lamp_laser_a");
                }
                if (pumpgun_a_obj.GetComponent<pumpgun_a>().lamp_laser_a_bool)
                {
                    Drop("laser_a");
                }
                if (pumpgun_a_obj.GetComponent<pumpgun_a>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_b");
                }
                if (pumpgun_a_obj.GetComponent<pumpgun_a>().lamp_a_bool)
                {
                    Drop("lamp_a");
                }


                pumpgun_a_obj.GetComponent<pumpgun_a>().laser_a_bool = false;
                pumpgun_a_obj.GetComponent<pumpgun_a>().lamp_laser_b_bool = false;
                pumpgun_a_obj.GetComponent<pumpgun_a>().lamp_laser_a_bool = false;

                pumpgun_a_obj.GetComponent<pumpgun_a>().lamp_a_bool = true;

                pumpgun_a_obj.GetComponent<pumpgun_a>().change_equipment();

                destroy = true;

            }

            // changing scopes

            if (which == "red_dot_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_a_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_b_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_c_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_d_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_e_bool = false;
                }



                if (pumpgun_a_obj.GetComponent<pumpgun_a>().scope_a_bool)
                {
                    Drop("scope_a");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().scope_a_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().scope_b_bool)
                {
                    Drop("scope_b");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().scope_b_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().scope_c_bool)
                {
                    Drop("scope_c");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().scope_c_bool = false;
                }

      

       

                pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_a_bool = true;





                pumpgun_a_obj.GetComponent<pumpgun_a>().change_equipment();


            }
            if (which == "red_dot_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_a_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_b_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_c_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_d_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_e_bool = false;
                }



                if (pumpgun_a_obj.GetComponent<pumpgun_a>().scope_a_bool)
                {
                    Drop("scope_a");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().scope_a_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().scope_b_bool)
                {
                    Drop("scope_b");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().scope_b_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().scope_c_bool)
                {
                    Drop("scope_c");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().scope_c_bool = false;
                }


            

                pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_b_bool = true;





                pumpgun_a_obj.GetComponent<pumpgun_a>().change_equipment();


            }
            if (which == "red_dot_c")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_a_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_b_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_c_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_d_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_e_bool = false;
                }



                if (pumpgun_a_obj.GetComponent<pumpgun_a>().scope_a_bool)
                {
                    Drop("scope_a");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().scope_a_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().scope_b_bool)
                {
                    Drop("scope_b");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().scope_b_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().scope_c_bool)
                {
                    Drop("scope_c");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().scope_c_bool = false;
                }


                

                pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_c_bool = true;





                pumpgun_a_obj.GetComponent<pumpgun_a>().change_equipment();


            }
            if (which == "red_dot_d")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_a_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_b_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_c_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_d_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_e_bool = false;
                }



                if (pumpgun_a_obj.GetComponent<pumpgun_a>().scope_a_bool)
                {
                    Drop("scope_a");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().scope_a_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().scope_b_bool)
                {
                    Drop("scope_b");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().scope_b_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().scope_c_bool)
                {
                    Drop("scope_c");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().scope_c_bool = false;
                }


              

                pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_d_bool = true;





                pumpgun_a_obj.GetComponent<pumpgun_a>().change_equipment();


            }
            if (which == "red_dot_e")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_a_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_b_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_c_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_d_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_e_bool = false;
                }



                if (pumpgun_a_obj.GetComponent<pumpgun_a>().scope_a_bool)
                {
                    Drop("scope_a");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().scope_a_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().scope_b_bool)
                {
                    Drop("scope_b");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().scope_b_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().scope_c_bool)
                {
                    Drop("scope_c");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().scope_c_bool = false;
                }


      

                pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_e_bool = true;





                pumpgun_a_obj.GetComponent<pumpgun_a>().change_equipment();


            }
            if (which == "scope_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_a_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_b_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_c_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_d_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_e_bool = false;
                }



                if (pumpgun_a_obj.GetComponent<pumpgun_a>().scope_a_bool)
                {
                    Drop("scope_a");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().scope_a_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().scope_b_bool)
                {
                    Drop("scope_b");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().scope_b_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().scope_c_bool)
                {
                    Drop("scope_c");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().scope_c_bool = false;
                }


              

                pumpgun_a_obj.GetComponent<pumpgun_a>().scope_a_bool = true;





                pumpgun_a_obj.GetComponent<pumpgun_a>().change_equipment();


            }
            if (which == "scope_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_a_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_b_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_c_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_d_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_e_bool = false;
                }



                if (pumpgun_a_obj.GetComponent<pumpgun_a>().scope_a_bool)
                {
                    Drop("scope_a");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().scope_a_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().scope_b_bool)
                {
                    Drop("scope_b");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().scope_b_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().scope_c_bool)
                {
                    Drop("scope_c");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().scope_c_bool = false;
                }


       

                pumpgun_a_obj.GetComponent<pumpgun_a>().scope_b_bool = true;





                pumpgun_a_obj.GetComponent<pumpgun_a>().change_equipment();


            }
            if (which == "scope_c")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_a_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_b_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_c_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_d_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().red_dot_e_bool = false;
                }



                if (pumpgun_a_obj.GetComponent<pumpgun_a>().scope_a_bool)
                {
                    Drop("scope_a");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().scope_a_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().scope_b_bool)
                {
                    Drop("scope_b");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().scope_b_bool = false;
                }

                if (pumpgun_a_obj.GetComponent<pumpgun_a>().scope_c_bool)
                {
                    Drop("scope_c");
                    pumpgun_a_obj.GetComponent<pumpgun_a>().scope_c_bool = false;
                }


               

                pumpgun_a_obj.GetComponent<pumpgun_a>().scope_c_bool = true;





                pumpgun_a_obj.GetComponent<pumpgun_a>().change_equipment();


            }





        }
        if (rp9_bool)
        {


            // checking, what you picked up and determine it with a string check and turning off other equipment, if required to make the place for the new one free




            if (which == "lamp_laser_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);





                // same position, turning lamp_laser_b off

                if (rp9_obj.GetComponent<rp9>().laser_a_bool)
                {
                    Drop("lamp_laser_a");
                }
                if (rp9_obj.GetComponent<rp9>().lamp_laser_a_bool)
                {
                    Drop("laser_a");
                }
                if (rp9_obj.GetComponent<rp9>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_b");
                }
                if (rp9_obj.GetComponent<rp9>().lamp_laser_a_bool)
                {
                    Drop("lamp_a");
                }

                rp9_obj.GetComponent<rp9>().lamp_laser_a_bool = false;
                rp9_obj.GetComponent<rp9>().laser_a_bool = false;

                rp9_obj.GetComponent<rp9>().lamp_laser_b_bool = true;

                rp9_obj.GetComponent<rp9>().change_equipment();

                destroy = true;
            }
            if (which == "laser_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);







                if (rp9_obj.GetComponent<rp9>().laser_a_bool)
                {
                    Drop("lamp_laser_a");
                }
                if (rp9_obj.GetComponent<rp9>().lamp_laser_a_bool)
                {
                    Drop("laser_a");
                }
                if (rp9_obj.GetComponent<rp9>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_b");
                }
                if (rp9_obj.GetComponent<rp9>().lamp_laser_a_bool)
                {
                    Drop("lamp_a");
                }


                rp9_obj.GetComponent<rp9>().lamp_laser_a_bool = false;
                rp9_obj.GetComponent<rp9>().lamp_laser_b_bool = false;


                rp9_obj.GetComponent<rp9>().laser_a_bool = true;

                rp9_obj.GetComponent<rp9>().change_equipment();

                destroy = true;

            }
            if (which == "lamp_laser_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);







                if (rp9_obj.GetComponent<rp9>().laser_a_bool)
                {
                    Drop("lamp_laser_a");
                }
                if (rp9_obj.GetComponent<rp9>().lamp_laser_a_bool)
                {
                    Drop("laser_a");
                }
                if (rp9_obj.GetComponent<rp9>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_b");
                }
                if (rp9_obj.GetComponent<rp9>().lamp_laser_a_bool)
                {
                    Drop("lamp_a");
                }


                rp9_obj.GetComponent<rp9>().laser_a_bool = false;
                rp9_obj.GetComponent<rp9>().lamp_laser_b_bool = false;


                rp9_obj.GetComponent<rp9>().lamp_laser_a_bool = true;

                rp9_obj.GetComponent<rp9>().change_equipment();

                destroy = true;

            }


            // changing scopes
            if (which == "red_dot_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (rp9_obj.GetComponent<rp9>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    rp9_obj.GetComponent<rp9>().red_dot_a_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    rp9_obj.GetComponent<rp9>().red_dot_b_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    rp9_obj.GetComponent<rp9>().red_dot_c_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    rp9_obj.GetComponent<rp9>().red_dot_d_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    rp9_obj.GetComponent<rp9>().red_dot_e_bool = false;
                }



                if (rp9_obj.GetComponent<rp9>().scope_a_bool)
                {
                    Drop("scope_a");
                    rp9_obj.GetComponent<rp9>().scope_a_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().scope_b_bool)
                {
                    Drop("scope_b");
                    rp9_obj.GetComponent<rp9>().scope_b_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().scope_c_bool)
                {
                    Drop("scope_c");
                    rp9_obj.GetComponent<rp9>().scope_c_bool = false;
                }




                rp9_obj.GetComponent<rp9>().red_dot_a_bool = true;





                rp9_obj.GetComponent<rp9>().change_equipment();


            }
            if (which == "red_dot_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (rp9_obj.GetComponent<rp9>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    rp9_obj.GetComponent<rp9>().red_dot_a_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    rp9_obj.GetComponent<rp9>().red_dot_b_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    rp9_obj.GetComponent<rp9>().red_dot_c_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    rp9_obj.GetComponent<rp9>().red_dot_d_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    rp9_obj.GetComponent<rp9>().red_dot_e_bool = false;
                }



                if (rp9_obj.GetComponent<rp9>().scope_a_bool)
                {
                    Drop("scope_a");
                    rp9_obj.GetComponent<rp9>().scope_a_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().scope_b_bool)
                {
                    Drop("scope_b");
                    rp9_obj.GetComponent<rp9>().scope_b_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().scope_c_bool)
                {
                    Drop("scope_c");
                    rp9_obj.GetComponent<rp9>().scope_c_bool = false;
                }


           

                rp9_obj.GetComponent<rp9>().red_dot_b_bool = true;





                rp9_obj.GetComponent<rp9>().change_equipment();


            }
            if (which == "red_dot_c")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (rp9_obj.GetComponent<rp9>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    rp9_obj.GetComponent<rp9>().red_dot_a_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    rp9_obj.GetComponent<rp9>().red_dot_b_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    rp9_obj.GetComponent<rp9>().red_dot_c_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    rp9_obj.GetComponent<rp9>().red_dot_d_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    rp9_obj.GetComponent<rp9>().red_dot_e_bool = false;
                }



                if (rp9_obj.GetComponent<rp9>().scope_a_bool)
                {
                    Drop("scope_a");
                    rp9_obj.GetComponent<rp9>().scope_a_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().scope_b_bool)
                {
                    Drop("scope_b");
                    rp9_obj.GetComponent<rp9>().scope_b_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().scope_c_bool)
                {
                    Drop("scope_c");
                    rp9_obj.GetComponent<rp9>().scope_c_bool = false;
                }


              

                rp9_obj.GetComponent<rp9>().red_dot_c_bool = true;





                rp9_obj.GetComponent<rp9>().change_equipment();


            }
            if (which == "red_dot_d")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (rp9_obj.GetComponent<rp9>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    rp9_obj.GetComponent<rp9>().red_dot_a_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    rp9_obj.GetComponent<rp9>().red_dot_b_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    rp9_obj.GetComponent<rp9>().red_dot_c_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    rp9_obj.GetComponent<rp9>().red_dot_d_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    rp9_obj.GetComponent<rp9>().red_dot_e_bool = false;
                }



                if (rp9_obj.GetComponent<rp9>().scope_a_bool)
                {
                    Drop("scope_a");
                    rp9_obj.GetComponent<rp9>().scope_a_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().scope_b_bool)
                {
                    Drop("scope_b");
                    rp9_obj.GetComponent<rp9>().scope_b_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().scope_c_bool)
                {
                    Drop("scope_c");
                    rp9_obj.GetComponent<rp9>().scope_c_bool = false;
                }


                

                rp9_obj.GetComponent<rp9>().red_dot_d_bool = true;





                rp9_obj.GetComponent<rp9>().change_equipment();


            }
            if (which == "red_dot_e")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (rp9_obj.GetComponent<rp9>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    rp9_obj.GetComponent<rp9>().red_dot_a_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    rp9_obj.GetComponent<rp9>().red_dot_b_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    rp9_obj.GetComponent<rp9>().red_dot_c_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    rp9_obj.GetComponent<rp9>().red_dot_d_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    rp9_obj.GetComponent<rp9>().red_dot_e_bool = false;
                }



                if (rp9_obj.GetComponent<rp9>().scope_a_bool)
                {
                    Drop("scope_a");
                    rp9_obj.GetComponent<rp9>().scope_a_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().scope_b_bool)
                {
                    Drop("scope_b");
                    rp9_obj.GetComponent<rp9>().scope_b_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().scope_c_bool)
                {
                    Drop("scope_c");
                    rp9_obj.GetComponent<rp9>().scope_c_bool = false;
                }


            
                rp9_obj.GetComponent<rp9>().red_dot_e_bool = true;





                rp9_obj.GetComponent<rp9>().change_equipment();


            }
            if (which == "scope_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (rp9_obj.GetComponent<rp9>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    rp9_obj.GetComponent<rp9>().red_dot_a_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    rp9_obj.GetComponent<rp9>().red_dot_b_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    rp9_obj.GetComponent<rp9>().red_dot_c_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    rp9_obj.GetComponent<rp9>().red_dot_d_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    rp9_obj.GetComponent<rp9>().red_dot_e_bool = false;
                }



                if (rp9_obj.GetComponent<rp9>().scope_a_bool)
                {
                    Drop("scope_a");
                    rp9_obj.GetComponent<rp9>().scope_a_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().scope_b_bool)
                {
                    Drop("scope_b");
                    rp9_obj.GetComponent<rp9>().scope_b_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().scope_c_bool)
                {
                    Drop("scope_c");
                    rp9_obj.GetComponent<rp9>().scope_c_bool = false;
                }


          

                rp9_obj.GetComponent<rp9>().scope_a_bool = true;





                rp9_obj.GetComponent<rp9>().change_equipment();


            }
            if (which == "scope_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (rp9_obj.GetComponent<rp9>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    rp9_obj.GetComponent<rp9>().red_dot_a_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    rp9_obj.GetComponent<rp9>().red_dot_b_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    rp9_obj.GetComponent<rp9>().red_dot_c_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    rp9_obj.GetComponent<rp9>().red_dot_d_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    rp9_obj.GetComponent<rp9>().red_dot_e_bool = false;
                }



                if (rp9_obj.GetComponent<rp9>().scope_a_bool)
                {
                    Drop("scope_a");
                    rp9_obj.GetComponent<rp9>().scope_a_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().scope_b_bool)
                {
                    Drop("scope_b");
                    rp9_obj.GetComponent<rp9>().scope_b_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().scope_c_bool)
                {
                    Drop("scope_c");
                    rp9_obj.GetComponent<rp9>().scope_c_bool = false;
                }


           

                rp9_obj.GetComponent<rp9>().scope_b_bool = true;





                rp9_obj.GetComponent<rp9>().change_equipment();


            }
            if (which == "scope_c")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (rp9_obj.GetComponent<rp9>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    rp9_obj.GetComponent<rp9>().red_dot_a_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    rp9_obj.GetComponent<rp9>().red_dot_b_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    rp9_obj.GetComponent<rp9>().red_dot_c_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    rp9_obj.GetComponent<rp9>().red_dot_d_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    rp9_obj.GetComponent<rp9>().red_dot_e_bool = false;
                }



                if (rp9_obj.GetComponent<rp9>().scope_a_bool)
                {
                    Drop("scope_a");
                    rp9_obj.GetComponent<rp9>().scope_a_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().scope_b_bool)
                {
                    Drop("scope_b");
                    rp9_obj.GetComponent<rp9>().scope_b_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().scope_c_bool)
                {
                    Drop("scope_c");
                    rp9_obj.GetComponent<rp9>().scope_c_bool = false;
                }



           

                rp9_obj.GetComponent<rp9>().scope_c_bool = true;





                rp9_obj.GetComponent<rp9>().change_equipment();


            }



            if (which == "suppressor_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);


                destroy = true;


                if (rp9_obj.GetComponent<rp9>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    rp9_obj.GetComponent<rp9>().suppressor_a_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    rp9_obj.GetComponent<rp9>().suppressor_c_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    rp9_obj.GetComponent<rp9>().suppressor_d_bool = false;
                }

                rp9_obj.GetComponent<rp9>().suppressor_a_bool = true;

                rp9_obj.GetComponent<rp9>().change_equipment();



            }
            // suppresor b is just for one weapon useable
            if (which == "suppressor_c")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);




                destroy = true;

                if (rp9_obj.GetComponent<rp9>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    rp9_obj.GetComponent<rp9>().suppressor_a_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    rp9_obj.GetComponent<rp9>().suppressor_c_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    rp9_obj.GetComponent<rp9>().suppressor_d_bool = false;
                }

                rp9_obj.GetComponent<rp9>().suppressor_c_bool = true;

                rp9_obj.GetComponent<rp9>().change_equipment();



            }
            if (which == "suppressor_d")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);


                destroy = true;


                if (rp9_obj.GetComponent<rp9>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    rp9_obj.GetComponent<rp9>().suppressor_a_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    rp9_obj.GetComponent<rp9>().suppressor_c_bool = false;
                }

                if (rp9_obj.GetComponent<rp9>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    rp9_obj.GetComponent<rp9>().suppressor_d_bool = false;
                }

                rp9_obj.GetComponent<rp9>().suppressor_d_bool = true;

                rp9_obj.GetComponent<rp9>().change_equipment();



            }

        }
        if (sce5_bool)
        {


            // checking, what you picked up and determine it with a string check and turning off other equipment, if required to make the place for the new one free



            // left side of holder
            if (which == "lamp_a")
            {

                AudioSource.PlayClipAtPoint(click, transform.position);
         
                destroy = true;

                sce5_obj.GetComponent<sce5>().lamp_a_bool = true;

                // same position, turning lamp_laser_b off

                if (sce5_obj.GetComponent<sce5>().lamp_laser_b_bool)
                {
                    Drop("lamp_laser_b");
                }


                sce5_obj.GetComponent<sce5>().lamp_laser_b_bool = false;

                sce5_obj.GetComponent<sce5>().change_equipment();


            }
            if (which == "lamp_laser_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);
              
                destroy = true;

                sce5_obj.GetComponent<sce5>().lamp_laser_b_bool = true;

                // same position, turning lamp_laser_b off

                if (sce5_obj.GetComponent<sce5>().lamp_a_bool)
                {
                    Drop("lamp_a");

                    sce5_obj.GetComponent<sce5>().lamp_a_bool = false;
                }




                sce5_obj.GetComponent<sce5>().change_equipment();


            }


            // right side of holder
            if (which == "laser_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);
          
                destroy = true;

                sce5_obj.GetComponent<sce5>().laser_a_bool = true;



                if (sce5_obj.GetComponent<sce5>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_a");

                    sce5_obj.GetComponent<sce5>().lamp_laser_a_bool = false;
                }




                sce5_obj.GetComponent<sce5>().change_equipment();



            }
            if (which == "lamp_laser_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);
           
                destroy = true;

                sce5_obj.GetComponent<sce5>().lamp_laser_a_bool = true;



                if (sce5_obj.GetComponent<sce5>().laser_a_bool)
                {
                    Drop("lamp_laser_a");

                    sce5_obj.GetComponent<sce5>().laser_a_bool = false;
                }




                sce5_obj.GetComponent<sce5>().change_equipment();



            }


            // changing scopes
            if (which == "red_dot_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (sce5_obj.GetComponent<sce5>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    sce5_obj.GetComponent<sce5>().red_dot_a_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    sce5_obj.GetComponent<sce5>().red_dot_b_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    sce5_obj.GetComponent<sce5>().red_dot_c_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    sce5_obj.GetComponent<sce5>().red_dot_d_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    sce5_obj.GetComponent<sce5>().red_dot_e_bool = false;
                }



                if (sce5_obj.GetComponent<sce5>().scope_a_bool)
                {
                    Drop("scope_a");
                    sce5_obj.GetComponent<sce5>().scope_a_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().scope_b_bool)
                {
                    Drop("scope_b");
                    sce5_obj.GetComponent<sce5>().scope_b_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().scope_c_bool)
                {
                    Drop("scope_c");
                    sce5_obj.GetComponent<sce5>().scope_c_bool = false;
                }

                Debug.Log("worked");

      

                sce5_obj.GetComponent<sce5>().red_dot_a_bool = true;





                sce5_obj.GetComponent<sce5>().change_equipment();


            }
            if (which == "red_dot_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (sce5_obj.GetComponent<sce5>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    sce5_obj.GetComponent<sce5>().red_dot_a_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    sce5_obj.GetComponent<sce5>().red_dot_b_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    sce5_obj.GetComponent<sce5>().red_dot_c_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    sce5_obj.GetComponent<sce5>().red_dot_d_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    sce5_obj.GetComponent<sce5>().red_dot_e_bool = false;
                }



                if (sce5_obj.GetComponent<sce5>().scope_a_bool)
                {
                    Drop("scope_a");
                    sce5_obj.GetComponent<sce5>().scope_a_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().scope_b_bool)
                {
                    Drop("scope_b");
                    sce5_obj.GetComponent<sce5>().scope_b_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().scope_c_bool)
                {
                    Drop("scope_c");
                    sce5_obj.GetComponent<sce5>().scope_c_bool = false;
                }


          

                sce5_obj.GetComponent<sce5>().red_dot_b_bool = true;





                sce5_obj.GetComponent<sce5>().change_equipment();


            }
            if (which == "red_dot_c")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (sce5_obj.GetComponent<sce5>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    sce5_obj.GetComponent<sce5>().red_dot_a_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    sce5_obj.GetComponent<sce5>().red_dot_b_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    sce5_obj.GetComponent<sce5>().red_dot_c_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    sce5_obj.GetComponent<sce5>().red_dot_d_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    sce5_obj.GetComponent<sce5>().red_dot_e_bool = false;
                }



                if (sce5_obj.GetComponent<sce5>().scope_a_bool)
                {
                    Drop("scope_a");
                    sce5_obj.GetComponent<sce5>().scope_a_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().scope_b_bool)
                {
                    Drop("scope_b");
                    sce5_obj.GetComponent<sce5>().scope_b_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().scope_c_bool)
                {
                    Drop("scope_c");
                    sce5_obj.GetComponent<sce5>().scope_c_bool = false;
                }


    

                sce5_obj.GetComponent<sce5>().red_dot_c_bool = true;





                sce5_obj.GetComponent<sce5>().change_equipment();


            }
            if (which == "red_dot_d")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (sce5_obj.GetComponent<sce5>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    sce5_obj.GetComponent<sce5>().red_dot_a_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    sce5_obj.GetComponent<sce5>().red_dot_b_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    sce5_obj.GetComponent<sce5>().red_dot_c_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    sce5_obj.GetComponent<sce5>().red_dot_d_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    sce5_obj.GetComponent<sce5>().red_dot_e_bool = false;
                }



                if (sce5_obj.GetComponent<sce5>().scope_a_bool)
                {
                    Drop("scope_a");
                    sce5_obj.GetComponent<sce5>().scope_a_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().scope_b_bool)
                {
                    Drop("scope_b");
                    sce5_obj.GetComponent<sce5>().scope_b_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().scope_c_bool)
                {
                    Drop("scope_c");
                    sce5_obj.GetComponent<sce5>().scope_c_bool = false;
                }


    

                sce5_obj.GetComponent<sce5>().red_dot_d_bool = true;





                sce5_obj.GetComponent<sce5>().change_equipment();


            }
            if (which == "red_dot_e")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (sce5_obj.GetComponent<sce5>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    sce5_obj.GetComponent<sce5>().red_dot_a_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    sce5_obj.GetComponent<sce5>().red_dot_b_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    sce5_obj.GetComponent<sce5>().red_dot_c_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    sce5_obj.GetComponent<sce5>().red_dot_d_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    sce5_obj.GetComponent<sce5>().red_dot_e_bool = false;
                }



                if (sce5_obj.GetComponent<sce5>().scope_a_bool)
                {
                    Drop("scope_a");
                    sce5_obj.GetComponent<sce5>().scope_a_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().scope_b_bool)
                {
                    Drop("scope_b");
                    sce5_obj.GetComponent<sce5>().scope_b_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().scope_c_bool)
                {
                    Drop("scope_c");
                    sce5_obj.GetComponent<sce5>().scope_c_bool = false;
                }



                sce5_obj.GetComponent<sce5>().red_dot_e_bool = true;





                sce5_obj.GetComponent<sce5>().change_equipment();


            }
            if (which == "scope_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (sce5_obj.GetComponent<sce5>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    sce5_obj.GetComponent<sce5>().red_dot_a_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    sce5_obj.GetComponent<sce5>().red_dot_b_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    sce5_obj.GetComponent<sce5>().red_dot_c_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    sce5_obj.GetComponent<sce5>().red_dot_d_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    sce5_obj.GetComponent<sce5>().red_dot_e_bool = false;
                }



                if (sce5_obj.GetComponent<sce5>().scope_a_bool)
                {
                    Drop("scope_a");
                    sce5_obj.GetComponent<sce5>().scope_a_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().scope_b_bool)
                {
                    Drop("scope_b");
                    sce5_obj.GetComponent<sce5>().scope_b_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().scope_c_bool)
                {
                    Drop("scope_c");
                    sce5_obj.GetComponent<sce5>().scope_c_bool = false;
                }



                sce5_obj.GetComponent<sce5>().scope_a_bool = true;





                sce5_obj.GetComponent<sce5>().change_equipment();


            }
            if (which == "scope_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (sce5_obj.GetComponent<sce5>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    sce5_obj.GetComponent<sce5>().red_dot_a_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    sce5_obj.GetComponent<sce5>().red_dot_b_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    sce5_obj.GetComponent<sce5>().red_dot_c_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    sce5_obj.GetComponent<sce5>().red_dot_d_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    sce5_obj.GetComponent<sce5>().red_dot_e_bool = false;
                }



                if (sce5_obj.GetComponent<sce5>().scope_a_bool)
                {
                    Drop("scope_a");
                    sce5_obj.GetComponent<sce5>().scope_a_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().scope_b_bool)
                {
                    Drop("scope_b");
                    sce5_obj.GetComponent<sce5>().scope_b_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().scope_c_bool)
                {
                    Drop("scope_c");
                    sce5_obj.GetComponent<sce5>().scope_c_bool = false;
                }


             
                sce5_obj.GetComponent<sce5>().scope_b_bool = true;





                sce5_obj.GetComponent<sce5>().change_equipment();


            }
            if (which == "scope_c")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (sce5_obj.GetComponent<sce5>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    sce5_obj.GetComponent<sce5>().red_dot_a_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    sce5_obj.GetComponent<sce5>().red_dot_b_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    sce5_obj.GetComponent<sce5>().red_dot_c_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    sce5_obj.GetComponent<sce5>().red_dot_d_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    sce5_obj.GetComponent<sce5>().red_dot_e_bool = false;
                }



                if (sce5_obj.GetComponent<sce5>().scope_a_bool)
                {
                    Drop("scope_a");
                    sce5_obj.GetComponent<sce5>().scope_a_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().scope_b_bool)
                {
                    Drop("scope_b");
                    sce5_obj.GetComponent<sce5>().scope_b_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().scope_c_bool)
                {
                    Drop("scope_c");
                    sce5_obj.GetComponent<sce5>().scope_c_bool = false;
                }


            

                sce5_obj.GetComponent<sce5>().scope_c_bool = true;





                sce5_obj.GetComponent<sce5>().change_equipment();


            }



            if (which == "suppressor_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);


                destroy = true;


                if (sce5_obj.GetComponent<sce5>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    sce5_obj.GetComponent<sce5>().suppressor_a_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    sce5_obj.GetComponent<sce5>().suppressor_c_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    sce5_obj.GetComponent<sce5>().suppressor_d_bool = false;
                }

                sce5_obj.GetComponent<sce5>().suppressor_a_bool = true;

                sce5_obj.GetComponent<sce5>().change_equipment();



            }
            // suppresor b is just for one weapon useable
            if (which == "suppressor_c")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);




                destroy = true;

                if (sce5_obj.GetComponent<sce5>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    sce5_obj.GetComponent<sce5>().suppressor_a_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    sce5_obj.GetComponent<sce5>().suppressor_c_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    sce5_obj.GetComponent<sce5>().suppressor_d_bool = false;
                }

                sce5_obj.GetComponent<sce5>().suppressor_c_bool = true;

                sce5_obj.GetComponent<sce5>().change_equipment();



            }
            if (which == "suppressor_d")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);


                destroy = true;


                if (sce5_obj.GetComponent<sce5>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    sce5_obj.GetComponent<sce5>().suppressor_a_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    sce5_obj.GetComponent<sce5>().suppressor_c_bool = false;
                }

                if (sce5_obj.GetComponent<sce5>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    sce5_obj.GetComponent<sce5>().suppressor_d_bool = false;
                }

                sce5_obj.GetComponent<sce5>().suppressor_d_bool = true;

                sce5_obj.GetComponent<sce5>().change_equipment();



            }

        }
        if (scorp6_bool)
        {


            // checking, what you picked up and determine it with a string check and turning off other equipment, if required to make the place for the new one free




            // left side of holder
            if (which == "lamp_laser_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);





                // same position, turning lamp_laser_b off

                if (scorp6_obj.GetComponent<scorp6>().laser_a_bool)
                {
                    Drop("lamp_laser_a");
                }
                if (scorp6_obj.GetComponent<scorp6>().lamp_laser_a_bool)
                {
                    Drop("laser_a");
                }
                if (scorp6_obj.GetComponent<scorp6>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_b");
                }
                if (scorp6_obj.GetComponent<scorp6>().lamp_laser_a_bool)
                {
                    Drop("lamp_a");
                }

                scorp6_obj.GetComponent<scorp6>().lamp_laser_a_bool = false;
                scorp6_obj.GetComponent<scorp6>().laser_a_bool = false;

                scorp6_obj.GetComponent<scorp6>().lamp_laser_b_bool = true;

                scorp6_obj.GetComponent<scorp6>().change_equipment();

                destroy = true;
            }
            if (which == "laser_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);







                if (scorp6_obj.GetComponent<scorp6>().laser_a_bool)
                {
                    Drop("lamp_laser_a");
                }
                if (scorp6_obj.GetComponent<scorp6>().lamp_laser_a_bool)
                {
                    Drop("laser_a");
                }
                if (scorp6_obj.GetComponent<scorp6>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_b");
                }
                if (scorp6_obj.GetComponent<scorp6>().lamp_laser_a_bool)
                {
                    Drop("lamp_a");
                }


                scorp6_obj.GetComponent<scorp6>().lamp_laser_a_bool = false;
                scorp6_obj.GetComponent<scorp6>().lamp_laser_b_bool = false;


                scorp6_obj.GetComponent<scorp6>().laser_a_bool = true;

                scorp6_obj.GetComponent<scorp6>().change_equipment();

                destroy = true;

            }
            if (which == "lamp_laser_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);







                if (scorp6_obj.GetComponent<scorp6>().laser_a_bool)
                {
                    Drop("lamp_laser_a");
                }
                if (scorp6_obj.GetComponent<scorp6>().lamp_laser_a_bool)
                {
                    Drop("laser_a");
                }
                if (scorp6_obj.GetComponent<scorp6>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_b");
                }
                if (scorp6_obj.GetComponent<scorp6>().lamp_laser_a_bool)
                {
                    Drop("lamp_a");
                }


                scorp6_obj.GetComponent<scorp6>().laser_a_bool = false;
                scorp6_obj.GetComponent<scorp6>().lamp_laser_b_bool = false;


                scorp6_obj.GetComponent<scorp6>().lamp_laser_a_bool = true;

                scorp6_obj.GetComponent<scorp6>().change_equipment();

                destroy = true;

            }





            if (which == "suppressor_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);


                destroy = true;


                if (scorp6_obj.GetComponent<scorp6>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    scorp6_obj.GetComponent<scorp6>().suppressor_a_bool = false;
                }

                if (scorp6_obj.GetComponent<scorp6>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    scorp6_obj.GetComponent<scorp6>().suppressor_c_bool = false;
                }

                if (scorp6_obj.GetComponent<scorp6>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    scorp6_obj.GetComponent<scorp6>().suppressor_d_bool = false;
                }

                scorp6_obj.GetComponent<scorp6>().suppressor_a_bool = true;

                scorp6_obj.GetComponent<scorp6>().change_equipment();



            }
            // suppresor b is just for one weapon useable
            if (which == "suppressor_c")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);




                destroy = true;

                if (scorp6_obj.GetComponent<scorp6>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    scorp6_obj.GetComponent<scorp6>().suppressor_a_bool = false;
                }

                if (scorp6_obj.GetComponent<scorp6>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    scorp6_obj.GetComponent<scorp6>().suppressor_c_bool = false;
                }

                if (scorp6_obj.GetComponent<scorp6>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    scorp6_obj.GetComponent<scorp6>().suppressor_d_bool = false;
                }

                scorp6_obj.GetComponent<scorp6>().suppressor_c_bool = true;

                scorp6_obj.GetComponent<scorp6>().change_equipment();



            }
            if (which == "suppressor_d")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);


                destroy = true;


                if (scorp6_obj.GetComponent<scorp6>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    scorp6_obj.GetComponent<scorp6>().suppressor_a_bool = false;
                }

                if (scorp6_obj.GetComponent<scorp6>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    scorp6_obj.GetComponent<scorp6>().suppressor_c_bool = false;
                }

                if (scorp6_obj.GetComponent<scorp6>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    scorp6_obj.GetComponent<scorp6>().suppressor_d_bool = false;
                }

                scorp6_obj.GetComponent<scorp6>().suppressor_d_bool = true;

                scorp6_obj.GetComponent<scorp6>().change_equipment();



            }

        }
        if (streetsub_bool)
        {


            // checking, what you picked up and determine it with a string check and turning off other equipment, if required to make the place for the new one free

            if (which == "suppressor_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);


                destroy = true;


                if (streetsub_obj.GetComponent<streetsub>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    streetsub_obj.GetComponent<streetsub>().suppressor_a_bool = false;
                }

                if (streetsub_obj.GetComponent<streetsub>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    streetsub_obj.GetComponent<streetsub>().suppressor_c_bool = false;
                }

                if (streetsub_obj.GetComponent<streetsub>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    streetsub_obj.GetComponent<streetsub>().suppressor_d_bool = false;
                }

                streetsub_obj.GetComponent<streetsub>().suppressor_a_bool = true;

                streetsub_obj.GetComponent<streetsub>().change_equipment();



            }
            if (which == "suppressor_c")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);




                destroy = true;

                if (streetsub_obj.GetComponent<streetsub>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    streetsub_obj.GetComponent<streetsub>().suppressor_a_bool = false;
                }

                if (streetsub_obj.GetComponent<streetsub>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    streetsub_obj.GetComponent<streetsub>().suppressor_c_bool = false;
                }

                if (streetsub_obj.GetComponent<streetsub>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    streetsub_obj.GetComponent<streetsub>().suppressor_d_bool = false;
                }

                streetsub_obj.GetComponent<streetsub>().suppressor_c_bool = true;

                streetsub_obj.GetComponent<streetsub>().change_equipment();



            }
            if (which == "suppressor_d")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);


                destroy = true;


                if (streetsub_obj.GetComponent<streetsub>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    streetsub_obj.GetComponent<streetsub>().suppressor_a_bool = false;
                }

                if (streetsub_obj.GetComponent<streetsub>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    streetsub_obj.GetComponent<streetsub>().suppressor_c_bool = false;
                }

                if (streetsub_obj.GetComponent<streetsub>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    streetsub_obj.GetComponent<streetsub>().suppressor_d_bool = false;
                }

                streetsub_obj.GetComponent<streetsub>().suppressor_d_bool = true;

                streetsub_obj.GetComponent<streetsub>().change_equipment();



            }

        }
        if (sturmgewehr46_bool)
        {


            // checking, what you picked up and determine it with a string check and turning off other equipment, if required to make the place for the new one free




            if (which == "lamp_laser_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);





                // same position, turning lamp_laser_b off

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().laser_a_bool)
                {
                    Drop("lamp_laser_a");
                }
                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().lamp_laser_a_bool)
                {
                    Drop("laser_a");
                }
                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_b");
                }
                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().lamp_laser_a_bool)
                {
                    Drop("lamp_a");
                }

                sturmgewehr46_obj.GetComponent<sturmgewehr46>().lamp_laser_a_bool = false;
                sturmgewehr46_obj.GetComponent<sturmgewehr46>().laser_a_bool = false;

                sturmgewehr46_obj.GetComponent<sturmgewehr46>().lamp_laser_b_bool = true;

                sturmgewehr46_obj.GetComponent<sturmgewehr46>().change_equipment();

                destroy = true;
            }
            if (which == "laser_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);







                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().laser_a_bool)
                {
                    Drop("lamp_laser_a");
                }
                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().lamp_laser_a_bool)
                {
                    Drop("laser_a");
                }
                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_b");
                }
                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().lamp_laser_a_bool)
                {
                    Drop("lamp_a");
                }


                sturmgewehr46_obj.GetComponent<sturmgewehr46>().lamp_laser_a_bool = false;
                sturmgewehr46_obj.GetComponent<sturmgewehr46>().lamp_laser_b_bool = false;


                sturmgewehr46_obj.GetComponent<sturmgewehr46>().laser_a_bool = true;

                sturmgewehr46_obj.GetComponent<sturmgewehr46>().change_equipment();

                destroy = true;

            }
            if (which == "lamp_laser_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);







                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().laser_a_bool)
                {
                    Drop("lamp_laser_a");
                }
                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().lamp_laser_a_bool)
                {
                    Drop("laser_a");
                }
                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_b");
                }
                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().lamp_laser_a_bool)
                {
                    Drop("lamp_a");
                }


                sturmgewehr46_obj.GetComponent<sturmgewehr46>().laser_a_bool = false;
                sturmgewehr46_obj.GetComponent<sturmgewehr46>().lamp_laser_b_bool = false;


                sturmgewehr46_obj.GetComponent<sturmgewehr46>().lamp_laser_a_bool = true;

                sturmgewehr46_obj.GetComponent<sturmgewehr46>().change_equipment();

                destroy = true;

            }


            // changing scopes
            if (which == "red_dot_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_a_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_b_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_c_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_d_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_e_bool = false;
                }



                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_a_bool)
                {
                    Drop("scope_a");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_a_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_b_bool)
                {
                    Drop("scope_b");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_b_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_c_bool)
                {
                    Drop("scope_c");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_c_bool = false;
                }




                sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_a_bool = true;





                sturmgewehr46_obj.GetComponent<sturmgewehr46>().change_equipment();


            }
            if (which == "red_dot_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_a_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_b_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_c_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_d_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_e_bool = false;
                }



                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_a_bool)
                {
                    Drop("scope_a");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_a_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_b_bool)
                {
                    Drop("scope_b");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_b_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_c_bool)
                {
                    Drop("scope_c");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_c_bool = false;
                }




                sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_b_bool = true;





                sturmgewehr46_obj.GetComponent<sturmgewehr46>().change_equipment();


            }
            if (which == "red_dot_c")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_a_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_b_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_c_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_d_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_e_bool = false;
                }



                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_a_bool)
                {
                    Drop("scope_a");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_a_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_b_bool)
                {
                    Drop("scope_b");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_b_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_c_bool)
                {
                    Drop("scope_c");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_c_bool = false;
                }




                sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_c_bool = true;





                sturmgewehr46_obj.GetComponent<sturmgewehr46>().change_equipment();


            }
            if (which == "red_dot_d")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_a_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_b_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_c_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_d_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_e_bool = false;
                }



                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_a_bool)
                {
                    Drop("scope_a");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_a_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_b_bool)
                {
                    Drop("scope_b");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_b_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_c_bool)
                {
                    Drop("scope_c");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_c_bool = false;
                }




                sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_d_bool = true;





                sturmgewehr46_obj.GetComponent<sturmgewehr46>().change_equipment();


            }
            if (which == "red_dot_e")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_a_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_b_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_c_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_d_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_e_bool = false;
                }



                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_a_bool)
                {
                    Drop("scope_a");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_a_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_b_bool)
                {
                    Drop("scope_b");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_b_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_c_bool)
                {
                    Drop("scope_c");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_c_bool = false;
                }



                sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_e_bool = true;





                sturmgewehr46_obj.GetComponent<sturmgewehr46>().change_equipment();


            }
            if (which == "scope_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_a_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_b_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_c_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_d_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_e_bool = false;
                }



                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_a_bool)
                {
                    Drop("scope_a");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_a_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_b_bool)
                {
                    Drop("scope_b");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_b_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_c_bool)
                {
                    Drop("scope_c");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_c_bool = false;
                }




                sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_a_bool = true;





                sturmgewehr46_obj.GetComponent<sturmgewehr46>().change_equipment();


            }
            if (which == "scope_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_a_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_b_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_c_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_d_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_e_bool = false;
                }



                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_a_bool)
                {
                    Drop("scope_a");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_a_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_b_bool)
                {
                    Drop("scope_b");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_b_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_c_bool)
                {
                    Drop("scope_c");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_c_bool = false;
                }




                sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_b_bool = true;





                sturmgewehr46_obj.GetComponent<sturmgewehr46>().change_equipment();


            }
            if (which == "scope_c")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_a_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_b_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_c_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_d_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().red_dot_e_bool = false;
                }



                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_a_bool)
                {
                    Drop("scope_a");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_a_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_b_bool)
                {
                    Drop("scope_b");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_b_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_c_bool)
                {
                    Drop("scope_c");
                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_c_bool = false;
                }





                sturmgewehr46_obj.GetComponent<sturmgewehr46>().scope_c_bool = true;





                sturmgewehr46_obj.GetComponent<sturmgewehr46>().change_equipment();


            }



            if (which == "suppressor_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);


                destroy = true;


                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().suppressor_a_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().suppressor_c_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().suppressor_d_bool = false;
                }

                sturmgewehr46_obj.GetComponent<sturmgewehr46>().suppressor_a_bool = true;

                sturmgewehr46_obj.GetComponent<sturmgewehr46>().change_equipment();



            }
            // suppresor b is just for one weapon useable
            if (which == "suppressor_c")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);




                destroy = true;

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().suppressor_a_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().suppressor_c_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().suppressor_d_bool = false;
                }

                sturmgewehr46_obj.GetComponent<sturmgewehr46>().suppressor_c_bool = true;

                sturmgewehr46_obj.GetComponent<sturmgewehr46>().change_equipment();



            }
            if (which == "suppressor_d")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);


                destroy = true;


                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().suppressor_a_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().suppressor_c_bool = false;
                }

                if (sturmgewehr46_obj.GetComponent<sturmgewehr46>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    sturmgewehr46_obj.GetComponent<sturmgewehr46>().suppressor_d_bool = false;
                }

                sturmgewehr46_obj.GetComponent<sturmgewehr46>().suppressor_d_bool = true;

                sturmgewehr46_obj.GetComponent<sturmgewehr46>().change_equipment();



            }

        }
        if (submachine_bool)
        {


            // checking, what you picked up and determine it with a string check and turning off other equipment, if required to make the place for the new one free





            // changing scopes
            if (which == "red_dot_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (submachine_obj.GetComponent<submachine5>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    submachine_obj.GetComponent<submachine5>().red_dot_a_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    submachine_obj.GetComponent<submachine5>().red_dot_b_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    submachine_obj.GetComponent<submachine5>().red_dot_c_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    submachine_obj.GetComponent<submachine5>().red_dot_d_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    submachine_obj.GetComponent<submachine5>().red_dot_e_bool = false;
                }



                if (submachine_obj.GetComponent<submachine5>().scope_a_bool)
                {
                    Drop("scope_a");
                    submachine_obj.GetComponent<submachine5>().scope_a_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().scope_b_bool)
                {
                    Drop("scope_b");
                    submachine_obj.GetComponent<submachine5>().scope_b_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().scope_c_bool)
                {
                    Drop("scope_c");
                    submachine_obj.GetComponent<submachine5>().scope_c_bool = false;
                }




                submachine_obj.GetComponent<submachine5>().red_dot_a_bool = true;





                submachine_obj.GetComponent<submachine5>().change_equipment();


            }
            if (which == "red_dot_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (submachine_obj.GetComponent<submachine5>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    submachine_obj.GetComponent<submachine5>().red_dot_a_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    submachine_obj.GetComponent<submachine5>().red_dot_b_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    submachine_obj.GetComponent<submachine5>().red_dot_c_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    submachine_obj.GetComponent<submachine5>().red_dot_d_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    submachine_obj.GetComponent<submachine5>().red_dot_e_bool = false;
                }



                if (submachine_obj.GetComponent<submachine5>().scope_a_bool)
                {
                    Drop("scope_a");
                    submachine_obj.GetComponent<submachine5>().scope_a_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().scope_b_bool)
                {
                    Drop("scope_b");
                    submachine_obj.GetComponent<submachine5>().scope_b_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().scope_c_bool)
                {
                    Drop("scope_c");
                    submachine_obj.GetComponent<submachine5>().scope_c_bool = false;
                }




                submachine_obj.GetComponent<submachine5>().red_dot_b_bool = true;





                submachine_obj.GetComponent<submachine5>().change_equipment();


            }
            if (which == "red_dot_c")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (submachine_obj.GetComponent<submachine5>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    submachine_obj.GetComponent<submachine5>().red_dot_a_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    submachine_obj.GetComponent<submachine5>().red_dot_b_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    submachine_obj.GetComponent<submachine5>().red_dot_c_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    submachine_obj.GetComponent<submachine5>().red_dot_d_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    submachine_obj.GetComponent<submachine5>().red_dot_e_bool = false;
                }



                if (submachine_obj.GetComponent<submachine5>().scope_a_bool)
                {
                    Drop("scope_a");
                    submachine_obj.GetComponent<submachine5>().scope_a_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().scope_b_bool)
                {
                    Drop("scope_b");
                    submachine_obj.GetComponent<submachine5>().scope_b_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().scope_c_bool)
                {
                    Drop("scope_c");
                    submachine_obj.GetComponent<submachine5>().scope_c_bool = false;
                }




                submachine_obj.GetComponent<submachine5>().red_dot_c_bool = true;





                submachine_obj.GetComponent<submachine5>().change_equipment();


            }
            if (which == "red_dot_d")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (submachine_obj.GetComponent<submachine5>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    submachine_obj.GetComponent<submachine5>().red_dot_a_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    submachine_obj.GetComponent<submachine5>().red_dot_b_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    submachine_obj.GetComponent<submachine5>().red_dot_c_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    submachine_obj.GetComponent<submachine5>().red_dot_d_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    submachine_obj.GetComponent<submachine5>().red_dot_e_bool = false;
                }



                if (submachine_obj.GetComponent<submachine5>().scope_a_bool)
                {
                    Drop("scope_a");
                    submachine_obj.GetComponent<submachine5>().scope_a_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().scope_b_bool)
                {
                    Drop("scope_b");
                    submachine_obj.GetComponent<submachine5>().scope_b_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().scope_c_bool)
                {
                    Drop("scope_c");
                    submachine_obj.GetComponent<submachine5>().scope_c_bool = false;
                }




                submachine_obj.GetComponent<submachine5>().red_dot_d_bool = true;





                submachine_obj.GetComponent<submachine5>().change_equipment();


            }
            if (which == "red_dot_e")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (submachine_obj.GetComponent<submachine5>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    submachine_obj.GetComponent<submachine5>().red_dot_a_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    submachine_obj.GetComponent<submachine5>().red_dot_b_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    submachine_obj.GetComponent<submachine5>().red_dot_c_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    submachine_obj.GetComponent<submachine5>().red_dot_d_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    submachine_obj.GetComponent<submachine5>().red_dot_e_bool = false;
                }



                if (submachine_obj.GetComponent<submachine5>().scope_a_bool)
                {
                    Drop("scope_a");
                    submachine_obj.GetComponent<submachine5>().scope_a_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().scope_b_bool)
                {
                    Drop("scope_b");
                    submachine_obj.GetComponent<submachine5>().scope_b_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().scope_c_bool)
                {
                    Drop("scope_c");
                    submachine_obj.GetComponent<submachine5>().scope_c_bool = false;
                }



                submachine_obj.GetComponent<submachine5>().red_dot_e_bool = true;





                submachine_obj.GetComponent<submachine5>().change_equipment();


            }
            if (which == "scope_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (submachine_obj.GetComponent<submachine5>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    submachine_obj.GetComponent<submachine5>().red_dot_a_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    submachine_obj.GetComponent<submachine5>().red_dot_b_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    submachine_obj.GetComponent<submachine5>().red_dot_c_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    submachine_obj.GetComponent<submachine5>().red_dot_d_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    submachine_obj.GetComponent<submachine5>().red_dot_e_bool = false;
                }



                if (submachine_obj.GetComponent<submachine5>().scope_a_bool)
                {
                    Drop("scope_a");
                    submachine_obj.GetComponent<submachine5>().scope_a_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().scope_b_bool)
                {
                    Drop("scope_b");
                    submachine_obj.GetComponent<submachine5>().scope_b_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().scope_c_bool)
                {
                    Drop("scope_c");
                    submachine_obj.GetComponent<submachine5>().scope_c_bool = false;
                }




                submachine_obj.GetComponent<submachine5>().scope_a_bool = true;





                submachine_obj.GetComponent<submachine5>().change_equipment();


            }
            if (which == "scope_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (submachine_obj.GetComponent<submachine5>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    submachine_obj.GetComponent<submachine5>().red_dot_a_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    submachine_obj.GetComponent<submachine5>().red_dot_b_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    submachine_obj.GetComponent<submachine5>().red_dot_c_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    submachine_obj.GetComponent<submachine5>().red_dot_d_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    submachine_obj.GetComponent<submachine5>().red_dot_e_bool = false;
                }



                if (submachine_obj.GetComponent<submachine5>().scope_a_bool)
                {
                    Drop("scope_a");
                    submachine_obj.GetComponent<submachine5>().scope_a_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().scope_b_bool)
                {
                    Drop("scope_b");
                    submachine_obj.GetComponent<submachine5>().scope_b_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().scope_c_bool)
                {
                    Drop("scope_c");
                    submachine_obj.GetComponent<submachine5>().scope_c_bool = false;
                }




                submachine_obj.GetComponent<submachine5>().scope_b_bool = true;





                submachine_obj.GetComponent<submachine5>().change_equipment();


            }
            if (which == "scope_c")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (submachine_obj.GetComponent<submachine5>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    submachine_obj.GetComponent<submachine5>().red_dot_a_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    submachine_obj.GetComponent<submachine5>().red_dot_b_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    submachine_obj.GetComponent<submachine5>().red_dot_c_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    submachine_obj.GetComponent<submachine5>().red_dot_d_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    submachine_obj.GetComponent<submachine5>().red_dot_e_bool = false;
                }



                if (submachine_obj.GetComponent<submachine5>().scope_a_bool)
                {
                    Drop("scope_a");
                    submachine_obj.GetComponent<submachine5>().scope_a_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().scope_b_bool)
                {
                    Drop("scope_b");
                    submachine_obj.GetComponent<submachine5>().scope_b_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().scope_c_bool)
                {
                    Drop("scope_c");
                    submachine_obj.GetComponent<submachine5>().scope_c_bool = false;
                }





                submachine_obj.GetComponent<submachine5>().scope_c_bool = true;





                submachine_obj.GetComponent<submachine5>().change_equipment();


            }



            if (which == "suppressor_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);


                destroy = true;


                if (submachine_obj.GetComponent<submachine5>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    submachine_obj.GetComponent<submachine5>().suppressor_a_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    submachine_obj.GetComponent<submachine5>().suppressor_c_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    submachine_obj.GetComponent<submachine5>().suppressor_d_bool = false;
                }

                submachine_obj.GetComponent<submachine5>().suppressor_a_bool = true;

                submachine_obj.GetComponent<submachine5>().change_equipment();



            }
            // suppresor b is just for one weapon useable
            if (which == "suppressor_c")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);




                destroy = true;

                if (submachine_obj.GetComponent<submachine5>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    submachine_obj.GetComponent<submachine5>().suppressor_a_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    submachine_obj.GetComponent<submachine5>().suppressor_c_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    submachine_obj.GetComponent<submachine5>().suppressor_d_bool = false;
                }

                submachine_obj.GetComponent<submachine5>().suppressor_c_bool = true;

                submachine_obj.GetComponent<submachine5>().change_equipment();



            }
            if (which == "suppressor_d")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);


                destroy = true;


                if (submachine_obj.GetComponent<submachine5>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    submachine_obj.GetComponent<submachine5>().suppressor_a_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    submachine_obj.GetComponent<submachine5>().suppressor_c_bool = false;
                }

                if (submachine_obj.GetComponent<submachine5>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    submachine_obj.GetComponent<submachine5>().suppressor_d_bool = false;
                }

                submachine_obj.GetComponent<submachine5>().suppressor_d_bool = true;

                submachine_obj.GetComponent<submachine5>().change_equipment();



            }

        }
        if (tarusk_bool)
        {


            // checking, what you picked up and determine it with a string check and turning off other equipment, if required to make the place for the new one free



            // left side of holder
            if (which == "lamp_a")
            {

                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                tarusk_obj.GetComponent<tarusk>().lamp_a_bool = true;

                // same position, turning lamp_laser_b off

                if (tarusk_obj.GetComponent<tarusk>().lamp_laser_b_bool)
                {
                    Drop("lamp_laser_b");
                }


                tarusk_obj.GetComponent<tarusk>().lamp_laser_b_bool = false;

                tarusk_obj.GetComponent<tarusk>().change_equipment();


            }
            if (which == "lamp_laser_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                tarusk_obj.GetComponent<tarusk>().lamp_laser_b_bool = true;

                // same position, turning lamp_laser_b off

                if (tarusk_obj.GetComponent<tarusk>().lamp_a_bool)
                {
                    Drop("lamp_a");

                    tarusk_obj.GetComponent<tarusk>().lamp_a_bool = false;
                }




                tarusk_obj.GetComponent<tarusk>().change_equipment();


            }


            // right side of holder
            if (which == "laser_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                tarusk_obj.GetComponent<tarusk>().laser_a_bool = true;



                if (tarusk_obj.GetComponent<tarusk>().lamp_laser_a_bool)
                {
                    Drop("lamp_laser_a");

                    tarusk_obj.GetComponent<tarusk>().lamp_laser_a_bool = false;
                }




                tarusk_obj.GetComponent<tarusk>().change_equipment();



            }
            if (which == "lamp_laser_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                tarusk_obj.GetComponent<tarusk>().lamp_laser_a_bool = true;



                if (tarusk_obj.GetComponent<tarusk>().laser_a_bool)
                {
                    Drop("lamp_laser_a");

                    tarusk_obj.GetComponent<tarusk>().laser_a_bool = false;
                }




                tarusk_obj.GetComponent<tarusk>().change_equipment();



            }


            // changing scopes
            if (which == "red_dot_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (tarusk_obj.GetComponent<tarusk>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    tarusk_obj.GetComponent<tarusk>().red_dot_a_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    tarusk_obj.GetComponent<tarusk>().red_dot_b_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    tarusk_obj.GetComponent<tarusk>().red_dot_c_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    tarusk_obj.GetComponent<tarusk>().red_dot_d_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    tarusk_obj.GetComponent<tarusk>().red_dot_e_bool = false;
                }



                if (tarusk_obj.GetComponent<tarusk>().scope_a_bool)
                {
                    Drop("scope_a");
                    tarusk_obj.GetComponent<tarusk>().scope_a_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().scope_b_bool)
                {
                    Drop("scope_b");
                    tarusk_obj.GetComponent<tarusk>().scope_b_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().scope_c_bool)
                {
                    Drop("scope_c");
                    tarusk_obj.GetComponent<tarusk>().scope_c_bool = false;
                }



                tarusk_obj.GetComponent<tarusk>().front_sight_bool = false;
                tarusk_obj.GetComponent<tarusk>().back_sight_bool = false;

                tarusk_obj.GetComponent<tarusk>().red_dot_a_bool = true;





                tarusk_obj.GetComponent<tarusk>().change_equipment();


            }
            if (which == "red_dot_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (tarusk_obj.GetComponent<tarusk>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    tarusk_obj.GetComponent<tarusk>().red_dot_a_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    tarusk_obj.GetComponent<tarusk>().red_dot_b_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    tarusk_obj.GetComponent<tarusk>().red_dot_c_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    tarusk_obj.GetComponent<tarusk>().red_dot_d_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    tarusk_obj.GetComponent<tarusk>().red_dot_e_bool = false;
                }



                if (tarusk_obj.GetComponent<tarusk>().scope_a_bool)
                {
                    Drop("scope_a");
                    tarusk_obj.GetComponent<tarusk>().scope_a_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().scope_b_bool)
                {
                    Drop("scope_b");
                    tarusk_obj.GetComponent<tarusk>().scope_b_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().scope_c_bool)
                {
                    Drop("scope_c");
                    tarusk_obj.GetComponent<tarusk>().scope_c_bool = false;
                }


                tarusk_obj.GetComponent<tarusk>().front_sight_bool = false;
                tarusk_obj.GetComponent<tarusk>().back_sight_bool = false;

                tarusk_obj.GetComponent<tarusk>().red_dot_b_bool = true;





                tarusk_obj.GetComponent<tarusk>().change_equipment();


            }
            if (which == "red_dot_c")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (tarusk_obj.GetComponent<tarusk>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    tarusk_obj.GetComponent<tarusk>().red_dot_a_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    tarusk_obj.GetComponent<tarusk>().red_dot_b_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    tarusk_obj.GetComponent<tarusk>().red_dot_c_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    tarusk_obj.GetComponent<tarusk>().red_dot_d_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    tarusk_obj.GetComponent<tarusk>().red_dot_e_bool = false;
                }



                if (tarusk_obj.GetComponent<tarusk>().scope_a_bool)
                {
                    Drop("scope_a");
                    tarusk_obj.GetComponent<tarusk>().scope_a_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().scope_b_bool)
                {
                    Drop("scope_b");
                    tarusk_obj.GetComponent<tarusk>().scope_b_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().scope_c_bool)
                {
                    Drop("scope_c");
                    tarusk_obj.GetComponent<tarusk>().scope_c_bool = false;
                }


                tarusk_obj.GetComponent<tarusk>().front_sight_bool = false;
                tarusk_obj.GetComponent<tarusk>().back_sight_bool = false;

                tarusk_obj.GetComponent<tarusk>().red_dot_c_bool = true;





                tarusk_obj.GetComponent<tarusk>().change_equipment();


            }
            if (which == "red_dot_d")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (tarusk_obj.GetComponent<tarusk>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    tarusk_obj.GetComponent<tarusk>().red_dot_a_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    tarusk_obj.GetComponent<tarusk>().red_dot_b_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    tarusk_obj.GetComponent<tarusk>().red_dot_c_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    tarusk_obj.GetComponent<tarusk>().red_dot_d_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    tarusk_obj.GetComponent<tarusk>().red_dot_e_bool = false;
                }



                if (tarusk_obj.GetComponent<tarusk>().scope_a_bool)
                {
                    Drop("scope_a");
                    tarusk_obj.GetComponent<tarusk>().scope_a_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().scope_b_bool)
                {
                    Drop("scope_b");
                    tarusk_obj.GetComponent<tarusk>().scope_b_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().scope_c_bool)
                {
                    Drop("scope_c");
                    tarusk_obj.GetComponent<tarusk>().scope_c_bool = false;
                }


                tarusk_obj.GetComponent<tarusk>().front_sight_bool = false;
                tarusk_obj.GetComponent<tarusk>().back_sight_bool = false;

                tarusk_obj.GetComponent<tarusk>().red_dot_d_bool = true;





                tarusk_obj.GetComponent<tarusk>().change_equipment();


            }
            if (which == "red_dot_e")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (tarusk_obj.GetComponent<tarusk>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    tarusk_obj.GetComponent<tarusk>().red_dot_a_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    tarusk_obj.GetComponent<tarusk>().red_dot_b_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    tarusk_obj.GetComponent<tarusk>().red_dot_c_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    tarusk_obj.GetComponent<tarusk>().red_dot_d_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    tarusk_obj.GetComponent<tarusk>().red_dot_e_bool = false;
                }



                if (tarusk_obj.GetComponent<tarusk>().scope_a_bool)
                {
                    Drop("scope_a");
                    tarusk_obj.GetComponent<tarusk>().scope_a_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().scope_b_bool)
                {
                    Drop("scope_b");
                    tarusk_obj.GetComponent<tarusk>().scope_b_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().scope_c_bool)
                {
                    Drop("scope_c");
                    tarusk_obj.GetComponent<tarusk>().scope_c_bool = false;
                }


                tarusk_obj.GetComponent<tarusk>().front_sight_bool = false;
                tarusk_obj.GetComponent<tarusk>().back_sight_bool = false;

                tarusk_obj.GetComponent<tarusk>().red_dot_e_bool = true;





                tarusk_obj.GetComponent<tarusk>().change_equipment();


            }
            if (which == "scope_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (tarusk_obj.GetComponent<tarusk>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    tarusk_obj.GetComponent<tarusk>().red_dot_a_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    tarusk_obj.GetComponent<tarusk>().red_dot_b_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    tarusk_obj.GetComponent<tarusk>().red_dot_c_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    tarusk_obj.GetComponent<tarusk>().red_dot_d_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    tarusk_obj.GetComponent<tarusk>().red_dot_e_bool = false;
                }



                if (tarusk_obj.GetComponent<tarusk>().scope_a_bool)
                {
                    Drop("scope_a");
                    tarusk_obj.GetComponent<tarusk>().scope_a_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().scope_b_bool)
                {
                    Drop("scope_b");
                    tarusk_obj.GetComponent<tarusk>().scope_b_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().scope_c_bool)
                {
                    Drop("scope_c");
                    tarusk_obj.GetComponent<tarusk>().scope_c_bool = false;
                }


                tarusk_obj.GetComponent<tarusk>().front_sight_bool = false;
                tarusk_obj.GetComponent<tarusk>().back_sight_bool = false;

                tarusk_obj.GetComponent<tarusk>().scope_a_bool = true;





                tarusk_obj.GetComponent<tarusk>().change_equipment();


            }
            if (which == "scope_b")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (tarusk_obj.GetComponent<tarusk>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    tarusk_obj.GetComponent<tarusk>().red_dot_a_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    tarusk_obj.GetComponent<tarusk>().red_dot_b_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    tarusk_obj.GetComponent<tarusk>().red_dot_c_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    tarusk_obj.GetComponent<tarusk>().red_dot_d_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    tarusk_obj.GetComponent<tarusk>().red_dot_e_bool = false;
                }



                if (tarusk_obj.GetComponent<tarusk>().scope_a_bool)
                {
                    Drop("scope_a");
                    tarusk_obj.GetComponent<tarusk>().scope_a_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().scope_b_bool)
                {
                    Drop("scope_b");
                    tarusk_obj.GetComponent<tarusk>().scope_b_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().scope_c_bool)
                {
                    Drop("scope_c");
                    tarusk_obj.GetComponent<tarusk>().scope_c_bool = false;
                }


                tarusk_obj.GetComponent<tarusk>().front_sight_bool = false;
                tarusk_obj.GetComponent<tarusk>().back_sight_bool = false;

                tarusk_obj.GetComponent<tarusk>().scope_b_bool = true;





                tarusk_obj.GetComponent<tarusk>().change_equipment();


            }
            if (which == "scope_c")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);

                destroy = true;

                // checking, droping and turning off other scopes


                if (tarusk_obj.GetComponent<tarusk>().red_dot_a_bool)
                {
                    Drop("red_dot_a");
                    tarusk_obj.GetComponent<tarusk>().red_dot_a_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().red_dot_b_bool)
                {
                    Drop("red_dot_b");
                    tarusk_obj.GetComponent<tarusk>().red_dot_b_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().red_dot_c_bool)
                {
                    Drop("red_dot_c");
                    tarusk_obj.GetComponent<tarusk>().red_dot_c_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().red_dot_d_bool)
                {
                    Drop("red_dot_d");
                    tarusk_obj.GetComponent<tarusk>().red_dot_d_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().red_dot_e_bool)
                {
                    Drop("red_dot_e");
                    tarusk_obj.GetComponent<tarusk>().red_dot_e_bool = false;
                }



                if (tarusk_obj.GetComponent<tarusk>().scope_a_bool)
                {
                    Drop("scope_a");
                    tarusk_obj.GetComponent<tarusk>().scope_a_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().scope_b_bool)
                {
                    Drop("scope_b");
                    tarusk_obj.GetComponent<tarusk>().scope_b_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().scope_c_bool)
                {
                    Drop("scope_c");
                    tarusk_obj.GetComponent<tarusk>().scope_c_bool = false;
                }



                tarusk_obj.GetComponent<tarusk>().front_sight_bool = false;
                tarusk_obj.GetComponent<tarusk>().back_sight_bool = false;

                tarusk_obj.GetComponent<tarusk>().scope_c_bool = true;





                tarusk_obj.GetComponent<tarusk>().change_equipment();


            }



            if (which == "suppressor_a")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);


                destroy = true;


                if (tarusk_obj.GetComponent<tarusk>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    tarusk_obj.GetComponent<tarusk>().suppressor_a_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    tarusk_obj.GetComponent<tarusk>().suppressor_c_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    tarusk_obj.GetComponent<tarusk>().suppressor_d_bool = false;
                }

                tarusk_obj.GetComponent<tarusk>().suppressor_a_bool = true;

                tarusk_obj.GetComponent<tarusk>().change_equipment();



            }
            // suppresor b is just for one weapon useable
            if (which == "suppressor_c")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);




                destroy = true;

                if (tarusk_obj.GetComponent<tarusk>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    tarusk_obj.GetComponent<tarusk>().suppressor_a_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    tarusk_obj.GetComponent<tarusk>().suppressor_c_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    tarusk_obj.GetComponent<tarusk>().suppressor_d_bool = false;
                }

                tarusk_obj.GetComponent<tarusk>().suppressor_c_bool = true;

                tarusk_obj.GetComponent<tarusk>().change_equipment();



            }
            if (which == "suppressor_d")
            {
                AudioSource.PlayClipAtPoint(click, transform.position);


                destroy = true;


                if (tarusk_obj.GetComponent<tarusk>().suppressor_a_bool)
                {
                    Drop("suppressor_a");

                    tarusk_obj.GetComponent<tarusk>().suppressor_a_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().suppressor_c_bool)
                {
                    Drop("suppressor_c");

                    tarusk_obj.GetComponent<tarusk>().suppressor_c_bool = false;
                }

                if (tarusk_obj.GetComponent<tarusk>().suppressor_d_bool)
                {
                    Drop("suppressor_d");

                    tarusk_obj.GetComponent<tarusk>().suppressor_d_bool = false;
                }

                tarusk_obj.GetComponent<tarusk>().suppressor_d_bool = true;

                tarusk_obj.GetComponent<tarusk>().change_equipment();



            }

        }







        // changing weapons

        if (which == "Assault57")
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;

          

            assault57_bool = true;
            destroy = true;


            check_weapon_drop();


            exit_weapons();

            active_assault57.SetActive(true);
            Icon_assault57.SetActive(true);
            active_assault57.GetComponent<assault57>().Start();

            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


            


        }
        if (which == "auge")
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


            auge_bool = true;
            destroy = true;

            check_weapon_drop();

            exit_weapons();
            active_auge.SetActive(true);
            active_auge.GetComponent<auge>().Start();
            Icon_auge.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }
        
        if (which == "blast_set")
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;



            auge_bool = true;
            destroy = true;

            check_weapon_drop();

            exit_weapons();
            active_blastset.SetActive(true);
            active_blastset.GetComponent<blast_set>().Start();
            Icon_blastset.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }
        if (which == "buzzsub")
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;



            buzzsub_bool = true;
            destroy = true;

            // droping current weapon, which you hold it hand
            check_weapon_drop();

            // leaving all weapons
            exit_weapons();

            active_buzzsub.SetActive(true);
            active_buzzsub.GetComponent<buzzsub>().Start();
            Icon_buzzsub.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }

        if (which == "clusterShotgun")
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


            destroy = true;

            // droping current weapon, which you hold it hand
            check_weapon_drop();

            // leaving all weapons
            exit_weapons();

            active_clusterShotgun.SetActive(true);
            active_clusterShotgun.GetComponent<clusterShotgun>().Start();
            Icon_clusterShotgun.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }
        if (which == "clustersub")
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;



            clusterSub_bool = true;
            destroy = true;

            // droping current weapon, which you hold it hand
            check_weapon_drop();

            // leaving all weapons
            exit_weapons();

            active_clustersub.SetActive(true);
            active_clustersub.GetComponent<clustersub>().Start();
            Icon_clustersub.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }

        if (which == "crowbar")
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;



            destroy = true;

            // droping current weapon, which you hold it hand
            check_weapon_drop();

            // leaving all weapons
            exit_weapons();

            active_crowbar.SetActive(true);
            active_crowbar.GetComponent<crossbar>().Start();
            Icon_crowbar.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }
        if (which == "axe")
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;



            destroy = true;

            // droping current weapon, which you hold it hand
            check_weapon_drop();

            // leaving all weapons
            exit_weapons();

            active_fireaxe.SetActive(true);
            active_fireaxe.GetComponent<axe>().Start();
            Icon_fireaxe.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }

        if (which == "flamethrower")
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;



            destroy = true;


            check_weapon_drop();


            exit_weapons();

            active_flamethrower.SetActive(true);
            Icon_flamethrower.SetActive(true);
            active_flamethrower.GetComponent<flamethrower>().Start();

            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);





        }
        if (which == "grenade")
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


            destroy = true;

            check_weapon_drop();

            exit_weapons();
            active_grenade.SetActive(true);
            active_grenade.GetComponent<grenade>().Start();
            Icon_grenade.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }




        if (which == "grenade_launcher")
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;



            destroy = true;


            check_weapon_drop();


            exit_weapons();

            active_grenade_launcher.SetActive(true);
            Icon_grenade_launcher.SetActive(true);
            active_grenade_launcher.GetComponent<grenade_launcher>().Start();

            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);





        }
        if (which == "hunter_rifle")
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


            destroy = true;

            check_weapon_drop();

            exit_weapons();
            active_hunterrifle.SetActive(true);
            active_hunterrifle.GetComponent<hunter_rifle>().Start();
            Icon_hunterrifle.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }

        if (which == "lock")
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


            lock_bool = true;
            destroy = true;

            check_weapon_drop();

            exit_weapons();
            active_lock.SetActive(true);
            active_lock.GetComponent<lock_>().Start();
            Icon_lock.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }
        if (which == "machine_gun")
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


            machineGun_bool = true;
            destroy = true;

            check_weapon_drop();

            exit_weapons();
            active_machine_gun.SetActive(true);
            active_machine_gun.GetComponent<machine_gun>().Start();
            Icon_machine_gun.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }

        if (which == "mkb16")
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


            mkb16_bool = true;
            destroy = true;

            check_weapon_drop();

            exit_weapons();
            active_mkb16.SetActive(true);
            active_mkb16.GetComponent<mkb16>().Start();
            Icon_mkb16.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }
        if (which == "nsp")
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


            nsp_bool = true;
            destroy = true;

            check_weapon_drop();

            exit_weapons();
            active_nsp.SetActive(true);
            active_nsp.GetComponent<nsp>().Start();
            Icon_nsp.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }

        if (which == "old_pistol")
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


            old_pistol_bool = true;
            destroy = true;

            check_weapon_drop();

            exit_weapons();
            active_old_pistol.SetActive(true);
            active_old_pistol.GetComponent<old_pistol>().Start();
            Icon_old_pistol.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }
        if (which == "pistol")
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


            pistol9_bool = true;
            destroy = true;

            check_weapon_drop();

            exit_weapons();
            active_pistol9.SetActive(true);
            active_pistol9.GetComponent<pistol9>().Start();
            Icon_pistol9.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }

        if (which == "pumpgun_a")
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


            pumpgun_a_bool = true;
            destroy = true;

            check_weapon_drop();

            exit_weapons();
            active_pumpgun_a.SetActive(true);
            active_pumpgun_a.GetComponent<pumpgun_a>().Start();
            Icon_pumpgun_a.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }
        if (which == "revolver")
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;

            destroy = true;

            check_weapon_drop();

            exit_weapons();
            active_revolver.SetActive(true);
            active_revolver.GetComponent<revolver>().Start();
            Icon_revolver.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }

        if (which == "rocket_launcher")
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


   
            destroy = true;

            check_weapon_drop();

            exit_weapons();
            active_rocket_launcher.SetActive(true);
            active_rocket_launcher.GetComponent<rocket_launcher>().Start();
            Icon_rocket_launcher.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }
        if (which == "rp9")
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


            rp9_bool = true;
            destroy = true;

            check_weapon_drop();

            exit_weapons();
            active_rp9.SetActive(true);
            active_rp9.GetComponent<rp9>().Start();
            Icon_rp9.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }

        if (which == "russian_sniper")
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


           
            destroy = true;

            check_weapon_drop();

            exit_weapons();
            active_russian_sniper.SetActive(true);
            active_russian_sniper.GetComponent<russian_sniper>().Start();
            Icon_russian_sniper.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }
        if (which == "sce5")
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


            sce5_bool = true;
            destroy = true;

            check_weapon_drop();

            exit_weapons();
            active_sce5.SetActive(true);
            active_sce5.GetComponent<sce5>().Start();
            Icon_sce5.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }

        if (which == "scorp6")
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


            scorp6_bool = true;
            destroy = true;

            check_weapon_drop();

            exit_weapons();
            active_scorp6.SetActive(true);
            active_scorp6.GetComponent<scorp6>().Start();
            Icon_scorp6.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }
        if (which == "shotgun3")
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


         
            destroy = true;

            check_weapon_drop();

            exit_weapons();
            active_shotgun3.SetActive(true);
            active_shotgun3.GetComponent<shotgun3>().Start();
            Icon_shotgun3.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }

        if (which == "streetsub")
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


            streetsub_bool = true;
            destroy = true;

            check_weapon_drop();

            exit_weapons();
            active_streetsub.SetActive(true);
            active_streetsub.GetComponent<streetsub>().Start();
            Icon_streetsub.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }
        if (which == "sturmgewehr46")
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


            sturmgewehr46_bool = true;
            destroy = true;

            check_weapon_drop();

            exit_weapons();
            active_sturmgewehr46.SetActive(true);
            active_sturmgewehr46.GetComponent<sturmgewehr46>().Start();
            Icon_sturmgewehr46.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }

        if (which == "submachine5")
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


            submachine_bool = true;
            destroy = true;

            check_weapon_drop();

            exit_weapons();
            active_submachine5.SetActive(true);
            active_submachine5.GetComponent<submachine5>().Start();
            Icon_submachine5.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }
        if (which == "tarusk")
        {


            tarusk_bool = false;
            submachine_bool = false;
            sturmgewehr46_bool = false;
            streetsub_bool = false;
            scorp6_bool = false;
            sce5_bool = false;
            rp9_bool = false;
            pumpgun_a_bool = false;
            pistol9_bool = false;
            old_pistol_bool = false;
            nsp_bool = false;
            mkb16_bool = false;
            machineGun_bool = false;
            lock_bool = false;
            clusterSub_bool = false;
            buzzsub_bool = false;
            auge_bool = false;
            assault57_bool = false;


            tarusk_bool = true;
            destroy = true;

            check_weapon_drop();

            exit_weapons();
            active_tarusk.SetActive(true);
            active_tarusk.GetComponent<tarusk>().Start();
            Icon_tarusk.SetActive(true);
            // restarting animator
            animator_obj.SetActive(false);
            animator_obj.SetActive(true);


        }





    }


    public void exit_weapons()
    {

        // leaving all weapon scripts


     active_assault57.GetComponent<assault57>().turn_off_weapon();
     active_auge.GetComponent<auge>().turn_off_weapon();
     active_blastset.GetComponent<blast_set>().turn_off_weapon();
     active_buzzsub.GetComponent<buzzsub>().turn_off_weapon();
     active_clusterShotgun.GetComponent<clusterShotgun>().turn_off_weapon();
     active_clustersub.GetComponent<clustersub>().turn_off_weapon();
     active_crowbar.GetComponent<crossbar>().turn_off_weapon();
     active_fireaxe.GetComponent<axe>().turn_off_weapon();
     active_flamethrower.GetComponent<flamethrower>().turn_off_weapon();
     active_grenade.GetComponent<grenade>().turn_off_weapon();
     active_grenade_launcher.GetComponent<grenade_launcher>().turn_off_weapon();
     active_hunterrifle.GetComponent<hunter_rifle>().turn_off_weapon();
     active_lock.GetComponent<lock_>().turn_off_weapon();
     active_machine_gun.GetComponent<machine_gun>().turn_off_weapon();
     active_mkb16.GetComponent<mkb16>().turn_off_weapon();
     active_nsp.GetComponent<nsp>().turn_off_weapon();
     active_old_pistol.GetComponent<old_pistol>().turn_off_weapon();
     active_pistol9.GetComponent<pistol9>().turn_off_weapon();
     active_pumpgun_a.GetComponent<pumpgun_a>().turn_off_weapon();
     active_revolver.GetComponent<revolver>().turn_off_weapon();
     active_rocket_launcher.GetComponent<rocket_launcher>().turn_off_weapon();
     active_rp9.GetComponent<rp9>().turn_off_weapon();
     active_russian_sniper.GetComponent<russian_sniper>().turn_off_weapon();
     active_sce5.GetComponent<sce5>().turn_off_weapon();
     active_scorp6.GetComponent<scorp6>().turn_off_weapon();
     active_shotgun3.GetComponent<shotgun3>().turn_off_weapon();
     active_streetsub.GetComponent<streetsub>().turn_off_weapon();
     active_sturmgewehr46.GetComponent<sturmgewehr46>().turn_off_weapon();
     active_submachine5.GetComponent<submachine5>().turn_off_weapon();
     active_tarusk.GetComponent<tarusk>().turn_off_weapon();


        // turning off all weapons (inclusing scripts)

        active_assault57.SetActive(false);
        active_auge.SetActive(false);
        active_blastset.SetActive(false);
        active_buzzsub.SetActive(false);
        active_clusterShotgun.SetActive(false);
        active_clustersub.SetActive(false);
        active_crowbar.SetActive(false);
        active_fireaxe.SetActive(false);
        active_flamethrower.SetActive(false);
        active_grenade.SetActive(false);
        active_grenade_launcher.SetActive(false);
        active_hunterrifle.SetActive(false);
        active_lock.SetActive(false);
        active_machine_gun.SetActive(false);
        active_mkb16.SetActive(false);
        active_nsp.SetActive(false);
        active_old_pistol.SetActive(false);
        active_pistol9.SetActive(false);
        active_pumpgun_a.SetActive(false);
        active_revolver.SetActive(false);
        active_rocket_launcher.SetActive(false);
        active_rp9.SetActive(false);
        active_russian_sniper.SetActive(false);
        active_sce5.SetActive(false);
        active_scorp6.SetActive(false);
        active_shotgun3.SetActive(false);
        active_streetsub.SetActive(false);
        active_sturmgewehr46.SetActive(false);
        active_submachine5.SetActive(false);
        active_tarusk.SetActive(false);




        // turning all weapon icons off

        Icon_assault57.SetActive(false);
        Icon_auge.SetActive(false);
        Icon_blastset.SetActive(false);
        Icon_buzzsub.SetActive(false);
        Icon_clusterShotgun.SetActive(false);
        Icon_clustersub.SetActive(false);
        Icon_crowbar.SetActive(false);
        Icon_fireaxe.SetActive(false);
        Icon_flamethrower.SetActive(false);
        Icon_grenade.SetActive(false);
        Icon_grenade_launcher.SetActive(false);
        Icon_hunterrifle.SetActive(false);
        Icon_lock.SetActive(false);
        Icon_machine_gun.SetActive(false);
        Icon_mkb16.SetActive(false);
        Icon_nsp.SetActive(false);
        Icon_old_pistol.SetActive(false);
        Icon_pistol9.SetActive(false);
        Icon_pumpgun_a.SetActive(false);
        Icon_revolver.SetActive(false);
        Icon_rocket_launcher.SetActive(false);
        Icon_rp9.SetActive(false);
        Icon_russian_sniper.SetActive(false);
        Icon_sce5.SetActive(false);
        Icon_scorp6.SetActive(false);
        Icon_shotgun3.SetActive(false);
        Icon_streetsub.SetActive(false);
        Icon_sturmgewehr46.SetActive(false);
        Icon_submachine5.SetActive(false);
        Icon_tarusk.SetActive(false);




    }




    public void check_weapon_drop()
    {
        // checking, which weapon is active, to drop, because it's getting replaced


        if (active_assault57.activeSelf)
        {
            Drop("Assault57");
        }
        if (active_auge.activeSelf)
        {
            Drop("auge");
        }
        if (active_blastset.activeSelf)
        {
            Drop("blast_set");
        }
        if (active_buzzsub.activeSelf)
        {
            Drop("buzzsub");
        }
        if (active_clusterShotgun.activeSelf)
        {
            Drop("clusterShotgun");
        }
        if (active_clusterShotgun.activeSelf)
        {
            Drop("clusterShotgun");
        }

        if (active_clustersub.activeSelf)
        {
            Drop("clustersub");
        }
        if (active_crowbar.activeSelf)
        {
            Drop("crowbar");
        }
        if (active_fireaxe.activeSelf)
        {
            Drop("axe");
        }
        if (active_flamethrower.activeSelf)
        {
            Drop("flamethrower");
        }


        if (active_grenade.activeSelf)
        {
            Drop("grenade");
        }
        if (active_grenade_launcher.activeSelf)
        {
            Drop("grenade_launcher");
        }
        if (active_hunterrifle.activeSelf)
        {
            Drop("hunter_rifle");
        }
        if (active_lock.activeSelf)
        {
            Drop("lock");
        }
        if (active_machine_gun.activeSelf)
        {
            Drop("machine_gun");
        }
        if (active_mkb16.activeSelf)
        {
            Drop("mkb16");
        }
        if (active_nsp.activeSelf)
        {
            Drop("nsp");
        }
        if (active_old_pistol.activeSelf)
        {
            Drop("old_pistol");
        }
        if (active_pistol9.activeSelf)
        {
            Drop("pistol");
        }
        if (active_pumpgun_a.activeSelf)
        {
            Drop("pumpgun_a");
        }



        if (active_revolver.activeSelf)
        {
            Drop("revolver");
        }
        if (active_rocket_launcher.activeSelf)
        {
            Drop("rocket_launcher");
        }
        if (active_rp9.activeSelf)
        {
            Drop("rp9");
        }
        if (active_russian_sniper.activeSelf)
        {
            Drop("russian_sniper");
        }
        if (active_sce5.activeSelf)
        {
            Drop("sce5");
        }
        if (active_scorp6.activeSelf)
        {
            Drop("scorp6");
        }
        if (active_shotgun3.activeSelf)
        {
            Drop("shotgun3");
        }
        if (active_streetsub.activeSelf)
        {
            Drop("streetsub");
        }
        if (active_sturmgewehr46.activeSelf)
        {
            Drop("sturmgewehr46");
        }
        if (active_submachine5.activeSelf)
        {
            Drop("submachine5");
        }
        if (active_tarusk.activeSelf)
        {
            Drop("tarusk");
        }



    }




    // replaced intems like an other scope
    public void Drop(string which)
    {


        // dropping scopes, if you replace the current slot

        if(which == "lamp_a")
        {

            Instantiate(lamp_a, transform.position, transform.rotation);

        }
        if (which == "lamp_laser_b")
        {

            Instantiate(lamp_laser_b, transform.position, transform.rotation);

        }
        if (which == "laser_a")
        {

            Instantiate(laser_a, transform.position, transform.rotation);

        }
        if (which == "lamp_laser_a")
        {

            Instantiate(lamp_laser_a, transform.position, transform.rotation);

        }


        if (which == "red_dot_a")
        {

            Instantiate(red_dot_a, transform.position, transform.rotation);

        }
        if (which == "red_dot_b")
        {

            Instantiate(red_dot_b, transform.position, transform.rotation);

        }
        if (which == "red_dot_c")
        {

            Instantiate(red_dot_c, transform.position, transform.rotation);

        }
        if (which == "red_dot_d")
        {

            Instantiate(red_dot_d, transform.position, transform.rotation);

        }
        if (which == "red_dot_e")
        {

            Instantiate(red_dot_e, transform.position, transform.rotation);

        }
        if (which == "scope_a")
        {

            Instantiate(scope_a, transform.position, transform.rotation);

        }
        if (which == "scope_b")
        {

            Instantiate(scope_b, transform.position, transform.rotation);

        }
        if (which == "scope_c")
        {

            Instantiate(scope_c, transform.position, transform.rotation);

        }


        if (which == "suppressor_a")
        {

            Instantiate(suppressor_a, transform.position, transform.rotation);

        }
        if (which == "suppressor_b")
        {

            Instantiate(suppressor_clustersub, transform.position, transform.rotation);

        }
        if (which == "suppressor_c")
        {

            Instantiate(suppressor_c, transform.position, transform.rotation);

        }
        if (which == "suppressor_d")
        {

            Instantiate(suppressor_d, transform.position+ new Vector3(0,2,0), transform.rotation);

        }


        // dropping weapon, which got replaced with an new one


        if(which == "Assault57")
        {
            Instantiate(drop_assault57, transform.position + new Vector3(0, 2, 0), transform.rotation);
        }
        if (which == "auge")
        {
            Instantiate(drop_auge, transform.position + new Vector3(0, 2, 0), transform.rotation);
        }
        if (which == "blast_set")
        {
            Instantiate(drop_blastset, transform.position + new Vector3(0, 2, 0), transform.rotation);
        }
        if (which == "buzzsub")
        {
            Instantiate(drop_buzzsub, transform.position + new Vector3(0, 2, 0), transform.rotation);
        }



        if (which == "clusterShotgun")
        {
            Instantiate(drop_clusterShotgun, transform.position + new Vector3(0, 2, 0), transform.rotation);
        }
        if (which == "clustersub")
        {
            Instantiate(drop_clustersub, transform.position + new Vector3(0, 2, 0), transform.rotation);
        }
        if (which == "crowbar")
        {
            Instantiate(drop_crowbar, transform.position + new Vector3(0, 2, 0), transform.rotation);
        }
        if (which == "axe")
        {
            Instantiate(drop_fireaxe, transform.position + new Vector3(0, 2, 0), transform.rotation);
        }


        if (which == "flamethrower")
        {
            Instantiate(drop_flamethrower, transform.position + new Vector3(0, 2, 0), transform.rotation);
        }
        if (which == "grenade")
        {
            Instantiate(drop_grenade, transform.position + new Vector3(0, 2, 0), transform.rotation);
        }
        if (which == "grenade_launcher")
        {
            Instantiate(drop_grenade_launcher, transform.position + new Vector3(0, 2, 0), transform.rotation);
        }
        if (which == "hunter_rifle")
        {
            Instantiate(drop_hunterrifle, transform.position + new Vector3(0, 2, 0), transform.rotation);
        }


        if (which == "lock")
        {
            Instantiate(drop_lock, transform.position + new Vector3(0, 2, 0), transform.rotation);
        }
        if (which == "machine_gun")
        {
            Instantiate(drop_machine_gun, transform.position + new Vector3(0, 2, 0), transform.rotation);
        }
        if (which == "mkb16")
        {
            Instantiate(drop_mkb16, transform.position + new Vector3(0, 2, 0), transform.rotation);
        }
        if (which == "nsp")
        {
            Instantiate(drop_nsp, transform.position + new Vector3(0, 2, 0), transform.rotation);
        }


        if (which == "old_pistol")
        {
            Instantiate(drop_old_pistol, transform.position + new Vector3(0, 2, 0), transform.rotation);
        }
        if (which == "pistol")
        {
            Instantiate(drop_pistol9, transform.position + new Vector3(0, 2, 0), transform.rotation);
        }
        if (which == "pumpgun_a")
        {
            Instantiate(drop_pumpgun_a, transform.position + new Vector3(0, 2, 0), transform.rotation);
        }
        if (which == "revolver")
        {
            Instantiate(drop_revolver, transform.position + new Vector3(0, 2, 0), transform.rotation);
        }


        if (which == "rocket_launcher")
        {
            Instantiate(drop_rocket_launcher, transform.position + new Vector3(0, 2, 0), transform.rotation);
        }
        if (which == "rp9")
        {
            Instantiate(drop_rp9, transform.position + new Vector3(0, 2, 0), transform.rotation);
        }
        if (which == "russian_sniper")
        {
            Instantiate(drop_russian_sniper, transform.position + new Vector3(0, 2, 0), transform.rotation);
        }
        if (which == "sce5")
        {
            Instantiate(drop_sce5, transform.position + new Vector3(0, 2, 0), transform.rotation);
        }



        if (which == "scorp6")
        {
            Instantiate(drop_scorp6, transform.position + new Vector3(0, 2, 0), transform.rotation);
        }
        if (which == "shotgun3")
        {
            Instantiate(drop_shotgun3, transform.position + new Vector3(0, 2, 0), transform.rotation);
        }
        if (which == "streetsub")
        {
            Instantiate(drop_streetsub, transform.position + new Vector3(0, 2, 0), transform.rotation);
        }
        if (which == "sturmgewehr46")
        {
            Instantiate(drop_sturmgewehr46, transform.position + new Vector3(0, 2, 0), transform.rotation);
        }



        if (which == "submachine5")
        {
            Instantiate(drop_submachine5, transform.position + new Vector3(0, 2, 0), transform.rotation);
        }
        if (which == "tarusk")
        {
            Instantiate(drop_tarusk, transform.position + new Vector3(0, 2, 0), transform.rotation);
        }







    }







}
