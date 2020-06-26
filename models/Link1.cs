using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kruskal
{
    class Link1 : IComparable
    {
        #region Members
        Node v1, v2;
        int nCost1;
        System.Drawing.Point pStringPosition;
        #endregion

        #region Properties
        public Node V1
        {
            get
            {
                return v1;
            }
        }
        public Node V2
        {
            get
            {
                return v2;
            }
        }
        public int Cost
        {
            get
            {
                return nCost1;
            }
        }
        public System.Drawing.Point StringPosition
        {
            get
            {
                return pStringPosition;
            }
        }
        #endregion

        public Link1(Node v1, Node v2, int nCost, System.Drawing.Point pStringPosition)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.nCost1 = nCost;
            this.pStringPosition = pStringPosition;
        }

        #region IComparable Members

        public int CompareTo(object obj)
        {
            Link1 e = (Link1)obj;
            return this.nCost1.CompareTo(e.nCost1);
        }
        #endregion

    }
}
