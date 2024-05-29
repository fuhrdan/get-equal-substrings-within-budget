int equalSubstring(char* s, char* t, int maxCost) {
    int len = strlen(s);
    int i = 0;
    int j = 0;
    int answer = 0;
    int remainingCost = maxCost;
    int currentCost = 0;
    int con1 = 0;
    int con2 = 0;
    while (j < len)
    {  
        con1 = s[j];
        con2 = t[j];
        if (con1 - con2 > 0)
        {
            currentCost = con1 - con2;
        }
        else
        {
            currentCost = con2 - con1;
        }
        remainingCost = remainingCost - currentCost;
        while (remainingCost < 0)
        {
            con1 = s[i];
            con2 = t[i];
            if (con1 - con2 > 0)
            {
                remainingCost = remainingCost + con1 - con2;
            }
            else
            {
                remainingCost = remainingCost + con2 - con1;
            }
            i++;
        }
        if(answer < (j - i + 1))
        {
            answer = j - i + 1;
        }
        j++;

    }
    return answer;
}