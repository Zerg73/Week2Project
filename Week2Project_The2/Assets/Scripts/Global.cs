using UnityEngine;
public static class Global {
    public static bool isPause;//�����Ƿ���ͣ
    public static float volumeRate;//��������

    public static void Pause()
    {

        Global.isPause = !Global.isPause;

        Time.timeScale = Global.isPause ? 0 : 1;

    }
}