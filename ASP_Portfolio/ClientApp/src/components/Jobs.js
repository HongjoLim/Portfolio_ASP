import React, { Component } from 'react';
import axios from 'axios';

export class Jobs extends Component {

    constructor(props){
        super(props);

        this.onJobUpdate = this.onJobUpdate.bind(this);

        this.state = {
            jobs: [],
            loading: true
        }
    }

    componentDidMount(){
        this.populateJobsData();
    }

    populateJobsData(){
        axios.get("api/jobs/GetAllJobs").then(result => {
            const response = result.data;
            this.setState({jobs: response, loading: false});
        })
    }

    onJobUpdate = (id) => {
        const {history} = this.props;
        history.push('/detail/' + id);
    }

    renderAllJobsTable(jobs){
        return (
            <table className="table table-striped">
                <thead>
                    <tr>
                        <th>Title</th>
                        <th>Company</th>
                        <th>City</th>
                        <th>Province</th>
                        <th>Start Date</th>
                        <th>End Date</th>
                        <th>Action</th>
                    </tr>
                </thead>
                <tbody>
                    {
                        jobs.map(job => (
                    <tr key={job.id}>
                        <td>{job.title}</td>
                        <td>{job.company}</td>
                        <td>{job.city}</td>
                        <td>{job.province}</td>
                        <td>{new Date(job.startDate).toLocaleDateString()}</td>
                        <td>{job.endDate ? new Date(job.endDate).toLocaleDateString() : `Current Job`}</td>
                        <td>
                            <div className="form-group">
                                <button onClick={() => this.onJobUpdate(job.id)} className="btn btn-success">
                                    Update
                                </button>
                            </div>
                        </td>
                    </tr>
                        ))
                    }
                </tbody>
            </table>
        )
    }
    

    render(){
        const content = this.state.loading ? (
            <p><em>Loading...</em></p>
        ) : (
            this.renderAllJobsTable(this.state.jobs)
        )
        return (
        <>
            <h1>All Jobs</h1>
            <p>Here are all jobs</p>
            {content}
        </>
        )
    }
}