using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GridCell
{
    public class CellGrid : MonoBehaviour
    {
   
        [SerializeField] private Cell[,] _matricCell;
        [SerializeField] private Cell _cellPrefab;        
        [SerializeField] private int _line;
        [SerializeField] private int _column;

        public void SetupGrid(int line,int column)
        {
            _matricCell=new Cell[line,column];
        }
        public void CreateGrid()
        {
            float _xSize = _cellPrefab.transform.localScale.x;
            float _ySize = _cellPrefab.transform.localScale.y;
            _matricCell=new Cell[_line,_column];
            Vector3 offset = new Vector3(0, 0, 0); 
            for( int i = 0; i < _line; i++)
            {
                for( int j = 0; j < _column; j++)
                {

                     Cell cell = _matricCell[i, j] = Instantiate(_cellPrefab,offset, Quaternion.identity,gameObject.transform);
                    cell.transform.localPosition = new Vector3(offset.x, offset.y, 0);
                    offset.x = offset.x + (_xSize*1.1f);
                }
                offset.x = 0;
                offset.y = offset.y + (_ySize * 1.1f);
            }

        }
        private void Start() 
        {
            CreateGrid();
        }

    }

}