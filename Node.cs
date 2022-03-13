namespace COIS3020_Ropes {
    class RopeNode
    {
        // private variables initialized
        private int weight;
        private string value;
        private RopeNode left, right;

        //property for weight field.
        public int Weight 
        {
            get {return this.weight;} 
            set {this.weight = value;}
        } 
        //property for value field.
        public string Value 
        {
            get {return this.value;} 
            set {this.value = value;}
        } 
        //property for left node.
        public RopeNode Left 
        {
            get {return this.left;} 
            set {this.left = value;}
        } 
        //property for right node.
        public RopeNode Right
        {
            get {return this.right;} 
            set {this.right = value;}
        } 

        // empty constructor
        public RopeNode( ) 
        {
            this.Weight = 0;
            this.Value = "";
            this.Left = null;
            this.Right = null;
        }
        // constructor with only weight
        public RopeNode(int weight) 
        {
            this.Weight = weight;
            this.Value = "";
            this.Left = null;
            this.Right = null;
        }
        // constructor with weight and value
        public RopeNode(int weight, string value) 
        {
            this.Weight = weight;
            this.Value = value;
            this.Left = null;
            this.Right = null;
        }

        public override string ToString() //ToString method overload 
        {
            return this.Value;
        }
    }
}