import React from 'react';
import { connect } from 'react-redux';
import axios from 'axios'


//const Home = props => (
//    <h1>Prueba</h1>
//);




class Home extends React.Component {
    constructor() {
        super();
        this.state = {
            ProductData: []
        }
    }

    componentDidMount() {
        axios.get("https://localhost:44319/api/Product/Obtener").then(response => {
            console.log(response.data);  
            this.setState({
                ProductData: response.data
            });
        });
    }

    render() {

        return (
            <section>
                <h1>Products List</h1>
                <div>
                   
                    <table className="table table-dark table-striped">
                        <thead><tr><th>Product Id</th><th>Product Name</th><th>Product Category</th><th>Product Price</th></tr></thead>
                        <tbody>
                            {
                                this.state.ProductData.map((p, index) => {
                                    return <tr key={index}>
                                        <td>{p.productId}</td>
                                        <td> {p.productName}</td>
                                        <td>{p.productCategory}</td>
                                        <td>{p.productPrice}</td>
                                        <td><button className="btn btn-info">Columna {p.productId}</button></td>
                                    </tr>;
                                })
                            }
                        </tbody>
                    </table>
                </div>

            </section>           
        )
    }
}  
export default connect()(Home);