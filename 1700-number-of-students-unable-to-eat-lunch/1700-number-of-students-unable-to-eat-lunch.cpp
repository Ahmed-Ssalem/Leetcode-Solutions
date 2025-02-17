class Solution {
public:
    int countStudents(vector<int>& students, vector<int>& sandwiches) {
        
        queue<int> studentQueue;
        int sandwichIndex = 0;  
        int unsuccessfulCount = 0;

        for(int student : students){
            studentQueue.push(student);
        }

        while (!studentQueue.empty() && sandwichIndex < sandwiches.size()){
            
            if (studentQueue.front() != sandwiches[sandwichIndex]){
                studentQueue.push(studentQueue.front());
                studentQueue.pop();
                unsuccessfulCount++;
            }
            else{
                studentQueue.pop();
                sandwichIndex++;
                unsuccessfulCount = 0;
            }

            if (unsuccessfulCount == studentQueue.size())
                    break;
        }
        return studentQueue.size();
    }
};