class Node {
public:
    int val;
    Node* next;
    Node (int val) {
        this -> val = val;
        next = NULL;
    }
};


class MyLinkedList {
public:
    
    int size = 0;
    Node* head = new Node(0);
    
    MyLinkedList() {
        
    }
    
    int get(int index) {
        if (index >= size) 
            return -1;
        Node* cur = head -> next;
        for (int i = 0; i < index; ++i)
            cur = cur -> next;
        return cur -> val;
    }
    
    void addAtHead(int val) {
        Node* cur = head -> next;
        head -> next = new Node(val);
        head -> next -> next = cur;
        size++;
    }
    
    void addAtTail(int val) {
        Node* cur = head;
        while (cur -> next != NULL)
            cur = cur -> next;
        cur -> next = new Node(val);
        size++;
    }
    
    void addAtIndex(int index, int val) {
        if (index > size)
            return;
        Node* cur = head;
        for (int i = 0; i < index; ++i)
            cur = cur -> next;
        Node* cur1 = cur -> next;
        cur -> next = new Node(val);
        cur -> next -> next = cur1;
        size++;
    }
    
    void deleteAtIndex(int index) {
        if (index >= size)
            return;
        Node* cur = head;
        for (int i = 0; i < index; ++i)
            cur = cur -> next;
        Node* cur1 = cur -> next;
        cur -> next = cur1 -> next;
        cur1 -> next = NULL;
        size--;
        delete cur1;
        
    }
};

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList* obj = new MyLinkedList();
 * int param_1 = obj->get(index);
 * obj->addAtHead(val);
 * obj->addAtTail(val);
 * obj->addAtIndex(index,val);
 * obj->deleteAtIndex(index);
 */