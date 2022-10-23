using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawingPad : MonoBehaviour
{
    private Mesh m_Mesh;
    private Vector3 m_LastMousePosition;

    private void Awake()
    {
        m_Mesh = GetComponent<MeshFilter>().mesh;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Mesh mesh = new Mesh(); 
            Vector3 mouse_pos = Input.mousePosition;
            mouse_pos.z = 50;

            Vector3[] vertices = new Vector3[4];
            Vector2[] uv = new Vector2[4];
            int[] triangles = new int[6];

            vertices[0] = new Vector3(-1,1);
            vertices[1] = new Vector3(-1,-1);
            vertices[2] = new Vector3(1,-1);
            vertices[3] = new Vector3(1,1);

            uv[0] = Vector2.zero;
            uv[1] = Vector2.zero;
            uv[2] = Vector2.zero;
            uv[3] = Vector2.zero;

            triangles[0] = 0;
            triangles[1] = 3;
            triangles[2] = 1;

            triangles[3] = 1;
            triangles[4] = 3;
            triangles[5] = 2;

            mesh.vertices = vertices;
            mesh.uv = uv;
            mesh.triangles = triangles;
            mesh.MarkDynamic();

            GetComponent<MeshFilter>().mesh = mesh;

            Vector3 mouse = Input.mousePosition;
            mouse.z = 50;
            m_LastMousePosition = Camera.main.ScreenToWorldPoint(mouse);

        }
        if (Input.GetMouseButton(0))
        {
            Vector3[] vertices = new Vector3[m_Mesh.vertexCount + 2];
            Vector2[] uv = new Vector2[m_Mesh.uv.Length + 2];
            int[] triangles = new int[m_Mesh.triangles.Length + 6];

            m_Mesh.vertices.CopyTo(vertices, 0);
            m_Mesh.uv.CopyTo(uv, 0);
            m_Mesh.triangles.CopyTo(triangles, 0);

            int vertex_index = vertices.Length - 4;
            int vertex_index_0 = vertex_index;
            int vertex_index_1 = vertex_index + 1;
            int vertex_index_2 = vertex_index + 2;
            int vertex_index_3 = vertex_index + 3;

            Vector3 mouse_pos = Input.mousePosition;
            mouse_pos.z = 50;
            Vector3 forward_vector = (Camera.main.ScreenToWorldPoint(mouse_pos) - m_LastMousePosition).normalized;
            Vector3 normal_2d = new Vector3(0,0,-1f);
            float line_thickness = 1f;
            Vector3 new_vertex_up = Camera.main.ScreenToWorldPoint(mouse_pos) + Vector3.Cross(forward_vector, normal_2d) * line_thickness;
            Vector3 new_vertex_down = Camera.main.ScreenToWorldPoint(mouse_pos) + Vector3.Cross(forward_vector, normal_2d * -1f) * line_thickness;

            vertices[vertex_index_2] = new_vertex_up;
            vertices[vertex_index_3] = new_vertex_down;

            uv[vertex_index_2] = Vector2.zero;
            uv[vertex_index_3] = Vector2.zero;

            int triangle_index = triangles.Length - 6;
            triangles[triangle_index + 0] = vertex_index_0;
            triangles[triangle_index + 1] = vertex_index_3;
            triangles[triangle_index + 2] = vertex_index_1;

            triangles[triangle_index + 3] = vertex_index_1;
            triangles[triangle_index + 4] = vertex_index_3;
            triangles[triangle_index + 5] = vertex_index_2;

            m_Mesh.vertices = vertices;
            m_Mesh.uv = uv;
            m_Mesh.triangles = triangles;

            m_LastMousePosition = Camera.main.ScreenToWorldPoint(mouse_pos);
        }
    }
}
