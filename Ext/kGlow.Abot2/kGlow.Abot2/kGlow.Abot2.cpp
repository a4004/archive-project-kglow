// kGlow.Abot2.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
#include "C:\Users\Alex\Documents\VS Projects\Hybrid\Draft\kGlow\Ext\kGlow.Bhop\kGlow.Bhop\Header.h"
#include <iostream>
#include "class.hpp"

const double PI = 3.141592653589793238463;

IGLOW kDriver = IGLOW("\\\\.\\glow");

DWORD PID = kDriver.GETPID();
DWORD CLIENT = kDriver.GETCLIENT();
DWORD ENGINE = kDriver.GETENGINE();


struct vec3
{
    float x;
    float y;
    float z;
};


float Distance(vec3 from, vec3 to)
{
    vec3 delta = vec3{ from.x - to.x, from.y - to.y, from.z - to.z };
    return sqrt(delta.x * delta.x + delta.y * delta.y + delta.z * delta.z);
}

float RadianToDegree(float radian)
{
    return radian * (180 / PI);
}

float DegreeToRadian(float degree)
{
    return degree * (PI / 180);
}

vec3 RadianToDegree(vec3 radians)
{
    vec3 degrees;
    degrees.x = radians.x * (180 / PI);
    degrees.y = radians.y * (180 / PI);
    degrees.z = radians.z * (180 / PI);
    return degrees;
}

vec3 DegreeToRadian(vec3 degrees)
{
    vec3 radians;
    radians.x = degrees.x * (PI / 180);
    radians.y = degrees.y * (PI / 180);
    radians.z = degrees.z * (PI / 180);
    return radians;
}

vec3 CalcAngle(vec3 src, vec3 dst)
{
    vec3 angle;
    angle.x = -atan2f(dst.x - src.x, dst.y - src.y) / PI * 180.0f + 180.0f;
    angle.y = asinf((dst.z - src.z) / Distance(src, dst)) * 180.0f / PI;
    angle.z = 0.0f;

    return angle;
}

void ClampAngle(vec3& angle) {
    if (angle.x > 89.0f) angle.x = 89.f;
    if (angle.x < -89.0f) angle.x = -89.f;

    if (angle.y > 180.f) angle.y = 180.f;
    if (angle.y < -180.f) angle.y = -180.f;

    angle.z = 0.0f;
}

void Normalise(vec3& angle) {
    if (angle.x > 89.0f) angle.x -= 180.0f;
    if (angle.x < -89.0f) angle.x += 180.0f;

    while (angle.y > 180) angle.y -= 360.f;
    while (angle.y < -180) angle.y += 360.f;
}


vec3 GetBestTarget()
{
    float oldDistance = FLT_MAX;
    float newDistance = 0;

    vec3 Angle;

    DWORD LocalPlayer = kDriver.RVM<DWORD>(PID, CLIENT + signatures::dwLocalPlayer, sizeof(DWORD));
    DWORD LocalTeam = kDriver.RVM<DWORD>(PID, LocalPlayer + netvars::m_iTeamNum, sizeof(DWORD));

    for (int i = 1; i < 64; i++)
    {
        DWORD CurrentEntity = kDriver.RVM<DWORD>(PID, CLIENT + signatures::dwEntityList + i * 0x10, sizeof(DWORD));
        DWORD CurrentTeam = kDriver.RVM<DWORD>(PID, CurrentEntity + netvars::m_iTeamNum, sizeof(DWORD));
        DWORD CurrentHealth = kDriver.RVM<DWORD>(PID, CurrentEntity + netvars::m_iHealth, sizeof(DWORD));
        BOOL CurrentDormancy = kDriver.RVM<BOOL>(PID, CurrentEntity + signatures::m_bDormant, sizeof(BOOL));

        if (CurrentTeam != LocalTeam && CurrentHealth > 0 && !CurrentDormancy)
        {
            vec3 MyLocation = kDriver.RVM<vec3>(PID, LocalPlayer + netvars::m_vecOrigin, sizeof(vec3));
            vec3 TheirLocation = kDriver.RVM<vec3>(PID, CurrentEntity + netvars::m_vecOrigin, sizeof(vec3));

            vec3 MyAngles = kDriver.RVM<vec3>(PID, ENGINE + signatures::dwClientState_ViewAngles, sizeof(vec3));

            vec3 angleTo = CalcAngle(MyLocation, TheirLocation);
            newDistance = Distance(MyAngles, angleTo);

            if (newDistance < oldDistance)
            {
                oldDistance = newDistance;
                Angle = angleTo;
            }
        }
    }

    return Angle;
}

int main()
{
    while (true)
    {
        vec3 aimat = GetBestTarget();
        
        kDriver.WVM<vec3>(PID, ENGINE + signatures::dwClientState_ViewAngles, aimat, sizeof(vec3));
   }
}
